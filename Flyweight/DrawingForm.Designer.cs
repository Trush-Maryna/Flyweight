namespace Flyweight
{
    partial class DrawingForm
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
            BtnStart = new Button();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.BackColor = SystemColors.GradientActiveCaption;
            BtnStart.Dock = DockStyle.Bottom;
            BtnStart.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStart.Location = new Point(0, 416);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(800, 34);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = false;
            BtnStart.Click += BtnStart_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Bottom;
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(0, 381);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(800, 35);
            textBoxOutput.TabIndex = 1;
            textBoxOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // DrawingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutput);
            Controls.Add(BtnStart);
            Name = "DrawingForm";
            Text = "DrawingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private TextBox textBoxOutput;
    }
}
