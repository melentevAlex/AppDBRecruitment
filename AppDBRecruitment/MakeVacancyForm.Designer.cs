namespace AppDBRecruitment
{
    partial class MakeVacancyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeVacancyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonMakeVacancy = new System.Windows.Forms.Button();
            this.SalarytextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.DistextBox = new System.Windows.Forms.TextBox();
            this.Namedlabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.buttonCls = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonCls);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 29);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ButtonMakeVacancy
            // 
            this.ButtonMakeVacancy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMakeVacancy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMakeVacancy.FlatAppearance.BorderSize = 0;
            this.ButtonMakeVacancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMakeVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMakeVacancy.Location = new System.Drawing.Point(158, 435);
            this.ButtonMakeVacancy.Name = "ButtonMakeVacancy";
            this.ButtonMakeVacancy.Size = new System.Drawing.Size(182, 36);
            this.ButtonMakeVacancy.TabIndex = 27;
            this.ButtonMakeVacancy.Text = "Make a Vacancy";
            this.ButtonMakeVacancy.UseVisualStyleBackColor = true;
            this.ButtonMakeVacancy.Click += new System.EventHandler(this.ButtonMakeVacancy_Click);
            // 
            // SalarytextBox
            // 
            this.SalarytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalarytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SalarytextBox.Location = new System.Drawing.Point(237, 308);
            this.SalarytextBox.Name = "SalarytextBox";
            this.SalarytextBox.Size = new System.Drawing.Size(183, 26);
            this.SalarytextBox.TabIndex = 26;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SalaryLabel.Location = new System.Drawing.Point(71, 311);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(59, 20);
            this.SalaryLabel.TabIndex = 25;
            this.SalaryLabel.Text = "Salary";
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DiscriptionLabel.Location = new System.Drawing.Point(71, 149);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(94, 20);
            this.DiscriptionLabel.TabIndex = 24;
            this.DiscriptionLabel.Text = "Discription";
            // 
            // DistextBox
            // 
            this.DistextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DistextBox.Location = new System.Drawing.Point(237, 146);
            this.DistextBox.Multiline = true;
            this.DistextBox.Name = "DistextBox";
            this.DistextBox.Size = new System.Drawing.Size(183, 115);
            this.DistextBox.TabIndex = 23;
            // 
            // Namedlabel
            // 
            this.Namedlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Namedlabel.AutoSize = true;
            this.Namedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Namedlabel.Location = new System.Drawing.Point(71, 68);
            this.Namedlabel.Name = "Namedlabel";
            this.Namedlabel.Size = new System.Drawing.Size(55, 20);
            this.Namedlabel.TabIndex = 22;
            this.Namedlabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NameTextBox.Location = new System.Drawing.Point(237, 65);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(183, 26);
            this.NameTextBox.TabIndex = 21;
            // 
            // buttonCls
            // 
            this.buttonCls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCls.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCls.FlatAppearance.BorderSize = 0;
            this.buttonCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCls.Location = new System.Drawing.Point(455, 0);
            this.buttonCls.Name = "buttonCls";
            this.buttonCls.Size = new System.Drawing.Size(35, 29);
            this.buttonCls.TabIndex = 3;
            this.buttonCls.Text = "X";
            this.buttonCls.UseVisualStyleBackColor = true;
            this.buttonCls.Click += new System.EventHandler(this.buttonCls_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(385, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 29);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "<-";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(420, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MakeVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(490, 548);
            this.Controls.Add(this.ButtonMakeVacancy);
            this.Controls.Add(this.SalarytextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.DiscriptionLabel);
            this.Controls.Add(this.DistextBox);
            this.Controls.Add(this.Namedlabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeVacancyForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonMakeVacancy;
        private System.Windows.Forms.TextBox SalarytextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.TextBox DistextBox;
        private System.Windows.Forms.Label Namedlabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCls;
    }
}