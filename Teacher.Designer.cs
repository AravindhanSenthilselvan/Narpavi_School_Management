namespace N
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            groupBox1 = new GroupBox();
            buttonTeacherSave = new Button();
            buttonTeacherDisplay = new Button();
            buttonTeacherNew = new Button();
            buttonTeacherDelete = new Button();
            buttonTeacherUpdate = new Button();
            buttonTeacherAdd = new Button();
            textBoxTeacherEmail = new TextBox();
            textBoxTeacherPhonenumber = new TextBox();
            textBoxTeachername = new TextBox();
            textBoxTeacherid = new TextBox();
            comboBoxTeacherGender = new ComboBox();
            dateTimePickerTeacherdob = new DateTimePicker();
            labelEmail = new Label();
            labelPhone = new Label();
            labelGender = new Label();
            labelDob = new Label();
            labelTeachername = new Label();
            labelTeacherid = new Label();
            pictureBox1 = new PictureBox();
            labelTeacherheader = new Label();
            panelTeacherheader = new Panel();
            dataGridViewTeacher = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTeacherheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonTeacherSave);
            groupBox1.Controls.Add(buttonTeacherDisplay);
            groupBox1.Controls.Add(buttonTeacherNew);
            groupBox1.Controls.Add(buttonTeacherDelete);
            groupBox1.Controls.Add(buttonTeacherUpdate);
            groupBox1.Controls.Add(buttonTeacherAdd);
            groupBox1.Controls.Add(textBoxTeacherEmail);
            groupBox1.Controls.Add(textBoxTeacherPhonenumber);
            groupBox1.Controls.Add(textBoxTeachername);
            groupBox1.Controls.Add(textBoxTeacherid);
            groupBox1.Controls.Add(comboBoxTeacherGender);
            groupBox1.Controls.Add(dateTimePickerTeacherdob);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelGender);
            groupBox1.Controls.Add(labelDob);
            groupBox1.Controls.Add(labelTeachername);
            groupBox1.Controls.Add(labelTeacherid);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1019, 329);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teacher Information";
            // 
            // buttonTeacherSave
            // 
            buttonTeacherSave.BackColor = Color.Firebrick;
            buttonTeacherSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeacherSave.ForeColor = SystemColors.ControlLightLight;
            buttonTeacherSave.Location = new Point(97, 268);
            buttonTeacherSave.Name = "buttonTeacherSave";
            buttonTeacherSave.Size = new Size(100, 45);
            buttonTeacherSave.TabIndex = 19;
            buttonTeacherSave.Text = "Save";
            buttonTeacherSave.UseVisualStyleBackColor = false;
            buttonTeacherSave.Click += buttonTeacherSave_Click;
            // 
            // buttonTeacherDisplay
            // 
            buttonTeacherDisplay.BackColor = Color.Firebrick;
            buttonTeacherDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeacherDisplay.ForeColor = SystemColors.ControlLightLight;
            buttonTeacherDisplay.Location = new Point(678, 268);
            buttonTeacherDisplay.Name = "buttonTeacherDisplay";
            buttonTeacherDisplay.Size = new Size(100, 45);
            buttonTeacherDisplay.TabIndex = 17;
            buttonTeacherDisplay.Text = "Display";
            buttonTeacherDisplay.UseVisualStyleBackColor = false;
            buttonTeacherDisplay.Click += buttonTeacherDisplay_Click;
            // 
            // buttonTeacherNew
            // 
            buttonTeacherNew.BackColor = Color.Firebrick;
            buttonTeacherNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeacherNew.ForeColor = SystemColors.ControlLightLight;
            buttonTeacherNew.Location = new Point(556, 268);
            buttonTeacherNew.Name = "buttonTeacherNew";
            buttonTeacherNew.Size = new Size(100, 45);
            buttonTeacherNew.TabIndex = 16;
            buttonTeacherNew.Text = "New";
            buttonTeacherNew.UseVisualStyleBackColor = false;
            buttonTeacherNew.Click += buttonTeacherNew_Click;
            // 
            // buttonTeacherDelete
            // 
            buttonTeacherDelete.BackColor = Color.Firebrick;
            buttonTeacherDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeacherDelete.ForeColor = SystemColors.ControlLightLight;
            buttonTeacherDelete.Location = new Point(435, 268);
            buttonTeacherDelete.Name = "buttonTeacherDelete";
            buttonTeacherDelete.Size = new Size(100, 45);
            buttonTeacherDelete.TabIndex = 15;
            buttonTeacherDelete.Text = "Delete";
            buttonTeacherDelete.UseVisualStyleBackColor = false;
            buttonTeacherDelete.Click += buttonTeacherDelete_Click;
            // 
            // buttonTeacherUpdate
            // 
            buttonTeacherUpdate.BackColor = Color.Firebrick;
            buttonTeacherUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeacherUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonTeacherUpdate.Location = new Point(319, 268);
            buttonTeacherUpdate.Name = "buttonTeacherUpdate";
            buttonTeacherUpdate.Size = new Size(100, 45);
            buttonTeacherUpdate.TabIndex = 14;
            buttonTeacherUpdate.Text = "Update";
            buttonTeacherUpdate.UseVisualStyleBackColor = false;
            buttonTeacherUpdate.Click += buttonTeacherUpdate_Click;
            // 
            // buttonTeacherAdd
            // 
            buttonTeacherAdd.BackColor = Color.Firebrick;
            buttonTeacherAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTeacherAdd.ForeColor = SystemColors.ControlLightLight;
            buttonTeacherAdd.Location = new Point(203, 268);
            buttonTeacherAdd.Name = "buttonTeacherAdd";
            buttonTeacherAdd.Size = new Size(100, 45);
            buttonTeacherAdd.TabIndex = 13;
            buttonTeacherAdd.Text = "Add";
            buttonTeacherAdd.UseVisualStyleBackColor = false;
            buttonTeacherAdd.Click += buttonTeacherAdd_Click;
            // 
            // textBoxTeacherEmail
            // 
            textBoxTeacherEmail.Location = new Point(257, 220);
            textBoxTeacherEmail.Name = "textBoxTeacherEmail";
            textBoxTeacherEmail.Size = new Size(200, 23);
            textBoxTeacherEmail.TabIndex = 11;
            // 
            // textBoxTeacherPhonenumber
            // 
            textBoxTeacherPhonenumber.Location = new Point(257, 182);
            textBoxTeacherPhonenumber.Name = "textBoxTeacherPhonenumber";
            textBoxTeacherPhonenumber.Size = new Size(200, 23);
            textBoxTeacherPhonenumber.TabIndex = 10;
            // 
            // textBoxTeachername
            // 
            textBoxTeachername.Location = new Point(257, 66);
            textBoxTeachername.Name = "textBoxTeachername";
            textBoxTeachername.Size = new Size(200, 23);
            textBoxTeachername.TabIndex = 9;
            // 
            // textBoxTeacherid
            // 
            textBoxTeacherid.Location = new Point(257, 29);
            textBoxTeacherid.Name = "textBoxTeacherid";
            textBoxTeacherid.Size = new Size(200, 23);
            textBoxTeacherid.TabIndex = 8;
            // 
            // comboBoxTeacherGender
            // 
            comboBoxTeacherGender.FormattingEnabled = true;
            comboBoxTeacherGender.Items.AddRange(new object[] { "None", "Male", "Female" });
            comboBoxTeacherGender.Location = new Point(257, 146);
            comboBoxTeacherGender.Name = "comboBoxTeacherGender";
            comboBoxTeacherGender.Size = new Size(200, 23);
            comboBoxTeacherGender.TabIndex = 7;
            // 
            // dateTimePickerTeacherdob
            // 
            dateTimePickerTeacherdob.Format = DateTimePickerFormat.Custom;
            dateTimePickerTeacherdob.Location = new Point(257, 110);
            dateTimePickerTeacherdob.Name = "dateTimePickerTeacherdob";
            dateTimePickerTeacherdob.Size = new Size(200, 23);
            dateTimePickerTeacherdob.TabIndex = 6;
            dateTimePickerTeacherdob.ValueChanged += dateTimePickerTeacherdob_ValueChanged;
            dateTimePickerTeacherdob.KeyDown += dateTimePickerTeacherdob_KeyDown;
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
            // labelTeachername
            // 
            labelTeachername.AutoSize = true;
            labelTeachername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeachername.Location = new Point(83, 66);
            labelTeachername.Name = "labelTeachername";
            labelTeachername.Size = new Size(104, 20);
            labelTeachername.TabIndex = 1;
            labelTeachername.Text = "Teacher Name";
            // 
            // labelTeacherid
            // 
            labelTeacherid.AutoSize = true;
            labelTeacherid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeacherid.Location = new Point(83, 29);
            labelTeacherid.Name = "labelTeacherid";
            labelTeacherid.Size = new Size(77, 20);
            labelTeacherid.TabIndex = 0;
            labelTeacherid.Text = "Teacher id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 323);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // labelTeacherheader
            // 
            labelTeacherheader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTeacherheader.AutoSize = true;
            labelTeacherheader.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTeacherheader.ForeColor = SystemColors.ButtonHighlight;
            labelTeacherheader.Location = new Point(448, 3);
            labelTeacherheader.Name = "labelTeacherheader";
            labelTeacherheader.Size = new Size(122, 40);
            labelTeacherheader.TabIndex = 0;
            labelTeacherheader.Text = "Teacher";
            labelTeacherheader.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelTeacherheader
            // 
            panelTeacherheader.BackColor = Color.DarkRed;
            panelTeacherheader.Controls.Add(labelTeacherheader);
            panelTeacherheader.Dock = DockStyle.Top;
            panelTeacherheader.Location = new Point(0, 0);
            panelTeacherheader.Name = "panelTeacherheader";
            panelTeacherheader.Size = new Size(1019, 46);
            panelTeacherheader.TabIndex = 2;
            // 
            // dataGridViewTeacher
            // 
            dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeacher.Location = new Point(0, 381);
            dataGridViewTeacher.Name = "dataGridViewTeacher";
            dataGridViewTeacher.Size = new Size(1019, 183);
            dataGridViewTeacher.TabIndex = 4;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 567);
            Controls.Add(dataGridViewTeacher);
            Controls.Add(groupBox1);
            Controls.Add(panelTeacherheader);
            Name = "Teacher";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTeacherheader.ResumeLayout(false);
            panelTeacherheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonTeacherDisplay;
        private Button buttonTeacherNew;
        private Button buttonTeacherDelete;
        private Button buttonTeacherUpdate;
        private Button buttonTeacherAdd;
        private TextBox textBoxTeacherEmail;
        private TextBox textBoxTeacherPhonenumber;
        private TextBox textBoxTeachername;
        private TextBox textBoxTeacherid;
        private ComboBox comboBoxTeacherGender;
        private DateTimePicker dateTimePickerTeacherdob;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelGender;
        private Label labelDob;
        private Label labelTeachername;
        private Label labelTeacherid;
        private Label labelTeacherheader;
        private Panel panelTeacherheader;
        private DataGridView dataGridViewTeacher;
        private Button buttonTeacherSave;
    }
}