using laba3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace laba3
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        public List<Programmer> workers = new List<Programmer>();
        //private List<Panel> listWorkersPanel = new List<Panel>();

        private bool sortNameDirection = false;
        private bool sortAgeDirection = false;
        private bool sortExperienceDirection = false;
        private string sortLevelDirection = "Все";
        public MainForm()
        {
            InitializeComponent();

            workers.Add(new Programmer("Гилимович Артем", 22, 1, "Инженер-программист", "Junior"));
            workers.Add(new Programmer("Атрахименок Илья", 19, 2, "Инженер-программист", "Middle"));
            workers.Add(new Programmer("Лях Роман", 43, 2, "Инженер-программист", "Senior"));
            workers.Add(new Programmer("Пралич Артем", 62, 4, "Инженер-программист", "Junior"));
            workers.Add(new Programmer("Ковалев Евгений", 40, 9, "Инженер-программист", "Junior"));
            workers.Add(new Programmer("Павлий Павел", 15, 7, "Инженер-программист", "Middle"));
            
            printWorkers(workers);
            panelListShowWorkers.Visible = true;

            saveFileDialog1.DefaultExt = ".json";
            saveFileDialog1.Filter = "Text files(*.json)|*.*";
        }
        public void printWorkers(List<Programmer> workers)
        {
            panelListRedactWorkers.Controls.Clear();
            panelListShowWorkers.Controls.Clear();
            panelListDeleteWorkers.Controls.Clear();
            for (int i = 0; i < workers.Count; i++)
            {
                createWorkerPanel(i, workers[i].Name,
                    workers[i].Age,
                    workers[i].WorkExperience,
                    workers[i].JobTitle,
                    workers[i].KnowledgeLevel,
                    i * 24);
                createWorkerDeletePanel(i, workers[i].Name,
                    workers[i].Age,
                    workers[i].WorkExperience,
                    workers[i].JobTitle,
                    workers[i].KnowledgeLevel,
                    i * 24);
                createWorkerRedactPanel(i, workers[i].Name,
                    workers[i].Age,
                    workers[i].WorkExperience,
                    workers[i].JobTitle,
                    workers[i].KnowledgeLevel,
                    i * 24);
            }
        }
        private void createWorkerPanel(int id, string name, int age, int workExperience, string jobTitle, string knowledgeLevel, int y)
        {
            Panel workerPanel = new Panel();
            workerPanel.Size = new Size(649, 24);
            workerPanel.Location = new Point(0, y);
            workerPanel.Tag = id;

            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(0, 6);

            Label ageLabel = new Label();
            ageLabel.Text = age.ToString();
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(126, 6);

            Label workExperienceLabel = new Label();
            workExperienceLabel.Text = workExperience.ToString();
            workExperienceLabel.AutoSize = true;
            workExperienceLabel.Location = new Point(187, 6);

            Label jobTitleLabel = new Label();
            jobTitleLabel.Text = jobTitle;
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new Point(238, 6);

            Label knowledgeLevelLabel = new Label();
            knowledgeLevelLabel.Text = knowledgeLevel;
            knowledgeLevelLabel.AutoSize = true;
            knowledgeLevelLabel.Location = new Point(430, 6);

            Button button = new Button();
            button.Text = "Информация";
            button.Location = new Point(550, 0);
            button.Size = new Size(98, 24);
            button.Click += (object sender, EventArgs e) =>
            {
                InformationForm informationForm = new InformationForm(workers[id]);
                informationForm.Show();
            };

            workerPanel.Controls.Add(nameLabel);
            workerPanel.Controls.Add(ageLabel);
            workerPanel.Controls.Add(workExperienceLabel);
            workerPanel.Controls.Add(jobTitleLabel);
            workerPanel.Controls.Add(knowledgeLevelLabel);
            workerPanel.Controls.Add(button);
            panelListShowWorkers.Controls.Add(workerPanel);
        }

        private void createWorkerRedactPanel(int id, string name, int age, int workExperience, string jobTitle, string knowledgeLevel, int x)
        {
            Panel workerPanel = new Panel();
            workerPanel.Size = new Size(649, 24);
            workerPanel.Location = new Point(0, x);
            workerPanel.Tag = id;

            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(0, 6);

            Label ageLabel = new Label();
            ageLabel.Text = age.ToString();
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(126, 6);

            Label workExperienceLabel = new Label();
            workExperienceLabel.Text = workExperience.ToString();
            workExperienceLabel.AutoSize = true;
            workExperienceLabel.Location = new Point(187, 6);

            Label jobTitleLabel = new Label();
            jobTitleLabel.Text = jobTitle;
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new Point(238, 6);

            Label knowledgeLevelLabel = new Label();
            knowledgeLevelLabel.Text = knowledgeLevel;
            knowledgeLevelLabel.AutoSize = true;
            knowledgeLevelLabel.Location = new Point(430, 6);

            Button button = new Button();
            button.Text = "Редактировать";
            button.Location = new Point(538, 0);
            button.Size = new Size(110, 24);
            button.Click += (object sender, EventArgs e) =>
            {
                RedactForm rf = new RedactForm(workers[id], this);
                rf.Show();
            };

            workerPanel.Controls.Add(nameLabel);
            workerPanel.Controls.Add(ageLabel);
            workerPanel.Controls.Add(workExperienceLabel);
            workerPanel.Controls.Add(jobTitleLabel);
            workerPanel.Controls.Add(knowledgeLevelLabel);
            workerPanel.Controls.Add(button);
            panelListRedactWorkers.Controls.Add(workerPanel);
        }

        private void createWorkerDeletePanel(int id, string name, int age, int workExperience, string jobTitle, string knowledgeLevel, int x)
        {
            Panel workerPanel = new Panel();
            workerPanel.Size = new Size(649, 24);
            workerPanel.Location = new Point(0, x);
            workerPanel.Tag = id;

            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(0, 6);

            Label ageLabel = new Label();
            ageLabel.Text = age.ToString();
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(126, 6);

            Label workExperienceLabel = new Label();
            workExperienceLabel.Text = workExperience.ToString();
            workExperienceLabel.AutoSize = true;
            workExperienceLabel.Location = new Point(187, 6);

            Label jobTitleLabel = new Label();
            jobTitleLabel.Text = jobTitle;
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new Point(238, 6);

            Label knowledgeLevelLabel = new Label();
            knowledgeLevelLabel.Text = knowledgeLevel;
            knowledgeLevelLabel.AutoSize = true;
            knowledgeLevelLabel.Location = new Point(430, 6);

            Button button = new Button();
            button.Text = "Удалить";
            button.Location = new Point(550, 0);
            button.Size = new Size(98, 24);
            button.Click += (object sender, EventArgs e) =>
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    workers.RemoveAt(id);
                    printWorkers(workers);
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            };

            workerPanel.Controls.Add(nameLabel);
            workerPanel.Controls.Add(ageLabel);
            workerPanel.Controls.Add(workExperienceLabel);
            workerPanel.Controls.Add(jobTitleLabel);
            workerPanel.Controls.Add(knowledgeLevelLabel);
            workerPanel.Controls.Add(button);
            panelListDeleteWorkers.Controls.Add(workerPanel);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
        }

        private void просмторетьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelListShowWorkers.Visible = true;
            panelListRedactWorkers.Visible = false;
            panelListDeleteWorkers.Visible = false;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelListShowWorkers.Visible = false;
            panelListRedactWorkers.Visible = false;
            panelListDeleteWorkers.Visible = true;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelListShowWorkers.Visible = false;
            panelListRedactWorkers.Visible = true;
            panelListDeleteWorkers.Visible = false;
        }

        public void sortedName()
        {
            List<Programmer> sortedList = new List<Programmer>();
            if (!sortNameDirection)
            {
                var orderedWorker = from i in workers
                                    orderby i.Name descending
                                    select i;

                foreach (Programmer i in orderedWorker)
                {
                    sortedList.Add(i);
                }
                sortNameDirection = !sortNameDirection;
            }
            else
            {
                var orderedWorker = from i in workers
                                    orderby i.Name ascending
                                    select i;

                foreach (Programmer i in orderedWorker)
                {
                    sortedList.Add(i);
                }
                sortNameDirection = !sortNameDirection;
            }
            printWorkers(sortedList);
        }
        public void sortedAge()
        {
            List<Programmer> sortedList = new List<Programmer>();
            if (!sortAgeDirection)
            {
                var orderedWorker = from i in workers
                                    orderby i.Age descending
                                    select i;

                foreach (Programmer i in orderedWorker)
                {
                    sortedList.Add(i);
                }
                sortAgeDirection = !sortAgeDirection;
            }
            else
            {
                var orderedWorker = from i in workers
                                    orderby i.Age ascending
                                    select i;

                foreach (Programmer i in orderedWorker)
                {
                    sortedList.Add(i);
                }
                sortAgeDirection = !sortAgeDirection;
            }
            printWorkers(sortedList);
        }
        public void sortedExperience()
        {
            List<Programmer> sortedList = new List<Programmer>();
            if (!sortExperienceDirection)
            {
                var orderedWorker = from i in workers
                                    orderby i.WorkExperience descending
                                    select i;

                foreach (Programmer i in orderedWorker)
                {
                    sortedList.Add(i);
                }
                sortExperienceDirection = !sortExperienceDirection;
            }
            else
            {
                var orderedWorker = from i in workers
                                    orderby i.WorkExperience ascending
                                    select i;

                foreach (Programmer i in orderedWorker)
                {
                    sortedList.Add(i);
                }
                sortExperienceDirection = !sortExperienceDirection;
            }
            printWorkers(sortedList);
        }
        public void sortedLevel()
        {
            List<Programmer> sortedList = new List<Programmer>();


            foreach (Programmer i in workers)
            {
                if(sortLevelDirection == "Все")
                {
                    break;
                }
                else if(i.KnowledgeLevel == sortLevelDirection)
                {
                    sortedList.Add(i);
                }  
            }
            if (sortLevelDirection == "Все")
            {
                printWorkers(workers);
            }
            else printWorkers(sortedList);
        }
        private void sortNamebutton_Click(object sender, EventArgs e)
        {
            sortedName();
        }

        private void sortAgebutton_Click(object sender, EventArgs e)
        {
            sortedAge();
        }

        private void sortExperiencebutton_Click(object sender, EventArgs e)
        {
            sortedExperience();
        }

        private void sortLevelcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortLevelDirection = sortLevelcomboBox.SelectedItem.ToString();
            sortedLevel();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(workers);

            if (saveFileDialog1.ShowDialog() 
                == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, json);
        }

        private void импортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string json = System.IO.File.ReadAllText(filename);
            workers = JsonSerializer.Deserialize<List<Programmer>>(json);
            printWorkers(workers);
        }
    }
}
