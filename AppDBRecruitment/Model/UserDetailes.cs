using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBRecruitment.Model
{
    public class UserDetailes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Fill_NameOfOrg { get; set; }
        public int Role { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
