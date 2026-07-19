namespace Traffic_Light
{
    partial class ctrlTrafficLights
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbLight = new PictureBox();
            lblCountDown = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbLight).BeginInit();
            SuspendLayout();
            // 
            // pbLight
            // 
            pbLight.Image = Properties.Resources.Red;
            pbLight.Location = new Point(3, 0);
            pbLight.Name = "pbLight";
            pbLight.Size = new Size(93, 167);
            pbLight.SizeMode = PictureBoxSizeMode.Zoom;
            pbLight.TabIndex = 0;
            pbLight.TabStop = false;
            // 
            // lblCountDown
            // 
            lblCountDown.AutoSize = true;
            lblCountDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountDown.ForeColor = Color.Red;
            lblCountDown.Location = new Point(31, 170);
            lblCountDown.Name = "lblCountDown";
            lblCountDown.Size = new Size(39, 28);
            lblCountDown.TabIndex = 1;
            lblCountDown.Text = "???";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ctrlTrafficLights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCountDown);
            Controls.Add(pbLight);
            Name = "ctrlTrafficLights";
            Size = new Size(99, 199);
            ((System.ComponentModel.ISupportInitialize)pbLight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLight;
        private Label lblCountDown;
        private System.Windows.Forms.Timer timer1;
    }
}
