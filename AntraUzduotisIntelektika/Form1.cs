using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AntraUzduotisIntelektika
{
    public partial class Form1 : Form
    {

        private List<DataClassKMI> OriginalData = new List<DataClassKMI>();
        Estimates Estimates = new Estimates();
        int trackBarValue = 0;
        
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            trackBar1.Maximum = 1;
            trackBar2.Maximum = 1;
            trackBar3.Maximum = 1;
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            TrackBarValuesGenerator();
            textBox1.Text = "190";
            textBox2.Text = "85";
            textBox3.Text = "28";
            comboBox1.SelectedIndex = 0;
            textBox4.Text = "1000";
            //comboBox2.SelectedIndex = 0;
            label13.Hide();
        }

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            label2.Text = openFileDialog.FileName;
            label2.Show();
            ShowData();
        }


        private void ShowData()
        {

            OriginalData.Clear();
            dataGridView1.Rows.Clear();
            
            string[] lines = File.ReadAllLines(label2.Text);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] OneLine = lines[i].Split(';');

                string[] DataLine = OneLine[0].Split(',');

                string Name = DataLine[0];
                int Height = Convert.ToInt32(DataLine[1]);
                int Weight = Convert.ToInt32(DataLine[2]);
                string ClassKMI = DataLine[3];
                float KMI = Convert.ToSingle(DataLine[4].Replace('.',','));
                int Gender = Convert.ToInt32(DataLine[5]);

                OriginalData.Add(new DataClassKMI(Name,Height,Weight,ClassKMI,KMI,Gender));
                dataGridView1.Rows.Add(Name, Height, Weight, ClassKMI, KMI, Gender);

            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            if (SetCombination() != 100)
            {
                //MessageBox.Show(SetCombination().ToString());

                List<DistanceData> SortedDistance = Estimates.Kontroleris(OriginalData, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToSingle(textBox3.Text), SetCombination(), Convert.ToInt32(textBox4.Text), comboBox2.SelectedIndex + 1, Convert.ToInt32(comboBox1.SelectedIndex));

                dataGridView1.Rows.Clear();
                addToListNewData(SortedDistance);
            }
            else
                MessageBox.Show("Nepilnai pasirinkta.");

        }

        private int SetCombination()
        {

            int Combination = 100;

            if (!label7.Text.Equals("100%"))
            {
                label13.Hide();
            }

            if (label7.Text.Equals("100%") && label8.Text.Equals("33%"))
            {
                label13.Show();
                label13.Text = "Skaičiuojama pagal pilną forumę.";
                Combination = 3;
            }

            if (label7.Text.Equals("100%") && label8.Text.Equals("50%") && label9.Text.Equals("50%"))
            {
                label13.Show();
                label13.Text = "Skaičiuojama pagal ūgį ir svorį.";
                Combination = 0;
            }

            if (label7.Text.Equals("100%") && label9.Text.Equals("50%") && label10.Text.Equals("50%"))
            {
                label13.Show();
                label13.Text = "Skaičiuojama pagal svorį ir KMI.";
                Combination = 2;
            }

            if (label7.Text.Equals("100%") && label8.Text.Equals("50%") && label10.Text.Equals("50%"))
            {
                label13.Show();
                label13.Text = "Skaičiuojama pagal ūgį ir KMI.";
                Combination = 1;
            }

            return Combination;
        }


        public void addToListNewData(List<DistanceData> SortedDistance)
        {

            foreach (var item in SortedDistance)
            {

                dataGridView1.Rows.Add(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in OriginalData)
            {
                dataGridView1.Rows.Add(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBarValuesGenerator();
        }

        private void TrackBarValuesGenerator()
        {
            label8.Text = (trackBar1.Value * 50).ToString() + "%";
            label9.Text = (trackBar2.Value * 50).ToString() + "%";
            label10.Text = (trackBar3.Value * 50).ToString() + "%";
            trackBarValue = (trackBar1.Value + trackBar2.Value + trackBar3.Value) * 50;
            label7.Text = trackBarValue.ToString() + "%";

            if (trackBar1.Value == 1 && trackBar2.Value == 1 && trackBar3.Value == 1)
            {
                label8.Text = 33 + "%";
                label9.Text = 33 + "%";
                label10.Text = 33 + "%";
                label7.Text = 100 + "%";
            }
            
            
            if (label7.Text.Equals("100%"))
            {
                label7.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label7.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            TrackBarValuesGenerator();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            TrackBarValuesGenerator();
        }

    }

}
