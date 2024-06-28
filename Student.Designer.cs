namespace N
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panelStudentheader = new Panel();
            labelStudentheader = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonStudentDisplay = new Button();
            buttonStudentNew = new Button();
            buttonStudentDelete = new Button();
            buttonStudentUpdate = new Button();
            buttonStudentAdd = new Button();
            buttonStudentSave = new Button();
            textBoxEmail = new TextBox();
            textBoxPhonenumber = new TextBox();
            textBoxStudentname = new TextBox();
            textBoxStudentid = new TextBox();
            comboBoxGender = new ComboBox();
            dateTimePickerdob = new DateTimePicker();
            labelEmail = new Label();
            labelPhone = new Label();
            labelGender = new Label();
            labelDob = new Label();
            labelStudentname = new Label();
            labelStudentid = new Label();
            dataGridViewStudent = new DataGridView();
            panelStudentheader.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // panelStudentheader
            // 
            panelStudentheader.BackColor = Color.DarkRed;
            panelStudentheader.Controls.Add(labelStudentheader);
            panelStudentheader.Dock = DockStyle.Top;
            panelStudentheader.Location = new Point(0, 0);
            panelStudentheader.Name = "panelStudentheader";
            panelStudentheader.Size = new Size(922, 46);
            panelStudentheader.TabIndex = 0;
            // 
            // labelStudentheader
            // 
            labelStudentheader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStudentheader.AutoSize = true;
            labelStudentheader.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentheader.ForeColor = SystemColors.ButtonHighlight;
            labelStudentheader.Location = new Point(448, 3);
            labelStudentheader.Name = "labelStudentheader";
            labelStudentheader.Size = new Size(124, 40);
            labelStudentheader.TabIndex = 0;
            labelStudentheader.Text = "Student";
            labelStudentheader.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonStudentDisplay);
            groupBox1.Controls.Add(buttonStudentNew);
            groupBox1.Controls.Add(buttonStudentDelete);
            groupBox1.Controls.Add(buttonStudentUpdate);
            groupBox1.Controls.Add(buttonStudentAdd);
            groupBox1.Controls.Add(buttonStudentSave);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxPhonenumber);
            groupBox1.Controls.Add(textBoxStudentname);
            groupBox1.Controls.Add(textBoxStudentid);
            groupBox1.Controls.Add(comboBoxGender);
            groupBox1.Controls.Add(dateTimePickerdob);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelGender);
            groupBox1.Controls.Add(labelDob);
            groupBox1.Controls.Add(labelStudentname);
            groupBox1.Controls.Add(labelStudentid);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(922, 329);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // buttonStudentDisplay
            // 
            buttonStudentDisplay.BackColor = Color.Firebrick;
            buttonStudentDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStudentDisplay.ForeColor = SystemColors.ControlLightLight;
            buttonStudentDisplay.Location = new Point(678, 268);
            buttonStudentDisplay.Name = "buttonStudentDisplay";
            buttonStudentDisplay.Size = new Size(100, 45);
            buttonStudentDisplay.TabIndex = 17;
            buttonStudentDisplay.Text = "Display";
            buttonStudentDisplay.UseVisualStyleBackColor = false;
            buttonStudentDisplay.Click += buttonStudentDisplay_Click;
            // 
            // buttonStudentNew
            // 
            buttonStudentNew.BackColor = Color.Firebrick;
            buttonStudentNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStudentNew.ForeColor = SystemColors.ControlLightLight;
            buttonStudentNew.Location = new Point(556, 268);
            buttonStudentNew.Name = "buttonStudentNew";
            buttonStudentNew.Size = new Size(100, 45);
            buttonStudentNew.TabIndex = 16;
            buttonStudentNew.Text = "New";
            buttonStudentNew.UseVisualStyleBackColor = false;
            buttonStudentNew.Click += buttonStudentNew_Click;
            // 
            // buttonStudentDelete
            // 
            buttonStudentDelete.BackColor = Color.Firebrick;
            buttonStudentDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStudentDelete.ForeColor = SystemColors.ControlLightLight;
            buttonStudentDelete.Location = new Point(435, 268);
            buttonStudentDelete.Name = "buttonStudentDelete";
            buttonStudentDelete.Size = new Size(100, 45);
            buttonStudentDelete.TabIndex = 15;
            buttonStudentDelete.Text = "Delete";
            buttonStudentDelete.UseVisualStyleBackColor = false;
            buttonStudentDelete.Click += buttonStudentDelete_Click;
            // 
            // buttonStudentUpdate
            // 
            buttonStudentUpdate.BackColor = Color.Firebrick;
            buttonStudentUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStudentUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonStudentUpdate.Location = new Point(319, 268);
            buttonStudentUpdate.Name = "buttonStudentUpdate";
            buttonStudentUpdate.Size = new Size(100, 45);
            buttonStudentUpdate.TabIndex = 14;
            buttonStudentUpdate.Text = "Update";
            buttonStudentUpdate.UseVisualStyleBackColor = false;
            buttonStudentUpdate.Click += buttonStudentUpdate_Click;
            // 
            // buttonStudentAdd
            // 
            buttonStudentAdd.BackColor = Color.Firebrick;
            buttonStudentAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStudentAdd.ForeColor = SystemColors.ControlLightLight;
            buttonStudentAdd.Location = new Point(203, 268);
            buttonStudentAdd.Name = "buttonStudentAdd";
            buttonStudentAdd.Size = new Size(100, 45);
            buttonStudentAdd.TabIndex = 13;
            buttonStudentAdd.Text = "Add";
            buttonStudentAdd.UseVisualStyleBackColor = false;
            buttonStudentAdd.Click += buttonStudentAdd_Click;
            // 
            // buttonStudentSave
            // 
            buttonStudentSave.BackColor = Color.Firebrick;
            buttonStudentSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStudentSave.ForeColor = SystemColors.ControlLightLight;
            buttonStudentSave.Location = new Point(87, 268);
            buttonStudentSave.Name = "buttonStudentSave";
            buttonStudentSave.Size = new Size(100, 45);
            buttonStudentSave.TabIndex = 12;
            buttonStudentSave.Text = "Save";
            buttonStudentSave.UseVisualStyleBackColor = false;
            buttonStudentSave.Click += buttonStudentSave_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(257, 220);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 11;
            // 
            // textBoxPhonenumber
            // 
            textBoxPhonenumber.Location = new Point(257, 182);
            textBoxPhonenumber.Name = "textBoxPhonenumber";
            textBoxPhonenumber.Size = new Size(200, 23);
            textBoxPhonenumber.TabIndex = 10;
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
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "None", "Male", "Female" });
            comboBoxGender.Location = new Point(257, 146);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(200, 23);
            comboBoxGender.TabIndex = 7;
            // 
            // dateTimePickerdob
            // 
            dateTimePickerdob.Format = DateTimePickerFormat.Custom;
            dateTimePickerdob.Location = new Point(257, 110);
            dateTimePickerdob.Name = "dateTimePickerdob";
            dateTimePickerdob.Size = new Size(200, 23);
            dateTimePickerdob.TabIndex = 6;
            dateTimePickerdob.ValueChanged += dateTimePickerdob_ValueChanged;
            dateTimePickerdob.KeyDown += dateTimePickerdob_KeyDown;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(83, 219);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 20);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email id";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhone.Location = new Point(83, 181);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(50, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(83, 145);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(57, 20);
            labelGender.TabIndex = 3;
            labelGender.Text = "Gender";
            // 
            // labelDob
            // 
            labelDob.AutoSize = true;
            labelDob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDob.Location = new Point(83, 107);
            labelDob.Name = "labelDob";
            labelDob.Size = new Size(137, 20);
            labelDob.TabIndex = 2;
            labelDob.Text = "Date of Birth (Dob)";
            // 
            // labelStudentname
            // 
            labelStudentname.AutoSize = true;
            labelStudentname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentname.Location = new Point(83, 66);
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
            // dataGridViewStudent
            // 
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(0, 381);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.Size = new Size(922, 181);
            dataGridViewStudent.TabIndex = 2;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 562);
            Controls.Add(dataGridViewStudent);
            Controls.Add(groupBox1);
            Controls.Add(panelStudentheader);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            panelStudentheader.ResumeLayout(false);
            panelStudentheader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStudentheader;
        private Label labelStudentheader;
        private GroupBox groupBox1;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelGender;
        private Label labelDob;
        private Label labelStudentname;
        private Label labelStudentid;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerdob;
        private TextBox textBoxEmail;
        private TextBox textBoxPhonenumber;
        private TextBox textBoxStudentname;
        private TextBox textBoxStudentid;
        private Button buttonStudentSave;
        private Button buttonStudentDisplay;
        private Button buttonStudentNew;
        private Button buttonStudentDelete;
        private Button buttonStudentUpdate;
        private Button buttonStudentAdd;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewStudent;
    }
}