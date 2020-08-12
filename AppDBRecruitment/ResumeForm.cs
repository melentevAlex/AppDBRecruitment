using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDBRecruitment.Model;
namespace AppDBRecruitment
{
    public partial class ResumeForm : Form
    {
        Form1 form1;
        ShowAllSearchers showAllSearchers;

        public ResumeForm()
        {
            InitializeComponent();
        }
        private void ResumeForm_Load(object sender, EventArgs e)
        {

        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                //User user = new User() {Login = form1.CurrentUser.Login, Password = form1.CurrentUser.Password};
                
                Resume resume = new Resume() { Name = NameTextBox.Text, Discription = DistextBox.Text, Salary = $"{SalarytextBox.Text} {comboBoxCurrency.SelectedItem}", UserId = AppHelper.currentUser.Id};

                db.Resumes.AddRange(resume);

                db.SaveChanges();
                MessageBox.Show("Changes are saved");
            }
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

        private void buttonCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}