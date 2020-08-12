namespace AppDBRecruitment
{
    partial class Vacancy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacancy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewVacancy = new System.Windows.Forms.DataGridView();
            this.Rowlbl = new System.Windows.Forms.Label();
            this.buttonCls = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacancy)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(689, 34);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dataGridViewVacancy
            // 
            this.dataGridViewVacancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacancy.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewVacancy.Name = "dataGridViewVacancy";
            this.dataGridViewVacancy.Size = new System.Drawing.Size(625, 428);
            this.dataGridViewVacancy.TabIndex = 11;
            // 
            // Rowlbl
            // 
            this.Rowlbl.AutoSize = true;
            this.Rowlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.Rowlbl.Location = new System.Drawing.Point(632, 80);
            this.Rowlbl.Name = "Rowlbl";
            this.Rowlbl.Size = new System.Drawing.Size(41, 20);
            this.Rowlbl.TabIndex = 12;
            this.Rowlbl.Text = "Row";
            this.Rowlbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rowlbl_MouseMove);
            // 
            // buttonCls
            // 
            this.buttonCls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCls.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCls.FlatAppearance.BorderSize = 0;
            this.buttonCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCls.Location = new System.Drawing.Point(654, 0);
            this.buttonCls.Name = "buttonCls";
            this.buttonCls.Size = new System.Drawing.Size(35, 34);
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
            this.buttonClose.Location = new System.Drawing.Point(584, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 34);
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
            this.button1.Location = new System.Drawing.Point(619, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(689, 463);
            this.Controls.Add(this.Rowlbl);
            this.Controls.Add(this.dataGridViewVacancy);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vacancy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacancy";
            this.Load += new System.EventHandler(this.Vacancy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewVacancy;
        private System.Windows.Forms.Label Rowlbl;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCls;
    }
}