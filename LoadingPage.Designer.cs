namespace N
{
    partial class LoadingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPage));
            panelLoading = new Panel();
            panelLoading1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelLoading.SuspendLayout();
            SuspendLayout();
            // 
            // panelLoading
            // 
            panelLoading.BackColor = Color.Silver;
            panelLoading.Controls.Add(panelLoading1);
            panelLoading.Dock = DockStyle.Bottom;
            panelLoading.Location = new Point(0, 389);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new Size(966, 10);
            panelLoading.TabIndex = 5;
            panelLoading.Paint += panelLoading_Paint;
            // 
            // panelLoading1
            // 
            panelLoading1.BackColor = Color.Firebrick;
            panelLoading1.Location = new Point(0, -1);
            panelLoading1.Name = "panelLoading1";
            panelLoading1.Size = new Size(50, 10);
            panelLoading1.TabIndex = 6;
            panelLoading1.Paint += panelLoading1_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // LoadingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(966, 399);
            Controls.Add(panelLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingPage";
            panelLoading.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoading;
        private Panel panelLoading1;
        private System.Windows.Forms.Timer timer1;
    }
}