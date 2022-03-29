using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        //As application is not in production yet and this change will not break so its ok for that modification
        public bool IsManager { get; set; } = false;

        public bool IsExecutive { get; set; }
    }
}
