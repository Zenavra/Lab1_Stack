namespace Lab1_GUI
{
    partial class History
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
            listBox1 = new ListBox();
            dayButton = new Button();
            weekButton = new Button();
            monthButton = new Button();
            okButton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(358, 259);
            listBox1.TabIndex = 0;
            // 
            // dayButton
            // 
            dayButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dayButton.Location = new Point(377, 12);
            dayButton.Name = "dayButton";
            dayButton.Size = new Size(75, 40);
            dayButton.TabIndex = 1;
            dayButton.Text = "Day";
            dayButton.UseVisualStyleBackColor = true;
            dayButton.Click += dayButton_Click;
            // 
            // weekButton
            // 
            weekButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            weekButton.Location = new Point(377, 58);
            weekButton.Name = "weekButton";
            weekButton.Size = new Size(75, 40);
            weekButton.TabIndex = 2;
            weekButton.Text = "Week";
            weekButton.UseVisualStyleBackColor = true;
            weekButton.Click += weekButton_Click;
            // 
            // monthButton
            // 
            monthButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            monthButton.Location = new Point(376, 104);
            monthButton.Name = "monthButton";
            monthButton.Size = new Size(75, 40);
            monthButton.TabIndex = 3;
            monthButton.Text = "Month";
            monthButton.UseVisualStyleBackColor = true;
            monthButton.Click += monthButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(377, 248);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 288);
            Controls.Add(okButton);
            Controls.Add(monthButton);
            Controls.Add(weekButton);
            Controls.Add(dayButton);
            Controls.Add(listBox1);
            MaximumSize = new Size(480, 327);
            MinimumSize = new Size(480, 327);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button dayButton;
        private Button weekButton;
        private Button monthButton;
        private Button okButton;
    }
}