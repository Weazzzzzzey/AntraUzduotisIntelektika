
namespace AntraUzduotisIntelektika
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMIClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasirinkimai = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(9, 337);
            this.ReadDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(136, 19);
            this.ReadDataButton.TabIndex = 1;
            this.ReadDataButton.Text = "Pasirinkti failą";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Failo vieta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.HeightCM,
            this.Weight,
            this.KMIClass,
            this.KMI,
            this.Gender});
            this.dataGridView1.Location = new System.Drawing.Point(9, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 305);
            this.dataGridView1.TabIndex = 4;
            // 
            // Names
            // 
            this.Names.HeaderText = "Vardas";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.Width = 125;
            // 
            // HeightCM
            // 
            this.HeightCM.HeaderText = "Ūgis";
            this.HeightCM.MinimumWidth = 6;
            this.HeightCM.Name = "HeightCM";
            this.HeightCM.Width = 60;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Svoris";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.Width = 60;
            // 
            // KMIClass
            // 
            this.KMIClass.HeaderText = "Klasė";
            this.KMIClass.MinimumWidth = 6;
            this.KMIClass.Name = "KMIClass";
            this.KMIClass.Width = 125;
            // 
            // KMI
            // 
            this.KMI.HeaderText = "KMI";
            this.KMI.MinimumWidth = 6;
            this.KMI.Name = "KMI";
            this.KMI.Width = 60;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Lytis";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 60;
            // 
            // Pasirinkimai
            // 
            this.Pasirinkimai.AutoSize = true;
            this.Pasirinkimai.Location = new System.Drawing.Point(562, 28);
            this.Pasirinkimai.Name = "Pasirinkimai";
            this.Pasirinkimai.Size = new System.Drawing.Size(62, 13);
            this.Pasirinkimai.TabIndex = 5;
            this.Pasirinkimai.Text = "Pasirinkimai";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(563, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(563, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ūgis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Svoris";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Paskaičiuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pasirinkimai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadDataButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMIClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.Label Pasirinkimai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

