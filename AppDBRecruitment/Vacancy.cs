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
    public partial class Vacancy : Form
    {
        public Vacancy()
        {
            InitializeComponent();
        }

        private void Vacancy_Load(object sender, EventArgs e)
        {
            
            using (MyContext db = new MyContext())
            {
                var vacancy = (from vac in db.Vacansias
                               select new
                               {
                                   Name = vac.Name,
                                   Discription = vac.Discription,
                                   Salary = vac.Salary,
                                   //WhoMade = vac.
                               });
                dataGridViewVacancy.DataSource = vacancy.ToList();
                this.dataGridViewVacancy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
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

        private void Rowlbl_MouseMove(object sender, MouseEventArgs e)
        {
            Rowlbl.Text = (dataGridViewVacancy.CurrentCell.RowIndex + 1).ToString();
        }

        private void buttonCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
