using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace TestingTask
{
    public class SQLiteDataAccess
    {
        public static Worker person;
        public static Worker secondPerson;
        public static List<int> subordinatesOfEveryLevel;

        public static bool Authentification(string login, string password)
        {
            bool decision = false;
            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();

                SQLiteCommand auth = sQLiteConnection.CreateCommand();
                auth.CommandText = "SELECT * FROM Users WHERE login = @login AND password = @password";
                auth.Parameters.Add("@login", System.Data.DbType.String).Value = login;
                auth.Parameters.Add("@password", System.Data.DbType.String).Value = password;
                SQLiteDataReader SQL = auth.ExecuteReader();
                if (SQL.HasRows)
                {
                    decision = true;
                    SQL.Read();
                    int id = SQL.GetInt32(0);
                    string superUser = SQL.GetString(3);
                    bool isSuperUser = bool.Parse(superUser);
                    MakeWorker(id, login, password, isSuperUser);
                }

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return decision;
        }

        public static void MakeWorker(int id, string login, string password, bool superUser)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();

                SQLiteCommand workersDataGroupCommand = sQLiteConnection.CreateCommand();
                workersDataGroupCommand.CommandText = "SELECT * FROM Workers WHERE id = @id";
                workersDataGroupCommand.Parameters.Add("@id", System.Data.DbType.String).Value = id;
                SQLiteDataReader workersDataGroup = workersDataGroupCommand.ExecuteReader();
                workersDataGroup.Read();
                string name = workersDataGroup.GetString(1);
                DateTime employmentDate = DateTime.ParseExact(workersDataGroup.GetString(2), "yyyy-MM-dd", null);
                int groupName = workersDataGroup.GetInt32(3);

                SQLiteCommand subordinationDataGroupCommand = sQLiteConnection.CreateCommand();
                subordinationDataGroupCommand.CommandText = "SELECT chiefId FROM Subordination WHERE WorkerId = @id";
                subordinationDataGroupCommand.Parameters.Add("@id", System.Data.DbType.String).Value = id;
                SQLiteDataReader subordinationDataGroup = subordinationDataGroupCommand.ExecuteReader();
                int chiefId;
                if (subordinationDataGroup.Read())
                {
                    chiefId = subordinationDataGroup.GetInt32(0);
                } else
                {
                    chiefId = 0;
                }

                switch (groupName)
                {
                    case 1:
                        person = new Employee(id, groupName, chiefId, name, login, password, employmentDate, superUser);
                        break;
                    case 2:
                        person = new Manager(id, groupName, chiefId, name, login, password, employmentDate, superUser);
                        break;
                    case 3:
                        person = new Salesman(id, groupName, chiefId, name, login, password, employmentDate, superUser);
                        break;
                }  

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void MakeSecondWorker(int id)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();

                SQLiteCommand workersDataGroupCommand = sQLiteConnection.CreateCommand();
                workersDataGroupCommand.CommandText = "SELECT emplDate, groupName FROM Workers WHERE id = @id";
                workersDataGroupCommand.Parameters.Add("@id", System.Data.DbType.String).Value = id;
                SQLiteDataReader workersDataGroup = workersDataGroupCommand.ExecuteReader();
                workersDataGroup.Read();
                DateTime employmentDate = DateTime.ParseExact(workersDataGroup.GetString(0), "yyyy-MM-dd", null);
                int groupName = workersDataGroup.GetInt32(1);

                switch (groupName)
                {
                    case 1:
                        secondPerson = new Employee(id, employmentDate);
                        break;
                    case 2:
                        secondPerson = new Manager(id, employmentDate);
                        break;
                    case 3:
                        secondPerson = new Salesman(id, employmentDate);
                        break;
                }

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static float GetBaseSalary(int groupName)
        {
            float baseSalary = 0.00f;

            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();

                SQLiteCommand gettingBaseSalaryCommand = sQLiteConnection.CreateCommand();
                gettingBaseSalaryCommand.CommandText = "SELECT salary FROM Groups WHERE id = @groupId";
                gettingBaseSalaryCommand.Parameters.Add("@groupId", System.Data.DbType.String).Value = groupName;
                SQLiteDataReader gettingBaseSalary = gettingBaseSalaryCommand.ExecuteReader();
                gettingBaseSalary.Read();
                baseSalary = gettingBaseSalary.GetFloat(0);

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                return baseSalary;
        }

        public static string[,] GetSubordinates(int chiefId)
        {
            string[,] subordinates = null;

            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();

                SQLiteCommand gettingSubordinatesCommand = sQLiteConnection.CreateCommand();
                gettingSubordinatesCommand.CommandText = "SELECT id, name FROM Workers, Subordination " +
                    "WHERE Subordination.chiefId = @chiefId AND Subordination.workerId = Workers.id";
                gettingSubordinatesCommand.Parameters.Add("@chiefId", System.Data.DbType.String).Value = chiefId;
                SQLiteDataReader gettingSubordinates = null;
                gettingSubordinates = gettingSubordinatesCommand.ExecuteReader();

                List<string> subordinatesIds = new List<string>();
                List<string> subordinatesNames = new List<string>();
                while (gettingSubordinates.Read())
                {
                    subordinatesIds.Add(gettingSubordinates.GetInt32(0).ToString());
                    subordinatesNames.Add(gettingSubordinates.GetString(1));
                }
                if (subordinatesIds.Count > 0)
                {
                    subordinates = new string[subordinatesIds.Count, 2];
                    for (int index = 0; index < subordinatesIds.Count; index++)
                    {
                        subordinates[index, 0] = subordinatesIds[index];
                        subordinates[index, 1] = subordinatesNames[index];
                    }
                }

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return subordinates;
        }

        public static void GetSubordinatesOfEveryLevel(int chiefId)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();
                SQLiteCommand gettingSubordinatesCommand = sQLiteConnection.CreateCommand();
                gettingSubordinatesCommand.CommandText = "SELECT Workers.id FROM Workers, Subordination " +
                    "WHERE Subordination.chiefId = @chiefId AND Subordination.workerId = Workers.id";
                gettingSubordinatesCommand.Parameters.Add("@chiefId", System.Data.DbType.String).Value = chiefId;
                SQLiteDataReader gettingSubordinates = null;
                gettingSubordinates = gettingSubordinatesCommand.ExecuteReader();
                while (gettingSubordinates.Read())
                {
                    int id = gettingSubordinates.GetInt32(0);
                    subordinatesOfEveryLevel.Add(id);
                    GetSubordinatesOfEveryLevel(id);
                }

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int GetEntriesCount()
        {
            int entriesCount = 0;
            SQLiteConnection sQLiteConnection = new SQLiteConnection(LoadConnectionString());
            if (File.Exists("testbase.db"))
            {
                sQLiteConnection.Open();
                SQLiteCommand gettingEntriesCountCommand = sQLiteConnection.CreateCommand();
                gettingEntriesCountCommand.CommandText = "SELECT * FROM Workers";
                SQLiteDataReader gettingEntriesCount = null;
                gettingEntriesCount = gettingEntriesCountCommand.ExecuteReader();
                while (gettingEntriesCount.Read())
                {
                    entriesCount++;
                }

                sQLiteConnection.Close();
            }
            else
            {
                MessageBox.Show("Не найден файл базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return entriesCount;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
