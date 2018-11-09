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

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}
    }
}
