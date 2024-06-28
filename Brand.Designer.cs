namespace N
{
    partial class Brand
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brand));
            timerbrand = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            panelbrand = new Panel();
            SuspendLayout();
            // 
            // timerbrand
            // 
            timerbrand.Enabled = true;
            timerbrand.Interval = 10;
            timerbrand.Tick += timerbrand_Tick;
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(117, 42);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 0;
            label1.Text = "School Management System";
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Berlin Sans FB", 15F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 86);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 1;
            label2.Text = "Powered by";
            // 
            // panelbrand
            // 
            panelbrand.BackColor = Color.White;
            panelbrand.Location = new Point(2, 357);
            panelbrand.Name = "panelbrand";
            panelbrand.Size = new Size(50, 10);
            panelbrand.TabIndex = 7;
            // 
            // Brand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(501, 368);
            Controls.Add(panelbrand);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Brand";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brand";
            Load += Brand_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerbrand;
        private Label label1;
        private Label label2;
        private Panel panelbrand;
    }
}