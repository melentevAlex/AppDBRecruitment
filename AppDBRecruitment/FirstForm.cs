using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDBRecruitment
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(150, 150);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(180, 255, 0, 0), Color.FromArgb(255, 255, 255, 0));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 150, 150, 0, 150);
            g.DrawLine(new Pen(Color.Yellow, 1.7f), startPoint, endPoint);
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.Refresh();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            if (registrationForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonHaveAcc_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            if (form1.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

    }
}
