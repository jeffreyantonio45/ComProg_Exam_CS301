using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication1
{
    public class Employee
    {
        private int empID;
        private string FN, LN, Pos;

        public Employee()
        {
            this.empID = 0;
            this.FN = "";
            this.LN = "";
            this.Pos = "";
        }

        public Employee(int id, string firstname, string lastname, string position)
        {
            this.empID = id;
            this.FN = firstname;
            this.LN = lastname;
            this.Pos = position;
        }

        public int EID
        {
            get
            {
                return this.empID;
            }
            set
            {
                this.empID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.FN;
            }
            set
            {
                this.FN = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.LN;
            }
            set
            {
                this.LN = value;
            }
        }
        public string POS
        {
            get
            {
                return this.Pos;
            }
            set
            {
                this.Pos = value;
            }
        }
    }
}
