namespace RobotSearch.Forms
{
    partial class ChangeKb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeKb));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label_AdminName = new System.Windows.Forms.ToolStripLabel();
            this.tb_AdminName = new System.Windows.Forms.ToolStripTextBox();
            this.splitbtn_ExitTO_adm = new System.Windows.Forms.ToolStripSplitButton();
            this.splitbtn_toAdminPanel_adm = new System.Windows.Forms.ToolStripMenuItem();
            this.splitbtn_toMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_AdminName,
            this.tb_AdminName,
            this.splitbtn_ExitTO_adm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label_AdminName
            // 
            this.label_AdminName.Name = "label_AdminName";
            this.label_AdminName.Size = new System.Drawing.Size(94, 22);
            this.label_AdminName.Text = "Администратор";
            // 
            // tb_AdminName
            // 
            this.tb_AdminName.Name = "tb_AdminName";
            this.tb_AdminName.Size = new System.Drawing.Size(100, 25);
            // 
            // splitbtn_ExitTO_adm
            // 
            this.splitbtn_ExitTO_adm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.splitbtn_ExitTO_adm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.splitbtn_ExitTO_adm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitbtn_toAdminPanel_adm,
            this.splitbtn_toMainMenu});
            this.splitbtn_ExitTO_adm.Image = ((System.Drawing.Image)(resources.GetObject("splitbtn_ExitTO_adm.Image")));
            this.splitbtn_ExitTO_adm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.splitbtn_ExitTO_adm.Name = "splitbtn_ExitTO_adm";
            this.splitbtn_ExitTO_adm.Size = new System.Drawing.Size(64, 22);
            this.splitbtn_ExitTO_adm.Text = "Выйти..";
            // 
            // splitbtn_toAdminPanel_adm
            // 
            this.splitbtn_toAdminPanel_adm.Name = "splitbtn_toAdminPanel_adm";
            this.splitbtn_toAdminPanel_adm.Size = new System.Drawing.Size(227, 22);
            this.splitbtn_toAdminPanel_adm.Text = "К панели Адиминистратора";
            this.splitbtn_toAdminPanel_adm.Click += new System.EventHandler(this.splitbtn_toAdminPanel_adm_Click);
            // 
            // splitbtn_toMainMenu
            // 
            this.splitbtn_toMainMenu.Name = "splitbtn_toMainMenu";
            this.splitbtn_toMainMenu.Size = new System.Drawing.Size(227, 22);
            this.splitbtn_toMainMenu.Text = "В меню входа в систему";
            this.splitbtn_toMainMenu.Click += new System.EventHandler(this.splitbtn_toMainMenu_Click);
            // 
            // ChangeKb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ChangeKb";
            this.Text = "Change KB";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel label_AdminName;
        private System.Windows.Forms.ToolStripTextBox tb_AdminName;
        private System.Windows.Forms.ToolStripSplitButton splitbtn_ExitTO_adm;
        private System.Windows.Forms.ToolStripMenuItem splitbtn_toAdminPanel_adm;
        private System.Windows.Forms.ToolStripMenuItem splitbtn_toMainMenu;
    }
}