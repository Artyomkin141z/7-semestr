namespace laba3
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.panelInform = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.redactButton = new System.Windows.Forms.Button();
            this.panelRedactInform = new System.Windows.Forms.Panel();
            this.saveInfButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.redactPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.workExpComboBox = new System.Windows.Forms.ComboBox();
            this.aboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panelInform.SuspendLayout();
            this.panelRedactInform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redactPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePictureBox.Image = global::laba3.Properties.Resources.no_photo;
            this.imagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(175, 167);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 0;
            this.imagePictureBox.TabStop = false;
            // 
            // panelInform
            // 
            this.panelInform.Controls.Add(this.redactButton);
            this.panelInform.Controls.Add(this.aboutLabel);
            this.panelInform.Controls.Add(this.experienceLabel);
            this.panelInform.Controls.Add(this.ageLabel);
            this.panelInform.Controls.Add(this.label3);
            this.panelInform.Controls.Add(this.label2);
            this.panelInform.Controls.Add(this.jobLabel);
            this.panelInform.Controls.Add(this.nameLabel);
            this.panelInform.Controls.Add(this.imagePictureBox);
            this.panelInform.Location = new System.Drawing.Point(12, 12);
            this.panelInform.Name = "panelInform";
            this.panelInform.Size = new System.Drawing.Size(776, 459);
            this.panelInform.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(194, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(237, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Гилимович Артем";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobLabel.Location = new System.Drawing.Point(195, 47);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(203, 22);
            this.jobLabel.TabIndex = 2;
            this.jobLabel.Text = "Инженер-программист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(195, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(195, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Трудовой стаж:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(277, 98);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(27, 20);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "20";
            // 
            // experienceLabel
            // 
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.experienceLabel.Location = new System.Drawing.Point(327, 118);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(18, 20);
            this.experienceLabel.TabIndex = 6;
            this.experienceLabel.Text = "2";
            // 
            // aboutLabel
            // 
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutLabel.Location = new System.Drawing.Point(3, 173);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(770, 257);
            this.aboutLabel.TabIndex = 7;
            this.aboutLabel.Text = "Подробная информация";
            // 
            // redactButton
            // 
            this.redactButton.Location = new System.Drawing.Point(661, 433);
            this.redactButton.Name = "redactButton";
            this.redactButton.Size = new System.Drawing.Size(112, 23);
            this.redactButton.TabIndex = 8;
            this.redactButton.Text = "Редактировать";
            this.redactButton.UseVisualStyleBackColor = true;
            this.redactButton.Click += new System.EventHandler(this.redactButton_Click);
            // 
            // panelRedactInform
            // 
            this.panelRedactInform.Controls.Add(this.cancelButton);
            this.panelRedactInform.Controls.Add(this.aboutRichTextBox);
            this.panelRedactInform.Controls.Add(this.workExpComboBox);
            this.panelRedactInform.Controls.Add(this.ageComboBox);
            this.panelRedactInform.Controls.Add(this.label9);
            this.panelRedactInform.Controls.Add(this.label8);
            this.panelRedactInform.Controls.Add(this.jobTextBox);
            this.panelRedactInform.Controls.Add(this.nameTextBox);
            this.panelRedactInform.Controls.Add(this.saveInfButton);
            this.panelRedactInform.Controls.Add(this.label6);
            this.panelRedactInform.Controls.Add(this.label7);
            this.panelRedactInform.Controls.Add(this.redactPictureBox);
            this.panelRedactInform.Location = new System.Drawing.Point(9, 9);
            this.panelRedactInform.Name = "panelRedactInform";
            this.panelRedactInform.Size = new System.Drawing.Size(776, 459);
            this.panelRedactInform.TabIndex = 9;
            this.panelRedactInform.Visible = false;
            // 
            // saveInfButton
            // 
            this.saveInfButton.Location = new System.Drawing.Point(661, 433);
            this.saveInfButton.Name = "saveInfButton";
            this.saveInfButton.Size = new System.Drawing.Size(112, 23);
            this.saveInfButton.TabIndex = 8;
            this.saveInfButton.Text = "Сохранить";
            this.saveInfButton.UseVisualStyleBackColor = true;
            this.saveInfButton.Click += new System.EventHandler(this.saveInfButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(410, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Трудовой стаж:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(201, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Возраст:";
            // 
            // redactPictureBox
            // 
            this.redactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redactPictureBox.Image = global::laba3.Properties.Resources.no_photo;
            this.redactPictureBox.Location = new System.Drawing.Point(3, 3);
            this.redactPictureBox.Name = "redactPictureBox";
            this.redactPictureBox.Size = new System.Drawing.Size(175, 167);
            this.redactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redactPictureBox.TabIndex = 0;
            this.redactPictureBox.TabStop = false;
            this.redactPictureBox.Click += new System.EventHandler(this.redactPictureBox_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(199, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(443, 35);
            this.nameTextBox.TabIndex = 9;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobTextBox.Location = new System.Drawing.Point(199, 84);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(443, 31);
            this.jobTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(199, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(199, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Должность";
            // 
            // ageComboBox
            // 
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.ageComboBox.Location = new System.Drawing.Point(281, 140);
            this.ageComboBox.MaxDropDownItems = 1;
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(104, 21);
            this.ageComboBox.TabIndex = 15;
            this.ageComboBox.Text = "Возраст";
            // 
            // workExpComboBox
            // 
            this.workExpComboBox.FormattingEnabled = true;
            this.workExpComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.workExpComboBox.Location = new System.Drawing.Point(542, 140);
            this.workExpComboBox.MaxDropDownItems = 1;
            this.workExpComboBox.Name = "workExpComboBox";
            this.workExpComboBox.Size = new System.Drawing.Size(100, 21);
            this.workExpComboBox.TabIndex = 16;
            this.workExpComboBox.Text = "Стаж работы";
            // 
            // aboutRichTextBox
            // 
            this.aboutRichTextBox.Location = new System.Drawing.Point(3, 176);
            this.aboutRichTextBox.Name = "aboutRichTextBox";
            this.aboutRichTextBox.Size = new System.Drawing.Size(770, 251);
            this.aboutRichTextBox.TabIndex = 17;
            this.aboutRichTextBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(543, 433);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.panelRedactInform);
            this.Controls.Add(this.panelInform);
            this.Name = "InformationForm";
            this.Text = "Подробная информация";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panelInform.ResumeLayout(false);
            this.panelInform.PerformLayout();
            this.panelRedactInform.ResumeLayout(false);
            this.panelRedactInform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redactPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Panel panelInform;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button redactButton;
        private System.Windows.Forms.Panel panelRedactInform;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveInfButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox redactPictureBox;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.ComboBox workExpComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RichTextBox aboutRichTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}