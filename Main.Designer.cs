namespace N
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelMainheader = new Panel();
            labelMainheader = new Label();
            panelMainSide = new Panel();
            buttonDashboard = new Button();
            buttonAttendance = new Button();
            buttonEnrollment = new Button();
            buttonStandard = new Button();
            buttonTeacher = new Button();
            buttonSubject = new Button();
            buttonStudent = new Button();
            panelMainheader.SuspendLayout();
            panelMainSide.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainheader
            // 
            panelMainheader.BackColor = SystemColors.HotTrack;
            panelMainheader.Controls.Add(labelMainheader);
            panelMainheader.Dock = DockStyle.Top;
            panelMainheader.Location = new Point(0, 0);
            panelMainheader.Name = "panelMainheader";
            panelMainheader.Size = new Size(776, 47);
            panelMainheader.TabIndex = 0;
            // 
            // labelMainheader
            // 
            labelMainheader.AutoSize = true;
            labelMainheader.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMainheader.ForeColor = SystemColors.ButtonHighlight;
            labelMainheader.Location = new Point(1, 9);
            labelMainheader.Name = "labelMainheader";
            labelMainheader.Size = new Size(410, 35);
            labelMainheader.TabIndex = 0;
            labelMainheader.Text = "SCHOOL MANAGEMENT SYSTEM";
            // 
            // panelMainSide
            // 
            panelMainSide.BackColor = Color.DarkRed;
            panelMainSide.Controls.Add(buttonDashboard);
            panelMainSide.Controls.Add(buttonAttendance);
            panelMainSide.Controls.Add(buttonEnrollment);
            panelMainSide.Controls.Add(buttonStandard);
            panelMainSide.Controls.Add(buttonTeacher);
            panelMainSide.Controls.Add(buttonSubject);
            panelMainSide.Controls.Add(buttonStudent);
            panelMainSide.Dock = DockStyle.Left;
            panelMainSide.Location = new Point(0, 47);
            panelMainSide.Name = "panelMainSide";
            panelMainSide.Size = new Size(200, 553);
            panelMainSide.TabIndex = 1;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Font = new Font("Segoe UI", 12F);
            buttonDashboard.Location = new Point(23, 255);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(158, 34);
            buttonDashboard.TabIndex = 6;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Font = new Font("Segoe UI", 12F);
            buttonAttendance.Location = new Point(23, 215);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(158, 34);
            buttonAttendance.TabIndex = 5;
            buttonAttendance.Text = "Attendance";
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // buttonEnrollment
            // 
            buttonEnrollment.Font = new Font("Segoe UI", 12F);
            buttonEnrollment.Location = new Point(23, 175);
            buttonEnrollment.Name = "buttonEnrollment";
            buttonEnrollment.Size = new Size(158, 34);
            buttonEnrollment.TabIndex = 4;
            buttonEnrollment.Text = "Enrollment";
            buttonEnrollment.UseVisualStyleBackColor = true;
            buttonEnrollment.Click += buttonEnrollment_Click;
            // 
            // buttonStandard
            // 
            buttonStandard.Font = new Font("Segoe UI", 12F);
            buttonStandard.Location = new Point(23, 135);
            buttonStandard.Name = "buttonStandard";
            buttonStandard.Size = new Size(158, 34);
            buttonStandard.TabIndex = 3;
            buttonStandard.Text = "Standard";
            buttonStandard.UseVisualStyleBackColor = true;
            buttonStandard.Click += buttonStandard_Click;
            // 
            // buttonTeacher
            // 
            buttonTeacher.Font = new Font("Segoe UI", 12F);
            buttonTeacher.Location = new Point(23, 95);
            buttonTeacher.Name = "buttonTeacher";
            buttonTeacher.Size = new Size(158, 34);
            buttonTeacher.TabIndex = 2;
            buttonTeacher.Text = "Teacher";
            buttonTeacher.UseVisualStyleBackColor = true;
            buttonTeacher.Click += button3_Click;
            // 
            // buttonSubject
            // 
            buttonSubject.Font = new Font("Segoe UI", 12F);
            buttonSubject.Location = new Point(23, 55);
            buttonSubject.Name = "buttonSubject";
            buttonSubject.Size = new Size(158, 34);
            buttonSubject.TabIndex = 1;
            buttonSubject.Text = "Subject";
            buttonSubject.UseVisualStyleBackColor = true;
            buttonSubject.Click += buttonSubject_Click;
            // 
            // buttonStudent
            // 
            buttonStudent.Font = new Font("Segoe UI", 12F);
            buttonStudent.Location = new Point(23, 15);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Size = new Size(158, 34);
            buttonStudent.TabIndex = 0;
            buttonStudent.Text = "Student";
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += buttonStudent_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(776, 600);
            Controls.Add(panelMainSide);
            Controls.Add(panelMainheader);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panelMainheader.ResumeLayout(false);
            panelMainheader.PerformLayout();
            panelMainSide.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainheader;
        private Label labelMainheader;
        private Panel panelMainSide;
        private Button buttonTeacher;
        private Button buttonSubject;
        private Button buttonStudent;
        private Button buttonDashboard;
        private Button buttonAttendance;
        private Button buttonEnrollment;
        private Button buttonStandard;
    }
}