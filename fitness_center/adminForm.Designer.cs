namespace fitness_center
{
    partial class adminForm
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
            this.login_AdminTextBox = new System.Windows.Forms.TextBox();
            this.login_AdminLabel = new System.Windows.Forms.Label();
            this.hello_AdminLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.unlockButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.password_AdminTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_AdminTextBox
            // 
            this.login_AdminTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_AdminTextBox.Location = new System.Drawing.Point(325, 163);
            this.login_AdminTextBox.Name = "login_AdminTextBox";
            this.login_AdminTextBox.Size = new System.Drawing.Size(192, 22);
            this.login_AdminTextBox.TabIndex = 11;
            // 
            // login_AdminLabel
            // 
            this.login_AdminLabel.AutoSize = true;
            this.login_AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_AdminLabel.Location = new System.Drawing.Point(27, 153);
            this.login_AdminLabel.Name = "login_AdminLabel";
            this.login_AdminLabel.Size = new System.Drawing.Size(260, 32);
            this.login_AdminLabel.TabIndex = 10;
            this.login_AdminLabel.Text = "Логин менеджера:";
            // 
            // hello_AdminLabel
            // 
            this.hello_AdminLabel.AutoSize = true;
            this.hello_AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hello_AdminLabel.Location = new System.Drawing.Point(103, 38);
            this.hello_AdminLabel.Name = "hello_AdminLabel";
            this.hello_AdminLabel.Size = new System.Drawing.Size(563, 38);
            this.hello_AdminLabel.TabIndex = 12;
            this.hello_AdminLabel.Text = "Добро пожаловать, Администратор";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(549, 111);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(212, 43);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // unlockButton
            // 
            this.unlockButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.unlockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unlockButton.Location = new System.Drawing.Point(549, 175);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(212, 43);
            this.unlockButton.TabIndex = 14;
            this.unlockButton.Text = "Разблокировать";
            this.unlockButton.UseVisualStyleBackColor = false;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(549, 238);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(212, 43);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(325, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 43);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // password_AdminTextBox
            // 
            this.password_AdminTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_AdminTextBox.Location = new System.Drawing.Point(325, 204);
            this.password_AdminTextBox.Name = "password_AdminTextBox";
            this.password_AdminTextBox.Size = new System.Drawing.Size(192, 22);
            this.password_AdminTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Пароль:";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_AdminTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.hello_AdminLabel);
            this.Controls.Add(this.login_AdminTextBox);
            this.Controls.Add(this.login_AdminLabel);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "adminForm";
            this.Text = "Управление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_AdminTextBox;
        private System.Windows.Forms.Label login_AdminLabel;
        private System.Windows.Forms.Label hello_AdminLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox password_AdminTextBox;
        private System.Windows.Forms.Label label1;
    }
}