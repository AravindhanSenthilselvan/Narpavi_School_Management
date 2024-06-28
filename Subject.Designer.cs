namespace N
{
    partial class Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
            labelStudentheader = new Label();
            panelSubjectheader = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonSubjectDisplay = new Button();
            buttonSubjectNew = new Button();
            buttonSubjectDelete = new Button();
            buttonSubjectUpdate = new Button();
            buttonSubjectAdd = new Button();
            buttonSubjectSave = new Button();
            textBoxSubjectname = new TextBox();
            textBoxSubjectid = new TextBox();
            labelStudentname = new Label();
            labelStudentid = new Label();
            dataGridViewSubject = new DataGridView();
            panelSubjectheader.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).BeginInit();
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
            labelStudentheader.Size = new Size(118, 40);
            labelStudentheader.TabIndex = 0;
            labelStudentheader.Text = "Subject";
            labelStudentheader.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelSubjectheader
            // 
            panelSubjectheader.BackColor = Color.DarkRed;
            panelSubjectheader.Controls.Add(labelStudentheader);
            panelSubjectheader.Dock = DockStyle.Top;
            panelSubjectheader.Location = new Point(0, 0);
            panelSubjectheader.Name = "panelSubjectheader";
            panelSubjectheader.Size = new Size(1118, 46);
            panelSubjectheader.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(buttonSubjectDisplay);
            groupBox1.Controls.Add(buttonSubjectNew);
            groupBox1.Controls.Add(buttonSubjectDelete);
            groupBox1.Controls.Add(buttonSubjectUpdate);
            groupBox1.Controls.Add(buttonSubjectAdd);
            groupBox1.Controls.Add(buttonSubjectSave);
            groupBox1.Controls.Add(textBoxSubjectname);
            groupBox1.Controls.Add(textBoxSubjectid);
            groupBox1.Controls.Add(labelStudentname);
            groupBox1.Controls.Add(labelStudentid);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1118, 329);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subject Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(649, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // buttonSubjectDisplay
            // 
            buttonSubjectDisplay.BackColor = Color.Firebrick;
            buttonSubjectDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubjectDisplay.ForeColor = SystemColors.ControlLightLight;
            buttonSubjectDisplay.Location = new Point(322, 179);
            buttonSubjectDisplay.Name = "buttonSubjectDisplay";
            buttonSubjectDisplay.Size = new Size(100, 45);
            buttonSubjectDisplay.TabIndex = 17;
            buttonSubjectDisplay.Text = "Display";
            buttonSubjectDisplay.UseVisualStyleBackColor = false;
            buttonSubjectDisplay.Click += buttonSubjectDisplay_Click;
            // 
            // buttonSubjectNew
            // 
            buttonSubjectNew.BackColor = Color.Firebrick;
            buttonSubjectNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubjectNew.ForeColor = SystemColors.ControlLightLight;
            buttonSubjectNew.Location = new Point(206, 179);
            buttonSubjectNew.Name = "buttonSubjectNew";
            buttonSubjectNew.Size = new Size(100, 45);
            buttonSubjectNew.TabIndex = 16;
            buttonSubjectNew.Text = "New";
            buttonSubjectNew.UseVisualStyleBackColor = false;
            buttonSubjectNew.Click += buttonSubjectNew_Click;
            // 
            // buttonSubjectDelete
            // 
            buttonSubjectDelete.BackColor = Color.Firebrick;
            buttonSubjectDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubjectDelete.ForeColor = SystemColors.ControlLightLight;
            buttonSubjectDelete.Location = new Point(90, 179);
            buttonSubjectDelete.Name = "buttonSubjectDelete";
            buttonSubjectDelete.Size = new Size(100, 45);
            buttonSubjectDelete.TabIndex = 15;
            buttonSubjectDelete.Text = "Delete";
            buttonSubjectDelete.UseVisualStyleBackColor = false;
            buttonSubjectDelete.Click += buttonSubjectDelete_Click;
            // 
            // buttonSubjectUpdate
            // 
            buttonSubjectUpdate.BackColor = Color.Firebrick;
            buttonSubjectUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubjectUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonSubjectUpdate.Location = new Point(322, 124);
            buttonSubjectUpdate.Name = "buttonSubjectUpdate";
            buttonSubjectUpdate.Size = new Size(100, 45);
            buttonSubjectUpdate.TabIndex = 14;
            buttonSubjectUpdate.Text = "Update";
            buttonSubjectUpdate.UseVisualStyleBackColor = false;
            buttonSubjectUpdate.Click += buttonSubjectUpdate_Click;
            // 
            // buttonSubjectAdd
            // 
            buttonSubjectAdd.BackColor = Color.Firebrick;
            buttonSubjectAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubjectAdd.ForeColor = SystemColors.ControlLightLight;
            buttonSubjectAdd.Location = new Point(206, 124);
            buttonSubjectAdd.Name = "buttonSubjectAdd";
            buttonSubjectAdd.Size = new Size(100, 45);
            buttonSubjectAdd.TabIndex = 13;
            buttonSubjectAdd.Text = "Add";
            buttonSubjectAdd.UseVisualStyleBackColor = false;
            buttonSubjectAdd.Click += buttonSubjectAdd_Click;
            // 
            // buttonSubjectSave
            // 
            buttonSubjectSave.BackColor = Color.Firebrick;
            buttonSubjectSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubjectSave.ForeColor = SystemColors.ControlLightLight;
            buttonSubjectSave.Location = new Point(90, 124);
            buttonSubjectSave.Name = "buttonSubjectSave";
            buttonSubjectSave.Size = new Size(100, 45);
            buttonSubjectSave.TabIndex = 12;
            buttonSubjectSave.Text = "Save";
            buttonSubjectSave.UseVisualStyleBackColor = false;
            buttonSubjectSave.Click += buttonSubjectSave_Click;
            // 
            // textBoxSubjectname
            // 
            textBoxSubjectname.Location = new Point(257, 66);
            textBoxSubjectname.Name = "textBoxSubjectname";
            textBoxSubjectname.Size = new Size(200, 23);
            textBoxSubjectname.TabIndex = 9;
            // 
            // textBoxSubjectid
            // 
            textBoxSubjectid.Location = new Point(257, 29);
            textBoxSubjectid.Name = "textBoxSubjectid";
            textBoxSubjectid.Size = new Size(200, 23);
            textBoxSubjectid.TabIndex = 8;
            // 
            // labelStudentname
            // 
            labelStudentname.AutoSize = true;
            labelStudentname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentname.Location = new Point(83, 66);
            labelStudentname.Name = "labelStudentname";
            labelStudentname.Size = new Size(102, 20);
            labelStudentname.TabIndex = 1;
            labelStudentname.Text = "Subject Name";
            // 
            // labelStudentid
            // 
            labelStudentid.AutoSize = true;
            labelStudentid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentid.Location = new Point(83, 29);
            labelStudentid.Name = "labelStudentid";
            labelStudentid.Size = new Size(75, 20);
            labelStudentid.TabIndex = 0;
            labelStudentid.Text = "Subject Id";
            // 
            // dataGridViewSubject
            // 
            dataGridViewSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubject.Location = new Point(0, 381);
            dataGridViewSubject.Name = "dataGridViewSubject";
            dataGridViewSubject.Size = new Size(1118, 196);
            dataGridViewSubject.TabIndex = 3;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 579);
            Controls.Add(dataGridViewSubject);
            Controls.Add(groupBox1);
            Controls.Add(panelSubjectheader);
            Name = "Subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject";
            Load += Subject_Load;
            panelSubjectheader.ResumeLayout(false);
            panelSubjectheader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelStudentheader;
        private Panel panelSubjectheader;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonSubjectDisplay;
        private Button buttonSubjectNew;
        private Button buttonSubjectDelete;
        private Button buttonSubjectUpdate;
        private Button buttonSubjectAdd;
        private Button buttonSubjectSave;
        private TextBox textBoxSubjectname;
        private TextBox textBoxSubjectid;
        private Label labelStudentname;
        private Label labelStudentid;
        private DataGridView dataGridViewSubject;
    }
}