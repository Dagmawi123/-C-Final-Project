using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProject.Classes
{
    class Doctor  : Staff , Department 
    {
        public int doctorId { get; set; }
        public int depId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string depName { get ; set ; }

        private void save()
        {
            depId = 1;
            depName = "";
            
        }
        

       
    }
}
