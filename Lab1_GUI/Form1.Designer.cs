namespace Lab1_GUI
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
            textBoxNUM = new TextBox();
            textBoxPIN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxNUM
            // 
            textBoxNUM.Font = new Font("Segoe UI", 20F);
            textBoxNUM.Location = new Point(49, 87);
            textBoxNUM.Name = "textBoxNUM";
            textBoxNUM.Size = new Size(285, 43);
            textBoxNUM.TabIndex = 2;
            textBoxNUM.TabStop = false;
            textBoxNUM.TextAlign = HorizontalAlignment.Center;
            textBoxNUM.TextChanged += textBoxNUM_TextChanged;
            // 
            // textBoxPIN
            // 
            textBoxPIN.Font = new Font("Segoe UI", 20F);
            textBoxPIN.Location = new Point(140, 189);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.Size = new Size(91, 43);
            textBoxPIN.TabIndex = 3;
            textBoxPIN.TabStop = false;
            textBoxPIN.TextAlign = HorizontalAlignment.Center;
            textBoxPIN.TextChanged += textBoxPIN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(106, 47);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 4;
            label1.Text = "Card Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(125, 149);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 5;
            label2.Text = "Enter PIN";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(81, 265);
            button1.Name = "button1";
            button1.Size = new Size(212, 69);
            button1.TabIndex = 6;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 374);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPIN);
            Controls.Add(textBoxNUM);
            MaximumSize = new Size(406, 413);
            MinimumSize = new Size(406, 413);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNUM;
        private TextBox textBoxPIN;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
