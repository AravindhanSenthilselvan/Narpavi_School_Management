namespace N
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            groupBox1 = new GroupBox();
            textBoxReason = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonAttendanceDisplay = new Button();
            buttonAttendanceNew = new Button();
            buttonAttendanceDelete = new Button();
            buttonAttendanceUpdate = new Button();
            buttonAttendanceAdd = new Button();
            buttonAttendanceSave = new Button();
            textBoxStatus = new TextBox();
            textBoxStudentname = new TextBox();
            textBoxStudentid = new TextBox();
            dateTimePickerAttendance = new DateTimePicker();
            labelPhone = new Label();
            labelDob = new Label();
            labelStudentname = new Label();
            labelStudentid = new Label();
            labelStudentheader = new Label();
            panelStudentheader = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelStudentheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxReason);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAttendanceDisplay);
            groupBox1.Controls.Add(buttonAttendanceNew);
            groupBox1.Controls.Add(buttonAttendanceDelete);
            groupBox1.Controls.Add(buttonAttendanceUpdate);
            groupBox1.Controls.Add(buttonAttendanceAdd);
            groupBox1.Controls.Add(buttonAttendanceSave);
            groupBox1.Controls.Add(textBoxStatus);
            groupBox1.Controls.Add(textBoxStudentname);
            groupBox1.Controls.Add(textBoxStudentid);
            groupBox1.Controls.Add(dateTimePickerAttendance);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelDob);
            groupBox1.Controls.Add(labelStudentname);
            groupBox1.Controls.Add(labelStudentid);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1012, 329);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enrollment Information";
            // 
            // textBoxReason
            // 
            textBoxReason.Location = new Point(257, 194);
            textBoxReason.Multiline = true;
            textBoxReason.Name = "textBoxReason";
            textBoxReason.Size = new Size(200, 68);
            textBoxReason.TabIndex = 20;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 189);
            label1.Name = "label1";
            label1.Size = new Size(128, 44);
            label1.TabIndex = 19;
            label1.Text = "Reason in case of absence";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(489, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // buttonAttendanceDisplay
            // 
            buttonAttendanceDisplay.BackColor = Color.Firebrick;
            buttonAttendanceDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAttendanceDisplay.ForeColor = SystemColors.ControlLightLight;
            buttonAttendanceDisplay.Location = new Point(690, 268);
            buttonAttendanceDisplay.Name = "buttonAttendanceDisplay";
            buttonAttendanceDisplay.Size = new Size(100, 45);
            buttonAttendanceDisplay.TabIndex = 17;
            buttonAttendanceDisplay.Text = "Display";
            buttonAttendanceDisplay.UseVisualStyleBackColor = false;
            buttonAttendanceDisplay.Click += buttonAttendanceDisplay_Click_1;
            // 
            // buttonAttendanceNew
            // 
            buttonAttendanceNew.BackColor = Color.Firebrick;
            buttonAttendanceNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAttendanceNew.ForeColor = SystemColors.ControlLightLight;
            buttonAttendanceNew.Location = new Point(574, 268);
            buttonAttendanceNew.Name = "buttonAttendanceNew";
            buttonAttendanceNew.Size = new Size(100, 45);
            buttonAttendanceNew.TabIndex = 16;
            buttonAttendanceNew.Text = "New";
            buttonAttendanceNew.UseVisualStyleBackColor = false;
            buttonAttendanceNew.Click += buttonAttendanceNew_Click_1;
            // 
            // buttonAttendanceDelete
            // 
            buttonAttendanceDelete.BackColor = Color.Firebrick;
            buttonAttendanceDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAttendanceDelete.ForeColor = SystemColors.ControlLightLight;
            buttonAttendanceDelete.Location = new Point(458, 268);
            buttonAttendanceDelete.Name = "buttonAttendanceDelete";
            buttonAttendanceDelete.Size = new Size(100, 45);
            buttonAttendanceDelete.TabIndex = 15;
            buttonAttendanceDelete.Text = "Delete";
            buttonAttendanceDelete.UseVisualStyleBackColor = false;
            buttonAttendanceDelete.Click += buttonAttendanceDelete_Click_1;
            // 
            // buttonAttendanceUpdate
            // 
            buttonAttendanceUpdate.BackColor = Color.Firebrick;
            buttonAttendanceUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAttendanceUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonAttendanceUpdate.Location = new Point(343, 268);
            buttonAttendanceUpdate.Name = "buttonAttendanceUpdate";
            buttonAttendanceUpdate.Size = new Size(100, 45);
            buttonAttendanceUpdate.TabIndex = 14;
            buttonAttendanceUpdate.Text = "Update";
            buttonAttendanceUpdate.UseVisualStyleBackColor = false;
            buttonAttendanceUpdate.Click += buttonAttendanceUpdate_Click_1;
            // 
            // buttonAttendanceAdd
            // 
            buttonAttendanceAdd.BackColor = Color.Firebrick;
            buttonAttendanceAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAttendanceAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAttendanceAdd.Location = new Point(227, 268);
            buttonAttendanceAdd.Name = "buttonAttendanceAdd";
            buttonAttendanceAdd.Size = new Size(100, 45);
            buttonAttendanceAdd.TabIndex = 13;
            buttonAttendanceAdd.Text = "Add";
            buttonAttendanceAdd.UseVisualStyleBackColor = false;
            buttonAttendanceAdd.Click += buttonAttendanceAdd_Click_1;
            // 
            // buttonAttendanceSave
            // 
            buttonAttendanceSave.BackColor = Color.Firebrick;
            buttonAttendanceSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAttendanceSave.ForeColor = SystemColors.ControlLightLight;
            buttonAttendanceSave.Location = new Point(111, 268);
            buttonAttendanceSave.Name = "buttonAttendanceSave";
            buttonAttendanceSave.Size = new Size(100, 45);
            buttonAttendanceSave.TabIndex = 12;
            buttonAttendanceSave.Text = "Save";
            buttonAttendanceSave.UseVisualStyleBackColor = false;
            buttonAttendanceSave.Click += buttonAttendanceSave_Click_1;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(257, 152);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(200, 23);
            textBoxStatus.TabIndex = 10;
            // 
            // textBoxStudentname
            // 
            textBoxStudentname.Location = new Point(257, 66);
            textBoxStudentname.Name = "textBoxStudentname";
            textBoxStudentname.Size = new Size(200, 23);
            textBoxStudentname.TabIndex = 9;
            // 
            // textBoxStudentid
            // 
            textBoxStudentid.Location = new Point(257, 29);
            textBoxStudentid.Name = "textBoxStudentid";
            textBoxStudentid.Size = new Size(200, 23);
            textBoxStudentid.TabIndex = 8;
            // 
            // dateTimePickerAttendance
            // 
            dateTimePickerAttendance.Format = DateTimePickerFormat.Custom;
            dateTimePickerAttendance.Location = new Point(257, 110);
            dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            dateTimePickerAttendance.Size = new Size(200, 23);
            dateTimePickerAttendance.TabIndex = 6;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhone.Location = new Point(83, 147);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(49, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Status";
            // 
            // labelDob
            // 
            labelDob.AutoSize = true;
            labelDob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDob.Location = new Point(83, 107);
            labelDob.Name = "labelDob";
            labelDob.Size = new Size(41, 20);
            labelDob.TabIndex = 2;
            labelDob.Text = "Date";
            // 
            // labelStudentname
            // 
            labelStudentname.AutoSize = true;
            labelStudentname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentname.Location = new Point(83, 68);
            labelStudentname.Name = "labelStudentname";
            labelStudentname.Size = new Size(104, 20);
            labelStudentname.TabIndex = 1;
            labelStudentname.Text = "Student Name";
            // 
            // labelStudentid
            // 
            labelStudentid.AutoSize = true;
            labelStudentid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentid.Location = new Point(83, 29);
            labelStudentid.Name = "labelStudentid";
            labelStudentid.Size = new Size(77, 20);
            labelStudentid.TabIndex = 0;
            labelStudentid.Text = "Student id";
            // 
            // labelStudentheader
            // 
            labelStudentheader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStudentheader.AutoSize = true;
            labelStudentheader.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentheader.ForeColor = SystemColors.ButtonHighlight;
            labelStudentheader.Location = new Point(448, 3);
            labelStudentheader.Name = "labelStudentheader";
            labelStudentheader.Size = new Size(174, 40);
            labelStudentheader.TabIndex = 0;
            labelStudentheader.Text = "Attendance";
            labelStudentheader.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelStudentheader
            // 
            panelStudentheader.BackColor = Color.DarkRed;
            panelStudentheader.Controls.Add(labelStudentheader);
            panelStudentheader.Dock = DockStyle.Top;
            panelStudentheader.Location = new Point(0, 0);
            panelStudentheader.Name = "panelStudentheader";
            panelStudentheader.Size = new Size(1012, 46);
            panelStudentheader.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1012, 207);
            dataGridView1.TabIndex = 6;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 589);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panelStudentheader);
            Name = "Attendance";
            Text = "Attendance";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelStudentheader.ResumeLayout(false);
            panelStudentheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonAttendanceDisplay;
        private Button buttonAttendanceNew;
        private Button buttonAttendanceDelete;
        private Button buttonAttendanceUpdate;
        private Button buttonAttendanceAdd;
        private Button buttonAttendanceSave;
        private TextBox textBoxStatus;
        private TextBox textBoxStudentname;
        private TextBox textBoxStudentid;
        private DateTimePicker dateTimePickerAttendance;
        private Label labelPhone;
        private Label labelDob;
        private Label labelStudentname;
        private Label labelStudentid;
        private Label labelStudentheader;
        private Panel panelStudentheader;
        private TextBox textBoxReason;
        private Label label1;
        private DataGridView dataGridView1;
    }
}