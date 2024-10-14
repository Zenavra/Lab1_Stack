namespace Lab1_GUI
{
    partial class menuWithdraw
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
            label1 = new Label();
            textBox1 = new TextBox();
            cancelButton = new Button();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(317, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter amount to withdaw";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(94, 72);
            textBox1.MaximumSize = new Size(173, 39);
            textBox1.MinimumSize = new Size(173, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 39);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(193, 127);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(102, 48);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            confirmButton.Location = new Point(55, 127);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(102, 48);
            confirmButton.TabIndex = 3;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // menuWithdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 192);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximumSize = new Size(377, 231);
            MinimumSize = new Size(377, 231);
            Name = "menuWithdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuWithdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button cancelButton;
        private Button confirmButton;
    }
}