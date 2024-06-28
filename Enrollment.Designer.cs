namespace N
{
    partial class Enrollment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enrollment));
            labelStudentheader = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonEnrollmentDisplay = new Button();
            buttonEnrollmentNew = new Button();
            buttonEnrollmentDelete = new Button();
            buttonEnrollmentUpdate = new Button();
            buttonEnrollmentAdd = new Button();
            buttonEnrollmentSave = new Button();
            textBoxEnrollmentStandard = new TextBox();
            textBoxEnrollmentStudentname = new TextBox();
            textBoxEnrollmentStudentid = new TextBox();
            dateTimePickerEnrollment = new DateTimePicker();
            labelPhone = new Label();
            labelDob = new Label();
            labelStudentname = new Label();
            labelStudentid = new Label();
            panelStudentheader = new Panel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelStudentheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelStudentheader
            // 
            labelStudentheader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStudentheader.AutoSize = true;
            labelStudentheader.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentheader.ForeColor = SystemColors.ButtonHighlight;
            labelStudentheader.Location = new Point(448, 3);
            labelStudentheader.Name = "labelStudentheader";
            labelStudentheader.Size = new Size(168, 40);
            labelStudentheader.TabIndex = 0;
            labelStudentheader.Text = "Enrollment";
            labelStudentheader.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(buttonEnrollmentDisplay);
            groupBox1.Controls.Add(buttonEnrollmentNew);
            groupBox1.Controls.Add(buttonEnrollmentDelete);
            groupBox1.Controls.Add(buttonEnrollmentUpdate);
            groupBox1.Controls.Add(buttonEnrollmentAdd);
            groupBox1.Controls.Add(buttonEnrollmentSave);
            groupBox1.Controls.Add(textBoxEnrollmentStandard);
            groupBox1.Controls.Add(textBoxEnrollmentStudentname);
            groupBox1.Controls.Add(textBoxEnrollmentStudentid);
            groupBox1.Controls.Add(dateTimePickerEnrollment);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelDob);
            groupBox1.Controls.Add(labelStudentname);
            groupBox1.Controls.Add(labelStudentid);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1001, 329);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enrollment Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 323);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // buttonEnrollmentDisplay
            // 
            buttonEnrollmentDisplay.BackColor = Color.Firebrick;
            buttonEnrollmentDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnrollmentDisplay.ForeColor = SystemColors.ControlLightLight;
            buttonEnrollmentDisplay.Location = new Point(315, 262);
            buttonEnrollmentDisplay.Name = "buttonEnrollmentDisplay";
            buttonEnrollmentDisplay.Size = new Size(100, 45);
            buttonEnrollmentDisplay.TabIndex = 17;
            buttonEnrollmentDisplay.Text = "Display";
            buttonEnrollmentDisplay.UseVisualStyleBackColor = false;
            buttonEnrollmentDisplay.Click += buttonEnrollmentDisplay_Click;
            // 
            // buttonEnrollmentNew
            // 
            buttonEnrollmentNew.BackColor = Color.Firebrick;
            buttonEnrollmentNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnrollmentNew.ForeColor = SystemColors.ControlLightLight;
            buttonEnrollmentNew.Location = new Point(199, 262);
            buttonEnrollmentNew.Name = "buttonEnrollmentNew";
            buttonEnrollmentNew.Size = new Size(100, 45);
            buttonEnrollmentNew.TabIndex = 16;
            buttonEnrollmentNew.Text = "New";
            buttonEnrollmentNew.UseVisualStyleBackColor = false;
            buttonEnrollmentNew.Click += buttonEnrollmentNew_Click;
            // 
            // buttonEnrollmentDelete
            // 
            buttonEnrollmentDelete.BackColor = Color.Firebrick;
            buttonEnrollmentDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnrollmentDelete.ForeColor = SystemColors.ControlLightLight;
            buttonEnrollmentDelete.Location = new Point(83, 262);
            buttonEnrollmentDelete.Name = "buttonEnrollmentDelete";
            buttonEnrollmentDelete.Size = new Size(100, 45);
            buttonEnrollmentDelete.TabIndex = 15;
            buttonEnrollmentDelete.Text = "Delete";
            buttonEnrollmentDelete.UseVisualStyleBackColor = false;
            buttonEnrollmentDelete.Click += buttonEnrollmentDelete_Click;
            // 
            // buttonEnrollmentUpdate
            // 
            buttonEnrollmentUpdate.BackColor = Color.Firebrick;
            buttonEnrollmentUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnrollmentUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonEnrollmentUpdate.Location = new Point(315, 192);
            buttonEnrollmentUpdate.Name = "buttonEnrollmentUpdate";
            buttonEnrollmentUpdate.Size = new Size(100, 45);
            buttonEnrollmentUpdate.TabIndex = 14;
            buttonEnrollmentUpdate.Text = "Update";
            buttonEnrollmentUpdate.UseVisualStyleBackColor = false;
            buttonEnrollmentUpdate.Click += buttonEnrollmentUpdate_Click;
            // 
            // buttonEnrollmentAdd
            // 
            buttonEnrollmentAdd.BackColor = Color.Firebrick;
            buttonEnrollmentAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnrollmentAdd.ForeColor = SystemColors.ControlLightLight;
            buttonEnrollmentAdd.Location = new Point(199, 192);
            buttonEnrollmentAdd.Name = "buttonEnrollmentAdd";
            buttonEnrollmentAdd.Size = new Size(100, 45);
            buttonEnrollmentAdd.TabIndex = 13;
            buttonEnrollmentAdd.Text = "Add";
            buttonEnrollmentAdd.UseVisualStyleBackColor = false;
            buttonEnrollmentAdd.Click += buttonEnrollmentAdd_Click;
            // 
            // buttonEnrollmentSave
            // 
            buttonEnrollmentSave.BackColor = Color.Firebrick;
            buttonEnrollmentSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnrollmentSave.ForeColor = SystemColors.ControlLightLight;
            buttonEnrollmentSave.Location = new Point(83, 192);
            buttonEnrollmentSave.Name = "buttonEnrollmentSave";
            buttonEnrollmentSave.Size = new Size(100, 45);
            buttonEnrollmentSave.TabIndex = 12;
            buttonEnrollmentSave.Text = "Save";
            buttonEnrollmentSave.UseVisualStyleBackColor = false;
            buttonEnrollmentSave.Click += buttonEnrollmentSave_Click;
            // 
            // textBoxEnrollmentStandard
            // 
            textBoxEnrollmentStandard.Location = new Point(257, 152);
            textBoxEnrollmentStandard.Name = "textBoxEnrollmentStandard";
            textBoxEnrollmentStandard.Size = new Size(200, 23);
            textBoxEnrollmentStandard.TabIndex = 10;
            // 
            // textBoxEnrollmentStudentname
            // 
            textBoxEnrollmentStudentname.Location = new Point(257, 66);
            textBoxEnrollmentStudentname.Name = "textBoxEnrollmentStudentname";
            textBoxEnrollmentStudentname.Size = new Size(200, 23);
            textBoxEnrollmentStudentname.TabIndex = 9;
            // 
            // textBoxEnrollmentStudentid
            // 
            textBoxEnrollmentStudentid.Location = new Point(257, 29);
            textBoxEnrollmentStudentid.Name = "textBoxEnrollmentStudentid";
            textBoxEnrollmentStudentid.Size = new Size(200, 23);
            textBoxEnrollmentStudentid.TabIndex = 8;
            // 
            // dateTimePickerEnrollment
            // 
            dateTimePickerEnrollment.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnrollment.Location = new Point(257, 110);
            dateTimePickerEnrollment.Name = "dateTimePickerEnrollment";
            dateTimePickerEnrollment.Size = new Size(200, 23);
            dateTimePickerEnrollment.TabIndex = 6;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhone.Location = new Point(83, 147);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(69, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Standard";
            // 
            // labelDob
            // 
            labelDob.AutoSize = true;
            labelDob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDob.Location = new Point(83, 107);
            labelDob.Name = "labelDob";
            labelDob.Size = new Size(117, 20);
            labelDob.TabIndex = 2;
            labelDob.Text = "Enrollment Date";
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
            labelStudentid.Size = new Size(98, 20);
            labelStudentid.TabIndex = 0;
            labelStudentid.Text = "Enrollment id";
            // 
            // panelStudentheader
            // 
            panelStudentheader.BackColor = Color.DarkRed;
            panelStudentheader.Controls.Add(labelStudentheader);
            panelStudentheader.Dock = DockStyle.Top;
            panelStudentheader.Location = new Point(0, 0);
            panelStudentheader.Name = "panelStudentheader";
            panelStudentheader.Size = new Size(1001, 46);
            panelStudentheader.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1001, 195);
            dataGridView1.TabIndex = 4;
            // 
            // Enrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 579);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panelStudentheader);
            Name = "Enrollment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelStudentheader.ResumeLayout(false);
            panelStudentheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelStudentheader;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonEnrollmentDisplay;
        private Button buttonEnrollmentNew;
        private Button buttonEnrollmentDelete;
        private Button buttonEnrollmentUpdate;
        private Button buttonEnrollmentAdd;
        private Button buttonEnrollmentSave;
        private TextBox textBoxEnrollmentStandard;
        private TextBox textBoxEnrollmentStudentname;
        private TextBox textBoxEnrollmentStudentid;
        private DateTimePicker dateTimePickerEnrollment;
        private Label labelPhone;
        private Label labelDob;
        private Label labelStudentname;
        private Label labelStudentid;
        private Panel panelStudentheader;
        private DataGridView dataGridView1;
    }
}