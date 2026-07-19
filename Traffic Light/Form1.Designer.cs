namespace Traffic_Light
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlTrafficLights1 = new ctrlTrafficLights();
            SuspendLayout();
            // 
            // ctrlTrafficLights1
            // 
            ctrlTrafficLights1.CurrentLight = ctrlTrafficLights.Lights.Green;
            ctrlTrafficLights1.GreenTime = 5;
            ctrlTrafficLights1.Location = new Point(12, 28);
            ctrlTrafficLights1.Name = "ctrlTrafficLights1";
            ctrlTrafficLights1.OrangeTime = 3;
            ctrlTrafficLights1.RedTime = 10;
            ctrlTrafficLights1.Size = new Size(88, 213);
            ctrlTrafficLights1.TabIndex = 0;
            ctrlTrafficLights1.RedLightOn += ctrlTrafficLights1_RedLightOn;
            ctrlTrafficLights1.GreenLightOn += ctrlTrafficLights1_GreenLightOn;
            ctrlTrafficLights1.OrangeLightOn += ctrlTrafficLights1_OrangeLightOn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(148, 280);
            Controls.Add(ctrlTrafficLights1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ctrlTrafficLights ctrlTrafficLights1;
    }
}
