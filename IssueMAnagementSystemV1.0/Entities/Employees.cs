using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueMAnagementSystemV1._0.Entity
{
    class Employees
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }    
        
        public string Estatus { get; set; }

        public string Edept { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string ERole { get; set; }

        public int Points { get; set; }
    }
}
