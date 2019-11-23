using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask
{
    public class Employee : Worker
    {
        public Employee(int id, int groupId, int chiefId, string name, string login, string password, DateTime 
            employmentDate, bool superUser)
        {
            this.id = id;
            this.groupId = groupId;
            this.chiefId = chiefId;
            this.name = name;
            this.login = login;
            this.password = password;
            this.employmentDate = employmentDate;
            this.salary = GetSalary(DateTime.Now);
            this.superUser = superUser;
        }

        public Employee(int id, DateTime employmentDate)
        {
            this.id = id;
            this.employmentDate = employmentDate;
            this.salary = GetSalary(DateTime.Now);
        }

        public override float GetSalary(DateTime customDate)
        {
            float salary = 0.00f, baseSalary;
            baseSalary = SQLiteDataAccess.GetBaseSalary(1);
            TimeSpan span = customDate - this.employmentDate;
            if (span.Ticks > 0)
            {
                int workingYears = (new DateTime(1, 1, 1) + span).Year - 1;
                salary = baseSalary;
                if (workingYears > 10)
                {
                    salary = baseSalary + baseSalary * 0.3f;
                } else
                {
                    salary = baseSalary + baseSalary * 0.03f * workingYears;
                }
                salary = (float)Math.Round(salary, 2);
            }

            return salary;
        }
    }
}
