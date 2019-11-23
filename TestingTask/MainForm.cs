using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingTask
{
    public partial class MainForm : Form
    {
        readonly Form authForm;
        public MainForm(AuthorizationForm form)
        {
            InitializeComponent();
            authForm = form;
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            authForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authForm.Close();
            Close();
        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label2.Text = SQLiteDataAccess.person.Salary + " руб.";

            float salarySum = 0.00f;
            int entriesCount = SQLiteDataAccess.GetEntriesCount();

            for (int index = 0; index < entriesCount; index++)
            {
                SQLiteDataAccess.MakeSecondWorker(index + 1);
                salarySum += SQLiteDataAccess.secondPerson.Salary;
            }
            label5.Text = salarySum + " руб.";
            if (SQLiteDataAccess.person is Manager || SQLiteDataAccess.person is Salesman)
            {
                string[,] subordinates = SQLiteDataAccess.person.Subordinates;
                for (int index = 0; index < subordinates.Length; index++)
                {
                    listBox1.Items.Add(subordinates[index, 1]);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button1.Visible = true;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salary = SQLiteDataAccess.person.GetSalary(dateTimePicker1.Value);
            List<float> salariesList = new List<float>();
            if (SQLiteDataAccess.person.Subordinates != null)
            {
                for (int index = 0; index < SQLiteDataAccess.person.Subordinates.Length / 2; index++)
                {
                    int id = int.Parse(SQLiteDataAccess.person.Subordinates[index, 0]);
                    SQLiteDataAccess.MakeSecondWorker(id);
                    salariesList.Add(SQLiteDataAccess.secondPerson.GetSalary(dateTimePicker1.Value));
                }
                SQLiteDataAccess.person.SalaryList = salariesList;
            }
            label2.Text = salary + " руб.";
            listBox1.SelectedIndex = -1;
            label4.Text = "";

            float salarySum = 0.00f;
            int entriesCount = SQLiteDataAccess.GetEntriesCount();

            for (int index = 0; index < entriesCount; index++)
            {
                SQLiteDataAccess.MakeSecondWorker(index + 1);
                salarySum += SQLiteDataAccess.secondPerson.GetSalary(dateTimePicker1.Value);
            }
            label5.Text = salarySum + " руб.";
            button1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                label3.Text = "Е(го / ё) зарплата на указанный момент составляет:";
                if ((SQLiteDataAccess.person is Manager || SQLiteDataAccess.person is Salesman) &&
                    !(SQLiteDataAccess.person.SalaryList == null))
                {
                    label4.Text = SQLiteDataAccess.person.SalaryList[listBox1.SelectedIndex].ToString() + " руб.";
                }
            } else
            {
                label3.Text = "Выберите подчинённого для просмотра е(го/ё) зарплаты";
            }
        }

        private void отчётыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}
