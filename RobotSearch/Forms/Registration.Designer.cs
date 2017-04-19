namespace RobotSearch.Forms
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reg = new System.Windows.Forms.Button();
            this.tb_UserPassw_auth = new System.Windows.Forms.TextBox();
            this.tb_UserName_auth = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripbtn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_reg);
            this.groupBox1.Controls.Add(this.tb_UserPassw_auth);
            this.groupBox1.Controls.Add(this.tb_UserName_auth);
            this.groupBox1.Location = new System.Drawing.Point(34, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные для регистрации";
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(237, 45);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(85, 62);
            this.button_reg.TabIndex = 2;
            this.button_reg.Text = "Регистрация";
            this.button_reg.UseVisualStyleBackColor = true;
            // 
            // tb_UserPassw_auth
            // 
            this.tb_UserPassw_auth.Location = new System.Drawing.Point(16, 87);
            this.tb_UserPassw_auth.Name = "tb_UserPassw_auth";
            this.tb_UserPassw_auth.Size = new System.Drawing.Size(215, 20);
            this.tb_UserPassw_auth.TabIndex = 1;
            this.tb_UserPassw_auth.Text = "Введите пароль";
            // 
            // tb_UserName_auth
            // 
            this.tb_UserName_auth.Location = new System.Drawing.Point(16, 45);
            this.tb_UserName_auth.Name = "tb_UserName_auth";
            this.tb_UserName_auth.Size = new System.Drawing.Size(215, 20);
            this.tb_UserName_auth.TabIndex = 0;
            this.tb_UserName_auth.Text = "Введите логин";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripbtn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.stripbtn_Exit.Click += new System.EventHandler(this.stripbtn_Exit_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 335);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox tb_UserPassw_auth;
        private System.Windows.Forms.TextBox tb_UserName_auth;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripbtn_Exit;
    }
}