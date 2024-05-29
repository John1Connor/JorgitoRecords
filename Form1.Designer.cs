namespace JorgitoRecords
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
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(26, 40);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(151, 48);
            btnStart.TabIndex = 0;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(183, 40);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(151, 48);
            btnStop.TabIndex = 1;
            btnStop.Text = "Detener";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 185);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "JorgitoRecords";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
    }
}
