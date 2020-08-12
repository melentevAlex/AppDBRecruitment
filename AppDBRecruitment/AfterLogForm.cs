using AppDBRecruitment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDBRecruitment
{
    public partial class AfterLogForm : Form
    {
        Form1 form1;
        UserDetailes userDetailes;
        private string lblText;
        private int role;
        public AfterLogForm(string lblText, int role)
        {
            InitializeComponent();
            this.lblText = lblText;         
            this.role = role;         
        }

        public void LblMeth()
        {

            labelYouAre.Text = lblText;
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            ResumeForm resumeForm = new ResumeForm();
            this.Hide();
            if (resumeForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

            ShowAllSearchers allSearchers = new ShowAllSearchers();
            this.Hide();
            if (allSearchers.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonMakeVacansy_Click(object sender, EventArgs e)
        {
            MakeVacancyForm makeVacancyForm = new MakeVacancyForm();
            this.Hide();
            if (makeVacancyForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonShowVacancy_Click(object sender, EventArgs e)
        {
            Vacancy vacancy = new Vacancy();
            this.Hide();
            if (vacancy.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void AfterLogForm_Load_1(object sender, EventArgs e)
        {
            labelYouAre.Text = lblText;
            // нужно взять роль зашедшего, а не создавать нового юза
            if (role == 3)
            {
                // 3 - значит работадатель
                SearchButton.Visible = true;
                buttonMakeVacansy.Visible = true;
                buttonShowVacancy.Visible = false;
                ResumeButton.Visible = false;
            }
            if (role == 4)
            {
                buttonShowVacancy.Visible = true;
                ResumeButton.Visible = true;
                SearchButton.Visible = false;
                buttonMakeVacansy.Visible = false;
            }
            labelYouAre.Text = lblText;
        }

        private void buttonCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
