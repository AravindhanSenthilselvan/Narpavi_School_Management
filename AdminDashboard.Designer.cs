namespace N
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panelMainSide = new Panel();
            pictureBox1 = new PictureBox();
            labelMainheader = new Label();
            panelMainheader = new Panel();
            panel1 = new Panel();
            labelCount = new Label();
            label1 = new Label();
            panel2 = new Panel();
            labelSubject = new Label();
            label4 = new Label();
            panel3 = new Panel();
            labelTeachers = new Label();
            label6 = new Label();
            panel4 = new Panel();
            labelEnrollment = new Label();
            label8 = new Label();
            panelMainSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainheader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainSide
            // 
            panelMainSide.BackColor = Color.DarkCyan;
            panelMainSide.Controls.Add(pictureBox1);
            panelMainSide.Dock = DockStyle.Left;
            panelMainSide.Location = new Point(0, 47);
            panelMainSide.Name = "panelMainSide";
            panelMainSide.Size = new Size(200, 551);
            panelMainSide.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelMainheader
            // 
            labelMainheader.AutoSize = true;
            labelMainheader.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMainheader.ForeColor = SystemColors.ButtonHighlight;
            labelMainheader.Location = new Point(1, 9);
            labelMainheader.Name = "labelMainheader";
            labelMainheader.Size = new Size(265, 35);
            labelMainheader.TabIndex = 0;
            labelMainheader.Text = "ADMIN DASHBOARD";
            // 
            // panelMainheader
            // 
            panelMainheader.BackColor = SystemColors.HotTrack;
            panelMainheader.Controls.Add(labelMainheader);
            panelMainheader.Dock = DockStyle.Top;
            panelMainheader.Location = new Point(0, 0);
            panelMainheader.Name = "panelMainheader";
            panelMainheader.Size = new Size(973, 47);
            panelMainheader.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(labelCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(229, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 209);
            panel1.TabIndex = 4;
            // 
            // labelCount
            // 
            labelCount.Font = new Font("Segoe UI", 20F);
            labelCount.ForeColor = SystemColors.ButtonHighlight;
            labelCount.Location = new Point(126, 17);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(32, 38);
            labelCount.TabIndex = 1;
            labelCount.Text = "0";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(138, 38);
            label1.TabIndex = 0;
            label1.Text = "Students:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(labelSubject);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(456, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 209);
            panel2.TabIndex = 5;
            // 
            // labelSubject
            // 
            labelSubject.Font = new Font("Segoe UI", 20F);
            labelSubject.ForeColor = SystemColors.ButtonHighlight;
            labelSubject.Location = new Point(128, 17);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(32, 38);
            labelSubject.TabIndex = 1;
            labelSubject.Text = "0";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(138, 38);
            label4.TabIndex = 0;
            label4.Text = "Subjects:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(labelTeachers);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(684, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 209);
            panel3.TabIndex = 5;
            // 
            // labelTeachers
            // 
            labelTeachers.Font = new Font("Segoe UI", 20F);
            labelTeachers.ForeColor = SystemColors.ButtonHighlight;
            labelTeachers.Location = new Point(126, 17);
            labelTeachers.Name = "labelTeachers";
            labelTeachers.Size = new Size(32, 38);
            labelTeachers.TabIndex = 1;
            labelTeachers.Text = "0";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(138, 38);
            label6.TabIndex = 0;
            label6.Text = "Teachers:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(labelEnrollment);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(229, 290);
            panel4.Name = "panel4";
            panel4.Size = new Size(663, 65);
            panel4.TabIndex = 5;
            // 
            // labelEnrollment
            // 
            labelEnrollment.Font = new Font("Segoe UI", 20F);
            labelEnrollment.ForeColor = SystemColors.ButtonHighlight;
            labelEnrollment.Location = new Point(377, 17);
            labelEnrollment.Name = "labelEnrollment";
            labelEnrollment.Size = new Size(32, 38);
            labelEnrollment.TabIndex = 1;
            labelEnrollment.Text = "0";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 20F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(230, 17);
            label8.Name = "label8";
            label8.Size = new Size(158, 38);
            label8.TabIndex = 0;
            label8.Text = "Enrollment:";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(973, 598);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMainSide);
            Controls.Add(panelMainheader);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panelMainSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMainheader.ResumeLayout(false);
            panelMainheader.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainSide;
        private Label labelMainheader;
        private Panel panelMainheader;
        private Panel panel1;
        private Label label1;
        private Label labelCount;
        private Panel panel2;
        private Label labelSubject;
        private Label label4;
        private Panel panel3;
        private Label labelTeachers;
        private Label label6;
        private Panel panel4;
        private Label labelEnrollment;
        private Label label8;
        private PictureBox pictureBox1;
    }
}