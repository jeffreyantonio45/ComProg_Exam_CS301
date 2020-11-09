using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
   
    public class Employee
    {
        //Class Vairables
        private int empID;
        private string FN, LN, Pos;

        //Default constructor
        public Employee()
        {
            this.empID = 0;
            this.FN = "";
            this.LN = "";
            this.Pos = "";
        }

        //Employee constructor with parameters
        public Employee(int id, string firstname, string lastname, string position)
        {
            this.empID = id;
            this.FN = firstname;
            this.LN = lastname;
            this.Pos = position;
        }

        //get and set Employee ID
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

        //get and set employee FirstName
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

        //get and set employee LastName
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

        //get and set employee Position
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
