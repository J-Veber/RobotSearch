namespace RobotSearch.Forms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.button_changeKB_adm = new System.Windows.Forms.Button();
            this.button_createNewUsr_adm = new System.Windows.Forms.Button();
            this.toolStrip_admPanel = new System.Windows.Forms.ToolStrip();
            this.admin = new System.Windows.Forms.ToolStripLabel();
            this.button_Exit_adm = new System.Windows.Forms.ToolStripButton();
            this.tb_AdminName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip_admPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_changeKB_adm
            // 
            this.button_changeKB_adm.Location = new System.Drawing.Point(125, 156);
            this.button_changeKB_adm.Name = "button_changeKB_adm";
            this.button_changeKB_adm.Size = new System.Drawing.Size(178, 23);
            this.button_changeKB_adm.TabIndex = 0;
            this.button_changeKB_adm.Text = "Изменить Базу Знаний";
            this.button_changeKB_adm.UseVisualStyleBackColor = true;
            this.button_changeKB_adm.Click += new System.EventHandler(this.button_changeKB_adm_Click);
            // 
            // button_createNewUsr_adm
            // 
            this.button_createNewUsr_adm.Location = new System.Drawing.Point(125, 240);
            this.button_createNewUsr_adm.Name = "button_createNewUsr_adm";
            this.button_createNewUsr_adm.Size = new System.Drawing.Size(178, 23);
            this.button_createNewUsr_adm.TabIndex = 1;
            this.button_createNewUsr_adm.Text = "Создать нового пользователя";
            this.button_createNewUsr_adm.UseVisualStyleBackColor = true;
            this.button_createNewUsr_adm.Click += new System.EventHandler(this.button_createNewUsr_adm_Click);
            // 
            // toolStrip_admPanel
            // 
            this.toolStrip_admPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin,
            this.button_Exit_adm,
            this.tb_AdminName});
            this.toolStrip_admPanel.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_admPanel.Name = "toolStrip_admPanel";
            this.toolStrip_admPanel.Size = new System.Drawing.Size(432, 25);
            this.toolStrip_admPanel.TabIndex = 2;
            this.toolStrip_admPanel.Text = "Панель администратора";
            // 
            // admin
            // 
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(94, 22);
            this.admin.Text = "Администратор";
            // 
            // button_Exit_adm
            // 
            this.button_Exit_adm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_Exit_adm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_Exit_adm.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit_adm.Image")));
            this.button_Exit_adm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_Exit_adm.Name = "button_Exit_adm";
            this.button_Exit_adm.Size = new System.Drawing.Size(46, 22);
            this.button_Exit_adm.Text = "Выйти";
            this.button_Exit_adm.Click += new System.EventHandler(this.button_Exit_adm_Click);
            // 
            // tb_AdminName
            // 
            this.tb_AdminName.Name = "tb_AdminName";
            this.tb_AdminName.Size = new System.Drawing.Size(100, 25);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(432, 400);
            this.Controls.Add(this.toolStrip_admPanel);
            this.Controls.Add(this.button_createNewUsr_adm);
            this.Controls.Add(this.button_changeKB_adm);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.toolStrip_admPanel.ResumeLayout(false);
            this.toolStrip_admPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_changeKB_adm;
        private System.Windows.Forms.Button button_createNewUsr_adm;
        private System.Windows.Forms.ToolStrip toolStrip_admPanel;
        private System.Windows.Forms.ToolStripLabel admin;
        private System.Windows.Forms.ToolStripButton button_Exit_adm;
        private System.Windows.Forms.ToolStripTextBox tb_AdminName;
    }
}

