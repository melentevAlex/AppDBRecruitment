using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBRecruitment.Model
{
    public class Vacansia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Discription { get; set; }
        public int UserId { get; set; }
        public bool IsNew { get; set; } = true;
        //public User User { get; set; }
    }
}
