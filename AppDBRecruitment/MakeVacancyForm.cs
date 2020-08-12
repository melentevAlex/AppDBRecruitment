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
    public partial class MakeVacancyForm : Form
    {
        public MakeVacancyForm()
        {
            InitializeComponent();
        }

        private void ButtonMakeVacancy_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                Vacansia vacansia = new Vacansia() { Name = NameTextBox.Text, Discription = DistextBox.Text, Salary = int.Parse(SalarytextBox.Text) };
                db.Vacansias.Add(vacansia);
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
