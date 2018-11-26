using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1
{
    public partial class CurrentJob : Form
    {
        //public int idx;
        //public string Namee;
        //public string Company;
        //public string Language;
        //public int Salary;
        //public string Description;
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        Job.Jobs TheJob;
        public SqlConnection conCurrentJob = new SqlConnection();
        private string idU, typeU;
        public CurrentJob(Job.Jobs CurJob, SqlConnection con, string idUser, string typeUser)
        {
            InitializeComponent();

            //lbName.Text = Namee;
            //lbCom.Text = Company;
            //lbLang.Text = Language;
            //lbSalary.Text = Salary.ToString();
            //txtBDescription.Text = Description;
            TheJob = CurJob;
            pictBLogo.Image = System.Drawing.Image.FromFile("images\\" + TheJob.Company + ".jpeg");
            lbName.Text = CurJob.Name;
            lbLang.Text = CurJob.Language;
            lbCom.Text = CurJob.Company;
            lbSalary.Text = CurJob.Salary;
            txtBDescription.Text = CurJob.Description;

            conCurrentJob = con;
            idU = idUser;
            typeU = typeUser;
        }

        //private void btnCLose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

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


            using (conCurrentJob)

            {
                //conCurrentJob.Open();
                //Form1.con.Open();

                FileStream fStream = File.OpenRead(txtCV.Text);

                byte[] contents = new byte[fStream.Length];

                fStream.Read(contents, 0, (int)fStream.Length);

                fStream.Close();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("insert into APPLY " + "(PDFFile, IDCAND, IDJOB)values(@data, @id, @idJ)", conCurrentJob))
                    {
                        cmd.Parameters.AddWithValue("@data", contents);
                        cmd.Parameters.AddWithValue("@id", idU);
                        cmd.Parameters.AddWithValue("@idJ", TheJob.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn đã đăng kí rồi");
                }


                //conCurrentJob.Close();
            }
            
            //Document doc = new Document();
            /*Tại sao phải mở file doc ra rồi thêm 1 chữ a vào xong đóng lại?
            mục đích mấy dòng này là tạo ra file dpf thôi.
            Nhưng mà khi xuống dòng lệnh using (System.IO.FileStream fs = new System.IO.FileStream(ToSaveFileTo, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            thì nó lại không cho mở file ra chép vô vì cái doc đang mở file đó rồi, nên trước hết phải đóng lại.
            Nhưng mà visual lại không cho đóng file tự tiện vậy, đại khái lỗi là trong file pdf không có dữ liệu nào nên không cho đóng
            do đó thêm đại 1 chữ a vô cho nó đóng được, dù gì tí nữa xuống kia cũng ghi đè lên lại hết*/

            #region SAVECV
            //PdfWriter.GetInstance(doc, new FileStream("CV\\NQD.pdf", FileMode.Create));

            //doc.Open();
            //Paragraph p1 = new Paragraph("a");
            //doc.Add(p1);
            //doc.Close();
            //string ToSaveFileTo = "CV\\1.JPEG";

            //using (conCurrentJob)
            //{
            //    //conCurrentJob = new SqlConnection("Data Source=DESKTOP-E1R7M37;Initial Catalog=JOBS;Integrated Security=True");
            //    //conCurrentJob.Open();

            //    using (SqlCommand cmd = new SqlCommand("select PDFFile from SavePDFTable  where ID='" + "9" + "' ", conCurrentJob))
            //    {
            //        using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.Default))
            //        {
            //            if (dr.Read())
            //            {
            //                byte[] fileData = (byte[])dr.GetValue(0);

            //                using (System.IO.FileStream fs = new System.IO.FileStream(ToSaveFileTo
            //                    , System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            //                {
            //                    using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
            //                    {
            //                        bw.Write(fileData);

            //                        bw.Close();

            //                        MessageBox.Show("Done");
            //                    }

            //                }

            //            }
                        
            //            dr.Close();
            //        }

            //    }

            //}
            #endregion
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

        private void txtBDescription_TextChanged(object sender, EventArgs e)
        {

        }



        //private void label7_Click(object sender, EventArgs e)
        //{

        //}
    }
}
