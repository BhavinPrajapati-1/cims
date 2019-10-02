using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LogIn { get; set; }
        public string Password { get; set; }
        public string AccessType { get; set; }

    }
}
