using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class RedactForm : Form
    {
        Programmer proger;
        MainForm f;
        string job = "";
        string level = "";
        string name = "";
        int age = 0;
        int workExp = 0;
        public RedactForm(Programmer worker, MainForm form)
        {
            InitializeComponent();
            job = worker.JobTitle;
            level = worker.KnowledgeLevel;
            name = worker.Name;
            age = worker.Age;
            workExp = worker.WorkExperience;

            proger = worker;
            f = form;

            jobComboBox.SelectedIndex = jobComboBox.FindString(job);
            levelComboBox.SelectedIndex = levelComboBox.FindString(level);
            nameTextBox.Text = name;
            ageComboBox.SelectedIndex = ageComboBox.FindString(age.ToString());
            workExpComboBox.SelectedIndex = workExpComboBox.FindString(workExp.ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string job = jobComboBox.SelectedItem.ToString();
                string level = levelComboBox.SelectedItem.ToString();
                string name = nameTextBox.Text;
                string age = ageComboBox.SelectedItem.ToString();
                string workExp = workExpComboBox.SelectedItem.ToString();
                if (job == "Должность сотрудника" || level == "Уровень знаний" || name == "" || age == "Возраст" || workExp == "Стаж работы")
                {
                    MessageBox.Show(
                            "Введите все данные",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                else
                {
                    proger.JobTitle = job;
                    proger.KnowledgeLevel = level;
                    proger.Name = name;
                    proger.Age = Int32.Parse(age);
                    proger.WorkExperience = Int32.Parse(workExp);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(
                            "Введите все данные" + er.Message,
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void RedactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.printWorkers();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
