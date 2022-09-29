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

namespace laba3
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        public List<Programmer> workers = new List<Programmer>();
        //private List<Panel> listWorkersPanel = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
            workers.Add(new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot"));
            workers.Add(new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot"));
            workers.Add(new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot"));
            workers.Add(new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot"));
            workers.Add(new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot"));
            workers.Add(new Programmer("Гилимович Артем", 22, 2, "Инженер-программист", "Juniot"));
            printWorkers();
            panelListShowWorkers.Visible = true;
        }
        public void printWorkers()
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

            /*Button button = new Button();
            button.Location = new Point(550, 0);
            button.Size = new Size(98, 24);
            button.Click += (object sender, EventArgs e) =>
            {

            };*/

            workerPanel.Controls.Add(nameLabel);
            workerPanel.Controls.Add(ageLabel);
            workerPanel.Controls.Add(workExperienceLabel);
            workerPanel.Controls.Add(jobTitleLabel);
            workerPanel.Controls.Add(knowledgeLevelLabel);
            //workerPanel.Controls.Add(button);
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
                    printWorkers();
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
    }
}
