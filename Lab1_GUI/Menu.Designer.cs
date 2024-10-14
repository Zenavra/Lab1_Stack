namespace Lab1_GUI
{
    partial class Menu
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
            balanceButton = new Button();
            transferButton = new Button();
            historyButton = new Button();
            nearestButton = new Button();
            withdrawButton = new Button();
            logOutButton = new Button();
            ATMInfoButton = new Button();
            SuspendLayout();
            // 
            // balanceButton
            // 
            balanceButton.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceButton.Location = new Point(161, 41);
            balanceButton.Name = "balanceButton";
            balanceButton.Size = new Size(258, 67);
            balanceButton.TabIndex = 1;
            balanceButton.Text = "Balance";
            balanceButton.UseVisualStyleBackColor = true;
            balanceButton.Click += balanceButton_Click;
            // 
            // transferButton
            // 
            transferButton.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            transferButton.Location = new Point(161, 127);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(258, 70);
            transferButton.TabIndex = 2;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // historyButton
            // 
            historyButton.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            historyButton.Location = new Point(387, 304);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(177, 41);
            historyButton.TabIndex = 3;
            historyButton.Text = "History";
            historyButton.UseVisualStyleBackColor = true;
            historyButton.Click += historyButton_Click;
            // 
            // nearestButton
            // 
            nearestButton.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nearestButton.Location = new Point(21, 304);
            nearestButton.Name = "nearestButton";
            nearestButton.Size = new Size(177, 41);
            nearestButton.TabIndex = 4;
            nearestButton.Text = "Nearest ATM";
            nearestButton.UseVisualStyleBackColor = true;
            nearestButton.Click += nearestButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdrawButton.Location = new Point(161, 216);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(258, 73);
            withdrawButton.TabIndex = 5;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logOutButton.Location = new Point(484, 41);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(88, 40);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "LogOut";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // ATMInfoButton
            // 
            ATMInfoButton.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ATMInfoButton.Location = new Point(204, 304);
            ATMInfoButton.Name = "ATMInfoButton";
            ATMInfoButton.Size = new Size(177, 41);
            ATMInfoButton.TabIndex = 7;
            ATMInfoButton.Text = "ATM Info";
            ATMInfoButton.UseVisualStyleBackColor = true;
            ATMInfoButton.Click += ATMInfoButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(ATMInfoButton);
            Controls.Add(logOutButton);
            Controls.Add(withdrawButton);
            Controls.Add(nearestButton);
            Controls.Add(historyButton);
            Controls.Add(transferButton);
            Controls.Add(balanceButton);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion
        private Button balanceButton;
        private Button transferButton;
        private Button historyButton;
        private Button nearestButton;
        private Button withdrawButton;
        private Button logOutButton;
        private Button ATMInfoButton;
    }
}