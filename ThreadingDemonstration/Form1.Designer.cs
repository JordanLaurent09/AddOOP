namespace ThreadingDemonstration
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
            FirstProcessPB = new ProgressBar();
            FirstStartBTN = new Button();
            SecondStartBTN = new Button();
            SecondProcessPB = new ProgressBar();
            SuspendLayout();
            // 
            // FirstProcessPB
            // 
            FirstProcessPB.Location = new Point(12, 12);
            FirstProcessPB.Name = "FirstProcessPB";
            FirstProcessPB.Size = new Size(776, 34);
            FirstProcessPB.TabIndex = 0;
            // 
            // FirstStartBTN
            // 
            FirstStartBTN.Location = new Point(599, 64);
            FirstStartBTN.Name = "FirstStartBTN";
            FirstStartBTN.Size = new Size(189, 46);
            FirstStartBTN.TabIndex = 1;
            FirstStartBTN.Text = "Запуск";
            FirstStartBTN.UseVisualStyleBackColor = true;
            FirstStartBTN.Click += FirstStartBTN_Click;
            // 
            // SecondStartBTN
            // 
            SecondStartBTN.Location = new Point(599, 228);
            SecondStartBTN.Name = "SecondStartBTN";
            SecondStartBTN.Size = new Size(189, 46);
            SecondStartBTN.TabIndex = 3;
            SecondStartBTN.Text = "Запуск";
            SecondStartBTN.UseVisualStyleBackColor = true;
            SecondStartBTN.Click += SecondStartBTN_Click;
            // 
            // SecondProcessPB
            // 
            SecondProcessPB.Location = new Point(12, 176);
            SecondProcessPB.Name = "SecondProcessPB";
            SecondProcessPB.Size = new Size(776, 34);
            SecondProcessPB.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SecondStartBTN);
            Controls.Add(SecondProcessPB);
            Controls.Add(FirstStartBTN);
            Controls.Add(FirstProcessPB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar FirstProcessPB;
        private Button FirstStartBTN;
        private Button SecondStartBTN;
        private ProgressBar SecondProcessPB;
    }
}