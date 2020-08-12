using AppDBRecruitment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDBRecruitment
{
    public partial class ShowAllSearchers : Form
    {
        Resume resume;
        ResumeForm resumeForm;
        Form1 form1;
        public string Currency { get; set; }
        public ShowAllSearchers()
        {
            InitializeComponent();
        }

        private void ShowAllSearchers_Load(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                var resume = (from res in db.Resumes
                              where res.IsNew == true
                              select new
                              {
                                  Name = res.Name,
                                  Discription = res.Discription,
                                  Salary = res.Salary,
                                  Author = res.User.UserDetailes.Fill_NameOfOrg
                              });
                ResDataGridView.DataSource = resume.ToList();
                this.ResDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 = new Form1();
            form1.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //private void SortSalary()
        //{
        //    if (Currency == "$")
        //    {

        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {

                var resume = (from res in db.Resumes
                              orderby res.Salary
                              where res.IsNew == true
                              select new
                              {
                                  Name = res.Name,
                                  Discription = res.Discription,
                                  Salary = res.Salary,
                                  Author = res.User.UserDetailes.Fill_NameOfOrg
                              });
                ResDataGridView.DataSource = resume.ToList();
                this.ResDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void buttonSortedByName_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {

                var resume = (from res in db.Resumes
                              orderby res.Name
                              where res.IsNew == true
                              select new
                              {
                                  Name = res.Name,
                                  Discription = res.Discription,
                                  Salary = res.Salary,
                                  Author = res.User.UserDetailes.Fill_NameOfOrg
                              });
                ResDataGridView.DataSource = resume.ToList();
                this.ResDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void buttonCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
