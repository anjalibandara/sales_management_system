namespace SalesManagementSystem
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            welcomePanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcomePanel
            // 
            welcomePanel.BackColor = SystemColors.Highlight;
            welcomePanel.Controls.Add(label1);
            welcomePanel.Location = new Point(0, 0);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(802, 125);
            welcomePanel.TabIndex = 0;
            welcomePanel.Paint += welcomePanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 39);
            label1.Name = "label1";
            label1.Size = new Size(467, 49);
            label1.TabIndex = 0;
            label1.Text = "Sales management system";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(117, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(164, 409);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(436, 18);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(welcomePanel);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            welcomePanel.ResumeLayout(false);
            welcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel welcomePanel;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}