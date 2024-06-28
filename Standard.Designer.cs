namespace N
{
    partial class Standard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standard));
            labelStandardheader = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonStandardStudentDisplay = new Button();
            buttonStandardStudentNew = new Button();
            buttonStandardStudentDelete = new Button();
            buttonStandardStudentUpdate = new Button();
            buttonStandardStudentAdd = new Button();
            buttonStandardStudentSave = new Button();
            textBoxStandard = new TextBox();
            textBoxStandardStudentname = new TextBox();
            textBoxStandardStudentid = new TextBox();
            labelStandardPhone = new Label();
            labelStandardStudentname = new Label();
            labelStandardStudentid = new Label();
            panelStudentheader = new Panel();
            dataGridViewStandard = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelStudentheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStandard).BeginInit();
            SuspendLayout();
            // 
            // labelStandardheader
            // 
            labelStandardheader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStandardheader.AutoSize = true;
            labelStandardheader.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStandardheader.ForeColor = SystemColors.ButtonHighlight;
            labelStandardheader.Location = new Point(448, 3);
            labelStandardheader.Name = "labelStandardheader";
            labelStandardheader.Size = new Size(141, 40);
            labelStandardheader.TabIndex = 0;
            labelStandardheader.Text = "Standard";
            labelStandardheader.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(buttonStandardStudentDisplay);
            groupBox1.Controls.Add(buttonStandardStudentNew);
            groupBox1.Controls.Add(buttonStandardStudentDelete);
            groupBox1.Controls.Add(buttonStandardStudentUpdate);
            groupBox1.Controls.Add(buttonStandardStudentAdd);
            groupBox1.Controls.Add(buttonStandardStudentSave);
            groupBox1.Controls.Add(textBoxStandard);
            groupBox1.Controls.Add(textBoxStandardStudentname);
            groupBox1.Controls.Add(textBoxStandardStudentid);
            groupBox1.Controls.Add(labelStandardPhone);
            groupBox1.Controls.Add(labelStandardStudentname);
            groupBox1.Controls.Add(labelStandardStudentid);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 329);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Standard Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(517, 317);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // buttonStandardStudentDisplay
            // 
            buttonStandardStudentDisplay.BackColor = Color.Firebrick;
            buttonStandardStudentDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStandardStudentDisplay.ForeColor = SystemColors.ControlLightLight;
            buttonStandardStudentDisplay.Location = new Point(318, 219);
            buttonStandardStudentDisplay.Name = "buttonStandardStudentDisplay";
            buttonStandardStudentDisplay.Size = new Size(100, 45);
            buttonStandardStudentDisplay.TabIndex = 17;
            buttonStandardStudentDisplay.Text = "Display";
            buttonStandardStudentDisplay.UseVisualStyleBackColor = false;
            buttonStandardStudentDisplay.Click += buttonStandardStudentDisplay_Click;
            // 
            // buttonStandardStudentNew
            // 
            buttonStandardStudentNew.BackColor = Color.Firebrick;
            buttonStandardStudentNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStandardStudentNew.ForeColor = SystemColors.ControlLightLight;
            buttonStandardStudentNew.Location = new Point(202, 219);
            buttonStandardStudentNew.Name = "buttonStandardStudentNew";
            buttonStandardStudentNew.Size = new Size(100, 45);
            buttonStandardStudentNew.TabIndex = 16;
            buttonStandardStudentNew.Text = "New";
            buttonStandardStudentNew.UseVisualStyleBackColor = false;
            buttonStandardStudentNew.Click += buttonStandardStudentNew_Click;
            // 
            // buttonStandardStudentDelete
            // 
            buttonStandardStudentDelete.BackColor = Color.Firebrick;
            buttonStandardStudentDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStandardStudentDelete.ForeColor = SystemColors.ControlLightLight;
            buttonStandardStudentDelete.Location = new Point(87, 219);
            buttonStandardStudentDelete.Name = "buttonStandardStudentDelete";
            buttonStandardStudentDelete.Size = new Size(100, 45);
            buttonStandardStudentDelete.TabIndex = 15;
            buttonStandardStudentDelete.Text = "Delete";
            buttonStandardStudentDelete.UseVisualStyleBackColor = false;
            buttonStandardStudentDelete.Click += buttonStandardStudentDelete_Click;
            // 
            // buttonStandardStudentUpdate
            // 
            buttonStandardStudentUpdate.BackColor = Color.Firebrick;
            buttonStandardStudentUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStandardStudentUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonStandardStudentUpdate.Location = new Point(318, 153);
            buttonStandardStudentUpdate.Name = "buttonStandardStudentUpdate";
            buttonStandardStudentUpdate.Size = new Size(100, 45);
            buttonStandardStudentUpdate.TabIndex = 14;
            buttonStandardStudentUpdate.Text = "Update";
            buttonStandardStudentUpdate.UseVisualStyleBackColor = false;
            buttonStandardStudentUpdate.Click += buttonStandardStudentUpdate_Click;
            // 
            // buttonStandardStudentAdd
            // 
            buttonStandardStudentAdd.BackColor = Color.Firebrick;
            buttonStandardStudentAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStandardStudentAdd.ForeColor = SystemColors.ControlLightLight;
            buttonStandardStudentAdd.Location = new Point(202, 153);
            buttonStandardStudentAdd.Name = "buttonStandardStudentAdd";
            buttonStandardStudentAdd.Size = new Size(100, 45);
            buttonStandardStudentAdd.TabIndex = 13;
            buttonStandardStudentAdd.Text = "Add";
            buttonStandardStudentAdd.UseVisualStyleBackColor = false;
            buttonStandardStudentAdd.Click += buttonStandardStudentAdd_Click;
            // 
            // buttonStandardStudentSave
            // 
            buttonStandardStudentSave.BackColor = Color.Firebrick;
            buttonStandardStudentSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStandardStudentSave.ForeColor = SystemColors.ControlLightLight;
            buttonStandardStudentSave.Location = new Point(86, 153);
            buttonStandardStudentSave.Name = "buttonStandardStudentSave";
            buttonStandardStudentSave.Size = new Size(100, 45);
            buttonStandardStudentSave.TabIndex = 12;
            buttonStandardStudentSave.Text = "Save";
            buttonStandardStudentSave.UseVisualStyleBackColor = false;
            buttonStandardStudentSave.Click += buttonStandardStudentSave_Click;
            // 
            // textBoxStandard
            // 
            textBoxStandard.Location = new Point(259, 104);
            textBoxStandard.Name = "textBoxStandard";
            textBoxStandard.Size = new Size(200, 23);
            textBoxStandard.TabIndex = 10;
            // 
            // textBoxStandardStudentname
            // 
            textBoxStandardStudentname.Location = new Point(257, 66);
            textBoxStandardStudentname.Name = "textBoxStandardStudentname";
            textBoxStandardStudentname.Size = new Size(200, 23);
            textBoxStandardStudentname.TabIndex = 9;
            // 
            // textBoxStandardStudentid
            // 
            textBoxStandardStudentid.Location = new Point(257, 29);
            textBoxStandardStudentid.Name = "textBoxStandardStudentid";
            textBoxStandardStudentid.Size = new Size(200, 23);
            textBoxStandardStudentid.TabIndex = 8;
            // 
            // labelStandardPhone
            // 
            labelStandardPhone.AutoSize = true;
            labelStandardPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStandardPhone.Location = new Point(85, 103);
            labelStandardPhone.Name = "labelStandardPhone";
            labelStandardPhone.Size = new Size(69, 20);
            labelStandardPhone.TabIndex = 4;
            labelStandardPhone.Text = "Standard";
            // 
            // labelStandardStudentname
            // 
            labelStandardStudentname.AutoSize = true;
            labelStandardStudentname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStandardStudentname.Location = new Point(83, 66);
            labelStandardStudentname.Name = "labelStandardStudentname";
            labelStandardStudentname.Size = new Size(104, 20);
            labelStandardStudentname.TabIndex = 1;
            labelStandardStudentname.Text = "Student Name";
            // 
            // labelStandardStudentid
            // 
            labelStandardStudentid.AutoSize = true;
            labelStandardStudentid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStandardStudentid.Location = new Point(83, 29);
            labelStandardStudentid.Name = "labelStandardStudentid";
            labelStandardStudentid.Size = new Size(77, 20);
            labelStandardStudentid.TabIndex = 0;
            labelStandardStudentid.Text = "Student id";
            // 
            // panelStudentheader
            // 
            panelStudentheader.BackColor = Color.DarkRed;
            panelStudentheader.Controls.Add(labelStandardheader);
            panelStudentheader.Dock = DockStyle.Top;
            panelStudentheader.Location = new Point(0, 0);
            panelStudentheader.Name = "panelStudentheader";
            panelStudentheader.Size = new Size(992, 46);
            panelStudentheader.TabIndex = 2;
            // 
            // dataGridViewStandard
            // 
            dataGridViewStandard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStandard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStandard.Location = new Point(0, 378);
            dataGridViewStandard.Name = "dataGridViewStandard";
            dataGridViewStandard.Size = new Size(992, 220);
            dataGridViewStandard.TabIndex = 4;
            // 
            // Standard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 598);
            Controls.Add(dataGridViewStandard);
            Controls.Add(groupBox1);
            Controls.Add(panelStudentheader);
            Name = "Standard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Standard";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelStudentheader.ResumeLayout(false);
            panelStudentheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStandard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelStandardheader;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonStandardStudentDisplay;
        private Button buttonStandardStudentNew;
        private Button buttonStandardStudentDelete;
        private Button buttonStandardStudentUpdate;
        private Button buttonStandardStudentAdd;
        private Button buttonStandardStudentSave;
        private TextBox textBoxStandard;
        private TextBox textBoxStandardStudentname;
        private TextBox textBoxStandardStudentid;
        private Label labelStandardPhone;
        private Label labelStandardStudentname;
        private Label labelStandardStudentid;
        private Panel panelStudentheader;
        private DataGridView dataGridViewStandard;
    }
}