using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask
{
    public class Manager : Worker
    {
        
        public Manager(int id, int groupId, int chiefId, string name, string login, string password, DateTime
            employmentDate, bool superUser)
        {
            this.id = id;
            this.groupId = groupId;
            this.chiefId = chiefId;
            this.name = name;
            this.login = login;
            this.password = password;
            this.employmentDate = employmentDate;
            this.subordinates = GetSubordinates();
            this.salary = GetSalary(DateTime.Now);
            this.superUser = superUser;
        }

        public Manager(int id, DateTime employmentDate)
        {
            this.id = id;
            this.employmentDate = employmentDate;
            this.subordinates = GetSubordinates();
            this.salary = GetSalary(DateTime.Now);
        }

        public override float GetSalary(DateTime customDate)
        {
            float salary = 0.00f, baseSalary;
            baseSalary = SQLiteDataAccess.GetBaseSalary(2);
            TimeSpan span = customDate - this.employmentDate;
            if (span.Ticks > 0)
            {
                int workingYears = (new DateTime(1, 1, 1) + span).Year - 1;
                salary = baseSalary;
                if (workingYears > 8)
                {
                    salary = baseSalary + baseSalary * 0.4f;
                } else
                {
                    salary = baseSalary + baseSalary * 0.05f * workingYears;
                }
                if (!(subordinates == null))
                {
                    salaryList = new List<float>();
                    for (int index = 0; index < subordinates.Length / 2; index++)
                    {
                        int subordinateId = int.Parse(subordinates[index, 0]);
                        SQLiteDataAccess.MakeSecondWorker(subordinateId);
                        salaryList.Add(SQLiteDataAccess.secondPerson.Salary);
                    }
                    salary += (salaryList.Sum() * 0.005f);
                }
                salary = (float)Math.Round(salary, 2);
            }

            return salary;
        }

        public string[,] GetSubordinates()
        {
            return SQLiteDataAccess.GetSubordinates(this.id);
        }
    }
}
