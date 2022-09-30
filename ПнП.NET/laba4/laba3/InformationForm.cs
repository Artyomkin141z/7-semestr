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
    public partial class InformationForm : Form
    {
        private Programmer programmer;
        public InformationForm(Programmer prog)
        {
            InitializeComponent();
            programmer = prog;

            nameLabel.Text = programmer.Name;
            nameTextBox.Text = programmer.Name;

            jobLabel.Text = programmer.JobTitle;
            jobTextBox.Text = programmer.JobTitle;

            ageLabel.Text = programmer.Age.ToString();
            ageComboBox.SelectedIndex = ageComboBox.FindString(programmer.Age.ToString());

            experienceLabel.Text = programmer.WorkExperience.ToString();
            workExpComboBox.SelectedIndex = workExpComboBox.FindString(programmer.WorkExperience.ToString());

            aboutLabel.Text = programmer.About;
            aboutRichTextBox.Text = programmer.About;

            if(programmer.Img != "")
            {
                imagePictureBox.Image = Image.FromFile(programmer.Img);
                redactPictureBox.Image = Image.FromFile(programmer.Img);
            }       
        }

        private void redactButton_Click(object sender, EventArgs e)
        {
            panelInform.Visible = false;
            panelRedactInform.Visible = true;
        }

        private void saveInfButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "" || jobTextBox.Text == "")
            {
                MessageBox.Show(
                            "Введите все данные",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                programmer.Name = nameTextBox.Text;
                programmer.Age = Int32.Parse(ageComboBox.SelectedIndex.ToString());
                programmer.WorkExperience = Int32.Parse(workExpComboBox.SelectedIndex.ToString());
                programmer.About = aboutRichTextBox.Text;
                programmer.JobTitle = jobTextBox.Text;

                panelInform.Visible = true;
                panelRedactInform.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            panelInform.Visible = true;
            panelRedactInform.Visible = false;
        }

        private void redactPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;

            programmer.Img = filename;
            imagePictureBox.Image = Image.FromFile(programmer.Img);
            redactPictureBox.Image = Image.FromFile(programmer.Img);
        }
    }
}
