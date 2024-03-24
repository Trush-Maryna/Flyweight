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
            components = new System.ComponentModel.Container();
            textBoxOutput = new TextBox();
            BtnStart = new Button();
            BtnStop = new Button();
            pictrBox = new PictureBox();
            drawTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictrBox).BeginInit();
            SuspendLayout();
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Top;
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(0, 34);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(800, 40);
            textBoxOutput.TabIndex = 1;
            textBoxOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnStart
            // 
            BtnStart.AllowDrop = true;
            BtnStart.BackColor = SystemColors.GradientActiveCaption;
            BtnStart.Dock = DockStyle.Top;
            BtnStart.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStart.Location = new Point(0, 0);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(800, 34);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = false;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnStop
            // 
            BtnStop.BackColor = Color.RosyBrown;
            BtnStop.Dock = DockStyle.Top;
            BtnStop.Font = new Font("Unispace", 10F);
            BtnStop.Location = new Point(0, 74);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(800, 34);
            BtnStop.TabIndex = 2;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = false;
            BtnStop.Click += BtnStop_Click;
            // 
            // pictrBox
            // 
            pictrBox.Dock = DockStyle.Top;
            pictrBox.Location = new Point(0, 108);
            pictrBox.Name = "pictrBox";
            pictrBox.Size = new Size(800, 348);
            pictrBox.TabIndex = 3;
            pictrBox.TabStop = false;
            pictrBox.Paint += pictrBox_Paint;
            // 
            // drawTimer
            // 
            drawTimer.Tick += drawTimer_Tick;
            // 
            // DrawingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(pictrBox);
            Controls.Add(BtnStop);
            Controls.Add(textBoxOutput);
            Controls.Add(BtnStart);
            Name = "DrawingForm";
            Text = "DrawingForm";
            ((System.ComponentModel.ISupportInitialize)pictrBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOutput;
        private Button BtnStart;
        private Button BtnStop;
        private PictureBox pictrBox;
        private System.Windows.Forms.Timer drawTimer;
    }
}
