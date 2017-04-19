namespace RobotSearch.Forms
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_auth = new System.Windows.Forms.Button();
            this.tb_UserPassw_auth = new System.Windows.Forms.TextBox();
            this.tb_UserName_auth = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_auth);
            this.groupBox1.Controls.Add(this.tb_UserPassw_auth);
            this.groupBox1.Controls.Add(this.tb_UserName_auth);
            this.groupBox1.Location = new System.Drawing.Point(36, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизуйтесь";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(193, 125);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(109, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Зарегистрируйтесь!";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы здесь впервые?";
            // 
            // button_auth
            // 
            this.button_auth.Location = new System.Drawing.Point(237, 45);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(73, 62);
            this.button_auth.TabIndex = 2;
            this.button_auth.Text = "Войти";
            this.button_auth.UseVisualStyleBackColor = true;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
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
            this.tb_UserName_auth.TextChanged += new System.EventHandler(this.tb_UserName_auth_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.TextBox tb_UserPassw_auth;
        private System.Windows.Forms.TextBox tb_UserName_auth;
    }
}