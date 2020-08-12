using AppDBRecruitment.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : Form
    {
        ResumeForm resumeForm;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                //User user = new User() { Login = "Mark", Password = CalculateMD5Hash("Pass1") };
                //user.UserDetailes = new UserDetailes() { Role = 1, Fill_NameOfOrg = "Mark", EMail = "Mark@gmali.comn", PhoneNumber = "+7846516846" };

                //User user2 = new User() { Login = "Jack", Password = CalculateMD5Hash("Pass2") };
                //user2.UserDetailes = new UserDetailes() { Role = 2, Fill_NameOfOrg = "JackCompany", EMail = "Jack@gmali.comn", PhoneNumber = "+7846516816" };

                //User user3 = new User() { Login = "John", Password = CalculateMD5Hash("Pass3") };
                //user3.UserDetailes = new UserDetailes() { Role = 3, Fill_NameOfOrg = "JohnCompany", EMail = "John@gmali.comn", PhoneNumber = "+7846516246" };

                //User user4 = new User() { Login = "Mikel", Password = CalculateMD5Hash("Pass4") };
                //user4.UserDetailes = new UserDetailes() { Role = 4, Fill_NameOfOrg = "Mikel", EMail = "Mikel@gmali.comn", PhoneNumber = "+7846516746" };

                //User user = new User() { Login = "Mikel", Password = CalculateMD5Hash("Pass4") };
                //user.UserDetailes = new UserDetailes() { Role = 4, Fill_NameOfOrg = "Mikel", EMail = "Mikel@gmali.comn", PhoneNumber = "+7846516746" };

                //db.Users.AddRange(user2, user3);

                //db.SaveChanges();
            }

        }


        internal static string CalculateMD5Hash(string input)
        {
            //Определение необходимых переменных
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            //Рассчёт хэша для входящей строки
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            //Возврат хэшированной строки
            return sb.ToString();
        }
        private void OpenFormMethod(string text, int role)
        {
            AfterLogForm afterLogForm = new AfterLogForm(text, role);
            this.Hide();
            if (afterLogForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            resumeForm = new ResumeForm();
            resumeForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private User CurrentUser;


        public void GetRoleValue()
        {
            
            using (MyContext db = new MyContext())
            {
                var currentUser = db.Users.Where(l => l.Login == textBox1.Text).Include(d => d.UserDetailes).FirstOrDefault();

                if (currentUser == null)
                {
                    MessageBox.Show("Wrong login");
                }
                else
                {
                    if (currentUser.Password == CalculateMD5Hash(textBox2.Text))
                    {
                        string text = "";
                        AppHelper.currentUser = currentUser;
                        switch (currentUser.UserDetailes.Role)
                        {
                            case 4:
                                text = "You're logged in like employee";
                                break;
                            case 3:
                                text = "You're logged in like employer";
                                break;
                            case 2:
                                text = "You're logged in like moderater";
                                break;
                            case 1:
                                text = "You're logged in like administrater";
                                break;
                        }
                        OpenFormMethod(text, currentUser.UserDetailes.Role);
                    }
                    else
                    {
                        MessageBox.Show("wrong pass");
                    }
                }
            }
            
        }

        private void SignInbutton_Click(object sender, EventArgs e)
        {
            GetRoleValue();
            
        }

        private void buttonCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}