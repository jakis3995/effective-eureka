using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask
{
    public abstract class Worker
    {
        protected int id, groupId, chiefId;
        protected string name, login, password;
        protected DateTime employmentDate;
        protected float salary;
        protected bool superUser;
        protected string[,] subordinates;
        protected List<float> salaryList = null;
        protected int[] subordinatesOfEveryLevel = null;

        public abstract float GetSalary(DateTime employmentDate);
              
        public string Name
        {
            get
            {
                return name;
            }
        }

        public DateTime EmploymentDate
        {
            get
            {
                return employmentDate;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }
        }

        public bool SuperUser
        {
            get
            {
                return superUser;
            }
        }

        public string[,] Subordinates
        {
            get
            {
                return this.subordinates;
            }
        }

        public List<float> SalaryList
        {
            get
            {
                return this.salaryList;
            }

            set
            {
                salaryList = value;
            }
        }
    }
}
