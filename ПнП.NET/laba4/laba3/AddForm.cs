using System;
using System.Windows.Forms;

namespace laba3
{
    public partial class AddForm : System.Windows.Forms.Form
    {
        MainForm form;
        public AddForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void addButton_Click(object sender, EventArgs e)
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
                    form.workers.Add(new Programmer(name, Int32.Parse(age), Int32.Parse(workExp), job, level));
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(
                            "Введите все данные" + er.Message,
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.printWorkers(form.workers);
        }
    }
}
