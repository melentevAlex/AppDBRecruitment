 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBRecruitment.Model
{
    public class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Salary { get; set; }
        public int UserId { get; set; }
        public bool IsNew { get; set; } = true;
        public User User { get; set; }
    }
}
