namespace fitness_center
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_dataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.clients_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickets_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groups_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_dataGridView)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.info_dataGridView);
            this.panel1.Location = new System.Drawing.Point(29, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 326);
            this.panel1.TabIndex = 3;
            // 
            // info_dataGridView
            // 
            this.info_dataGridView.AllowDrop = true;
            this.info_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.info_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.info_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.info_dataGridView.Name = "info_dataGridView";
            this.info_dataGridView.RowHeadersWidth = 51;
            this.info_dataGridView.RowTemplate.Height = 24;
            this.info_dataGridView.Size = new System.Drawing.Size(748, 289);
            this.info_dataGridView.TabIndex = 4;
            this.info_dataGridView.Visible = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Bisque;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clients_ToolStripMenuItem,
            this.tickets_ToolStripMenuItem,
            this.groups_ToolStripMenuItem,
            this.settings_ToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 56);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // clients_ToolStripMenuItem
            // 
            this.clients_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.clients_ToolStripMenuItem.Name = "clients_ToolStripMenuItem";
            this.clients_ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.clients_ToolStripMenuItem.Size = new System.Drawing.Size(113, 32);
            this.clients_ToolStripMenuItem.Text = "Клиенты";
            this.clients_ToolStripMenuItem.Click += new System.EventHandler(this.clients_ToolStripMenuItem_Click);
            // 
            // tickets_ToolStripMenuItem
            // 
            this.tickets_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tickets_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tickets_ToolStripMenuItem.Name = "tickets_ToolStripMenuItem";
            this.tickets_ToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.tickets_ToolStripMenuItem.Text = "Абонементы";
            this.tickets_ToolStripMenuItem.Click += new System.EventHandler(this.tickets_ToolStripMenuItem_Click);
            // 
            // groups_ToolStripMenuItem
            // 
            this.groups_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groups_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.groups_ToolStripMenuItem.Name = "groups_ToolStripMenuItem";
            this.groups_ToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.groups_ToolStripMenuItem.Text = "Групповые тренировки";
            this.groups_ToolStripMenuItem.Click += new System.EventHandler(this.groups_ToolStripMenuItem_Click);
            // 
            // settings_ToolStripMenuItem
            // 
            this.settings_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_ToolStripMenuItem,
            this.change_ToolStripMenuItem});
            this.settings_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.settings_ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(45, 10, 0, 10);
            this.settings_ToolStripMenuItem.Name = "settings_ToolStripMenuItem";
            this.settings_ToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.settings_ToolStripMenuItem.Text = "Настройки";
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(307, 32);
            this.exit_ToolStripMenuItem.Text = "Выйти";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // change_ToolStripMenuItem
            // 
            this.change_ToolStripMenuItem.Name = "change_ToolStripMenuItem";
            this.change_ToolStripMenuItem.Size = new System.Drawing.Size(307, 32);
            this.change_ToolStripMenuItem.Text = "Сменить пользователя";
            this.change_ToolStripMenuItem.Click += new System.EventHandler(this.change_ToolStripMenuItem_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 295);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(211, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(258, 295);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(211, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(516, 295);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(211, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "mainForm";
            this.Text = "Фитнес-центр";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.info_dataGridView)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem clients_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickets_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groups_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView info_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem change_ToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}