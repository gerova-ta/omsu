namespace fitness_center
{
    partial class authorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_button = new System.Windows.Forms.Button();
            this.enter_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password_Label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.login_Label = new System.Windows.Forms.Label();
            this.enter_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.PapayaWhip;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(51, 347);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(118, 40);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.Location = new System.Drawing.Point(225, 333);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(192, 54);
            this.enter_button.TabIndex = 12;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_textBox.Location = new System.Drawing.Point(225, 242);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(153, 22);
            this.password_textBox.TabIndex = 11;
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_Label.Location = new System.Drawing.Point(67, 235);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(102, 29);
            this.password_Label.TabIndex = 10;
            this.password_Label.Text = "Пароль:";
            // 
            // login_textBox
            // 
            this.login_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_textBox.Location = new System.Drawing.Point(225, 182);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(153, 22);
            this.login_textBox.TabIndex = 9;
            // 
            // login_Label
            // 
            this.login_Label.AutoSize = true;
            this.login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_Label.Location = new System.Drawing.Point(81, 175);
            this.login_Label.Name = "login_Label";
            this.login_Label.Size = new System.Drawing.Size(88, 29);
            this.login_Label.TabIndex = 8;
            this.login_Label.Text = "Логин:";
            // 
            // enter_label
            // 
            this.enter_label.AutoSize = true;
            this.enter_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_label.Location = new System.Drawing.Point(160, 67);
            this.enter_label.Name = "enter_label";
            this.enter_label.Size = new System.Drawing.Size(131, 54);
            this.enter_label.TabIndex = 7;
            this.enter_label.Text = "Вход";
            // 
            // authorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.login_Label);
            this.Controls.Add(this.enter_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "authorizationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label login_Label;
        private System.Windows.Forms.Label enter_label;
    }
}

