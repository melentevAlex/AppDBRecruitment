using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBRecruitment.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserDetailes UserDetailes { get; set; }
        public List<Resume> Resumes { get; set; }
        public User()
        {
            Resumes = new List<Resume>();
            //Vacancies = new List<Vacancy>();
        }
        //public List<Vacancy> Vacancies { get; set; }
    }
}
