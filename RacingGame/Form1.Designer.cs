namespace RacingGame
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
            MercedesBTN = new Button();
            FerrariBTN = new Button();
            ZhiguleeBTN = new Button();
            CougarBTN = new Button();
            StartRaceBTN = new Button();
            SuspendLayout();
            // 
            // MercedesBTN
            // 
            MercedesBTN.Location = new Point(150, 74);
            MercedesBTN.Name = "MercedesBTN";
            MercedesBTN.Size = new Size(75, 23);
            MercedesBTN.TabIndex = 0;
            MercedesBTN.Text = "Мерседес";
            MercedesBTN.UseVisualStyleBackColor = true;
            // 
            // FerrariBTN
            // 
            FerrariBTN.Location = new Point(150, 142);
            FerrariBTN.Name = "FerrariBTN";
            FerrariBTN.Size = new Size(75, 23);
            FerrariBTN.TabIndex = 1;
            FerrariBTN.Text = "Феррари";
            FerrariBTN.UseVisualStyleBackColor = true;
            // 
            // ZhiguleeBTN
            // 
            ZhiguleeBTN.Location = new Point(150, 210);
            ZhiguleeBTN.Name = "ZhiguleeBTN";
            ZhiguleeBTN.Size = new Size(75, 23);
            ZhiguleeBTN.TabIndex = 2;
            ZhiguleeBTN.Text = "Жигули";
            ZhiguleeBTN.UseVisualStyleBackColor = true;
            // 
            // CougarBTN
            // 
            CougarBTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CougarBTN.Location = new Point(150, 288);
            CougarBTN.Name = "CougarBTN";
            CougarBTN.Size = new Size(75, 23);
            CougarBTN.TabIndex = 3;
            CougarBTN.Text = "Кугуар";
            CougarBTN.UseVisualStyleBackColor = true;
            // 
            // StartRaceBTN
            // 
            StartRaceBTN.Location = new Point(446, 382);
            StartRaceBTN.Name = "StartRaceBTN";
            StartRaceBTN.Size = new Size(245, 103);
            StartRaceBTN.TabIndex = 4;
            StartRaceBTN.Text = "СТАРТ!";
            StartRaceBTN.UseVisualStyleBackColor = true;
            StartRaceBTN.Click += StartRaceBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 553);
            Controls.Add(StartRaceBTN);
            Controls.Add(CougarBTN);
            Controls.Add(ZhiguleeBTN);
            Controls.Add(FerrariBTN);
            Controls.Add(MercedesBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button MercedesBTN;
        private Button FerrariBTN;
        private Button ZhiguleeBTN;
        private Button CougarBTN;
        private Button StartRaceBTN;
    }
}