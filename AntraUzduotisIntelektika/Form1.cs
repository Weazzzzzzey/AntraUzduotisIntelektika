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
        
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
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
            
            List<DistanceData> SortedDistance = Estimates.Kontroleris(OriginalData, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToSingle(textBox3.Text),3);

            MessageBox.Show(SortedDistance.Count.ToString());

            dataGridView1.Rows.Clear();
            addToListNewData(SortedDistance);

            //string table = "";
            //foreach (var item in SortedDistance)
            //{
            //    table = table + item.Height + " " + item.Weight + " " + item.DistanceFirst + " " + item.DistanceSecond + "| ";
            //}

            
            
            //MessageBox.Show(table);
        }

        public void addToListNewData(List<DistanceData> SortedDistance)
        {

            foreach (var item in SortedDistance)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.Rows.Add(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender);
                } else

                if (comboBox1.SelectedIndex == 1)
                {
                    if (item.Gender == 0)
                    {
                        dataGridView1.Rows.Add(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender);
                    }
                } else

                if (comboBox1.SelectedIndex == 2)
                {
                    if (item.Gender == 1)
                    {
                        dataGridView1.Rows.Add(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender);
                    }
                }
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
    }

}
