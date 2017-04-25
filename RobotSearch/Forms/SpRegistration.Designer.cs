namespace RobotSearch.Forms
{
    partial class SpRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpRegistration));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_regAdm = new System.Windows.Forms.Button();
            this.tb_UserPassw_regAdm = new System.Windows.Forms.TextBox();
            this.tb_UserName_regAdm = new System.Windows.Forms.TextBox();
            this.checkBox_regAdmin = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripbtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(520, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stripbtn_Exit
            // 
            this.stripbtn_Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stripbtn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripbtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("stripbtn_Exit.Image")));
            this.stripbtn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripbtn_Exit.Name = "stripbtn_Exit";
            this.stripbtn_Exit.Size = new System.Drawing.Size(136, 22);
            this.stripbtn_Exit.Text = "Выход в главное меню";
            this.stripbtn_Exit.Click += new System.EventHandler(this.stripbtn_Exit_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_regAdmin);
            this.groupBox1.Controls.Add(this.button_regAdm);
            this.groupBox1.Controls.Add(this.tb_UserPassw_regAdm);
            this.groupBox1.Controls.Add(this.tb_UserName_regAdm);
            this.groupBox1.Location = new System.Drawing.Point(94, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные для регистрации";
            // 
            // button_regAdm
            // 
            this.button_regAdm.Location = new System.Drawing.Point(247, 65);
            this.button_regAdm.Name = "button_regAdm";
            this.button_regAdm.Size = new System.Drawing.Size(85, 62);
            this.button_regAdm.TabIndex = 2;
            this.button_regAdm.Text = "Регистрация";
            this.button_regAdm.UseVisualStyleBackColor = true;
            this.button_regAdm.Click += new System.EventHandler(this.button_regAdm_Click_1);
            // 
            // tb_UserPassw_regAdm
            // 
            this.tb_UserPassw_regAdm.Location = new System.Drawing.Point(16, 87);
            this.tb_UserPassw_regAdm.Name = "tb_UserPassw_regAdm";
            this.tb_UserPassw_regAdm.Size = new System.Drawing.Size(215, 20);
            this.tb_UserPassw_regAdm.TabIndex = 1;
            this.tb_UserPassw_regAdm.Text = "Введите пароль";
            // 
            // tb_UserName_regAdm
            // 
            this.tb_UserName_regAdm.Location = new System.Drawing.Point(16, 45);
            this.tb_UserName_regAdm.Name = "tb_UserName_regAdm";
            this.tb_UserName_regAdm.Size = new System.Drawing.Size(215, 20);
            this.tb_UserName_regAdm.TabIndex = 0;
            this.tb_UserName_regAdm.Text = "Введите логин";
            // 
            // checkBox_regAdmin
            // 
            this.checkBox_regAdmin.AutoSize = true;
            this.checkBox_regAdmin.Location = new System.Drawing.Point(16, 124);
            this.checkBox_regAdmin.Name = "checkBox_regAdmin";
            this.checkBox_regAdmin.Size = new System.Drawing.Size(105, 17);
            this.checkBox_regAdmin.TabIndex = 3;
            this.checkBox_regAdmin.Text = "Администратор";
            this.checkBox_regAdmin.UseVisualStyleBackColor = true;
            this.checkBox_regAdmin.CheckedChanged += new System.EventHandler(this.checkBox_regAdmin_CheckedChanged);
            // 
            // SpRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SpRegistration";
            this.Text = "SpRegistration";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripbtn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_regAdmin;
        private System.Windows.Forms.Button button_regAdm;
        private System.Windows.Forms.TextBox tb_UserPassw_regAdm;
        private System.Windows.Forms.TextBox tb_UserName_regAdm;
    }
}