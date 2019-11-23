using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask
{
    class Salesman : Worker
    {
        public Salesman(int id, int groupId, int chiefId, string name, string login, string password, DateTime
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
            this.subordinatesOfEveryLevel = GetSubordinatesOfEveryLevel();
            this.salary = GetSalary(DateTime.Now);
            this.superUser = superUser;
        }

        public Salesman(int id, DateTime employmentDate)
        {
            this.id = id;
            this.employmentDate = employmentDate;
            this.subordinates = GetSubordinates();
            this.subordinatesOfEveryLevel = GetSubordinatesOfEveryLevel();
            this.salary = GetSalary(DateTime.Now);
        }

        public override float GetSalary(DateTime customDate)
        {
            float salary = 0.00f, baseSalary;
            baseSalary = SQLiteDataAccess.GetBaseSalary(3);
            float totalAllowance;
            TimeSpan span = customDate - this.employmentDate;
            if (span.Ticks > 0)
            {
                int workingYears = (new DateTime(1, 1, 1) + span).Year - 1;
                salary = baseSalary;
                if (workingYears > 35)
                {
                    salary = baseSalary + baseSalary * 0.35f;
                } else
                {
                    salary = baseSalary + baseSalary * 0.35f * workingYears;
                }
                if (!(subordinatesOfEveryLevel == null))
                {
                    salaryList = new List<float>();
                    List<float> salaryListForCounting = new List<float>();
                    for (int index = 0; index < subordinatesOfEveryLevel.Length; index++)
                    {
                        int id = subordinatesOfEveryLevel[index];
                        SQLiteDataAccess.MakeSecondWorker(id);
                        for (int subordinatesIndex = 0; subordinatesIndex < subordinates.Length / 2; subordinatesIndex++)
                        {
                            if (int.Parse(subordinates[subordinatesIndex, 0]) == id)
                            {
                                salaryList.Add(SQLiteDataAccess.secondPerson.Salary);
                            }
                        }
                        salaryListForCounting.Add(SQLiteDataAccess.secondPerson.Salary);
                    }
                    salary += (salaryListForCounting.Sum() * 0.005f);
                }
                salary = (float)Math.Round(salary, 2);
            }

            return salary;
        }

        public string[,] GetSubordinates()
        {
            return SQLiteDataAccess.GetSubordinates(this.id);
        }

        public int[] GetSubordinatesOfEveryLevel()
        {
            SQLiteDataAccess.subordinatesOfEveryLevel = new List<int>();
            SQLiteDataAccess.GetSubordinatesOfEveryLevel(this.id);

            int[] subordinatesOfEveryLevel = SQLiteDataAccess.subordinatesOfEveryLevel.ToArray();

            return subordinatesOfEveryLevel;
        }
    }
}
