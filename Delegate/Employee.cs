using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Delegate
{
    internal class Employee
    {
        int ID;
        string Name, Job, Location, Department, Gender;
        double Salary;
     

        public Employee(int iD, string name, string job, double salary, string location, string department, string gender)
        {
            this.ID=iD;
            this.Name=name;
            this.Job=job;
            this.Salary=salary;
            this.Location=location;
            this.Department=department;
            this.Gender=gender;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return Department;
                else if (index == 6)
                    return Gender;
                else
                    return null;

            }
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = Convert.ToString(value);
                else if (index == 2)
                    Job = value.ToString();
                else if (index ==3)
                    Salary = Convert.ToDouble(value);
                else if (index ==4)
                    Location =  value.ToString();
                else if (index == 5)
                    Department = value.ToString();
                else if (index == 6) 
                    Gender = value.ToString();

            }
        }
    }
}
