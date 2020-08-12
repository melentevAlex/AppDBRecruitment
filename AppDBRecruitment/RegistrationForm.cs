using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDBRecruitment.Model;

namespace AppDBRecruitment
{
    public partial class RegistrationForm : Form
    {
        Point lastPoint;
        public RegistrationForm()
        {
            InitializeComponent();

        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            PasstextBox.ForeColor = Color.Red;
            LogginTextBox.Select();
            btnEmployee.BackColor = Color.FromArgb(218, 232, 237);

        }

        private (string, string, string, string) Register()
        {
            string loggin = LogginTextBox.Text;
            string password = PasstextBox.Text;
            string email = EmailTextBox.Text;
            string passwordAgain = PassAgtextBox.Text;
            string phoneNumber = PhonetextBox.Text;
            return (loggin, password, email, phoneNumber);
        }

        private int DefinitionRole()
        {
            if (btnEmployer)
            {
                return 3;
            }
            else
            {
                return 4;
            }

        }

        private void Registration(int role, string nameOfOrg)
        {
            {

                if (IsValidEmail())
                {
                    if (ValidationPassword() > 1)
                    {
                        using (MyContext db = new MyContext())
                        {
                            User user = new User() { Login = Register().Item1, Password = Form1.CalculateMD5Hash(Register().Item2) };
                            user.UserDetailes = new UserDetailes() { Role = role, Fill_NameOfOrg = nameOfOrg, EMail = Register().Item3, PhoneNumber = Register().Item4 };

                            if (db.Users.Where(i => i.Login == user.Login).FirstOrDefault() != null)
                            {
                                MessageBox.Show("The login is contain");
                            }
                            else
                            {
                                db.Users.Add(user);
                                db.SaveChanges();
                                MessageBox.Show("Changes are saved");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Week password");
                    }
                }
            }
        }
        private void SignUPbutton_Click(object sender, EventArgs e)
        {
            if (DefinitionRole() == 3) // employer
            {
                Registration(DefinitionRole(), textBoxNameOrg.Text);
            }
            if (DefinitionRole() == 4)
            {
                Registration(DefinitionRole(), (textBoxNameOrg.Text + " " + textBoxSurName.Text));
            }
            

            Form1 form1 = new Form1();
            this.Hide();
            if (form1.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        private bool IsValidEmail()
        {
            try
            {
                MailAddress m = new MailAddress(Register().Item3);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input correct e-mail");
                return false;
            }
        }



        private int ValidationPassword()
        {
            int sum = 0;
            string pas = Register().Item2;
            if (Regex.IsMatch(pas, @"[A-Z]"))
            { sum++; }
            if (Regex.IsMatch(pas, @"[0-9]"))
            { sum++; }
            if (Regex.IsMatch(pas, @"[?:!#$%&'*+/=?^_`{|}~-]"))
            { sum++; }
            return sum;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private int chechPass = 2;
        private void chkBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chechPass % 2 == 0)
            {
                PasstextBox.UseSystemPasswordChar = false;
                PassAgtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasstextBox.UseSystemPasswordChar = true;
                PassAgtextBox.UseSystemPasswordChar = true;
            }
            chechPass++;

        }

        private void PasstextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (PasstextBox.Text == String.Empty)
            {
                lblWeakPass.Visible = false;
            }
            lblWeakPass.Visible = true;
            if (ValidationPassword() < 2 || PasstextBox.Text.Length < 10)
            {
                PasstextBox.ForeColor = Color.Red;
                lblWeakPass.ForeColor = Color.Red;
                lblWeakPass.Visible = true;
                lblWeakPass.Text = "Weak Password";
            }
            else
            {
                PasstextBox.ForeColor = Color.Black;
                if (ValidationPassword() == 2)
                {
                    SignUPbutton.Enabled = true;
                    lblWeakPass.Visible = true;
                    lblWeakPass.ForeColor = Color.Black;
                    lblWeakPass.Text = "Middle Password";
                }

                if (ValidationPassword() > 2)
                {
                    SignUPbutton.Enabled = true;
                    lblWeakPass.Visible = true;
                    lblWeakPass.Text = "Good Password";
                }
            }
        }

        private void PassAgtextBox_TextChanged_1(object sender, EventArgs e)
        {
            lblPasswordMismatch.Visible = true;
            PassAgtextBox.ForeColor = Color.Red;
            if (PassAgtextBox.Text == PasstextBox.Text)
            {
                lblPasswordMismatch.Visible = false;
                PassAgtextBox.ForeColor = Color.Black;
            }
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            textBoxSurName.Visible = true;
            labelSurName.Visible = true;
            labelNameOrg.Text = "Name";
            btnEmployer = false;
            buttonEmployer.BackColor = Color.FromArgb(237, 233, 218);
            btnEmployee.BackColor = Color.FromArgb(218, 232, 237);
            pictureBoxlikeEmployer.Visible = false;
            pictureBoxLikeEmployee.Visible = true;
        }



        bool btnEmployer = false;

        private void buttonEmployer_Click(object sender, EventArgs e)
        {
            textBoxSurName.Visible = false;
            labelSurName.Visible = false;
            btnEmployer = true;
            pictureBox1.Visible = false;
            labelNameOrg.Text = "Name of Organization";
            textBoxNameOrg.Visible = true;
            btnEmployee.BackColor = Color.FromArgb(237, 233, 218);
            buttonEmployer.BackColor = Color.FromArgb(218, 232, 237);
            pictureBoxLikeEmployee.Visible = false;
            pictureBoxlikeEmployer.Visible = true;
        }

        private void buttonCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
