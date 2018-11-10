using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CurrentJob : Form
    {
        public int idx;
        public string Namee;
        public string Company;
        public string Language;
        public int Salary;
        public string Description;
        public OpenFileDialog openFileDialog = new OpenFileDialog();

        public CurrentJob(string Namee, string Company, string Language, int Salary, string Description)
        {
            InitializeComponent();

            lbName.Text = Namee;
            lbCom.Text = Company;
            lbLang.Text = Language;
            lbSalary.Text = Salary.ToString();
            txtBDescription.Text = Description;
            pictBLogo.Image = Image.FromFile("images\\" + lbCom.Text + ".jpeg");
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //        saveFileDialog1.InitialDirectory = @"C:\";  
            //saveFileDialog1.Title = "Save text Files";
            //        saveFileDialog1.CheckFileExists = true;
            //        saveFileDialog1.CheckPathExists = true;
            //        saveFileDialog1.DefaultExt = "txt";
            //        saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //        saveFileDialog1.FilterIndex = 2;
            //        saveFileDialog1.RestoreDirectory = true;

            //        saveFileDialog1.FileName = txtCV.Text;
            //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            //using (StreamWriter sw = new StreamWriter(savefile.FileName))
            //            //    sw.WriteLine("Hello World!");
            //        }

            //string path = txtCV.Text;
            //string path2 = "CV\\";

            //if (!File.Exists(path))
            //{
            //    {
            //        // This statement ensures that the file is created, 
            //        // but the handle is not kept. 
            //        using (FileStream fs = File.Create(path)) { }
            //    }

            //    System.IO.Directory.Move("E:\\Files\\25-11-2017", @"E://Anusha//aaa");

            //    // Move the file.
            //    File.Move(path, path2);
            //    MessageBox.Show("File Moved");
            //}
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCV.Text = openFileDialog.FileName;
                
            }
        }

     

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}
    }
}
