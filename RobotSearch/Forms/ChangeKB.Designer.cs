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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeKb));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label_AdminName = new System.Windows.Forms.ToolStripLabel();
            this.tb_AdminName = new System.Windows.Forms.ToolStripTextBox();
            this.splitbtn_ExitTO_adm = new System.Windows.Forms.ToolStripSplitButton();
            this.splitbtn_toAdminPanel_adm = new System.Windows.Forms.ToolStripMenuItem();
            this.splitbtn_toMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.robotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.robot_search_dbDataSet = new RobotSearch.robot_search_dbDataSet();
            this.robotsearchdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.robot_search_dbDataSet1 = new RobotSearch.robot_search_dbDataSet1();
            this.robotsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.robotsTableAdapter = new RobotSearch.robot_search_dbDataSet1TableAdapters.robotsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot_search_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotsearchdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot_search_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotsBindingSource1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1277, 25);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView1.DataSource = this.robotsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1252, 473);
            this.dataGridView1.TabIndex = 2;
            // 
            // robotsBindingSource
            // 
            this.robotsBindingSource.DataMember = "robots";
            // 
            // robot_search_dbDataSet
            // 
            this.robot_search_dbDataSet.DataSetName = "robot_search_dbDataSet";
            this.robot_search_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robotsearchdbDataSetBindingSource
            // 
            this.robotsearchdbDataSetBindingSource.DataSource = this.robot_search_dbDataSet;
            this.robotsearchdbDataSetBindingSource.Position = 0;
            // 
            // robot_search_dbDataSet1
            // 
            this.robot_search_dbDataSet1.DataSetName = "robot_search_dbDataSet1";
            this.robot_search_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robotsBindingSource1
            // 
            this.robotsBindingSource1.DataMember = "robots";
            this.robotsBindingSource1.DataSource = this.robot_search_dbDataSet1;
            // 
            // robotsTableAdapter
            // 
            this.robotsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "robots_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "robots_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "robots_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "robots_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "robots_method_of_piloting";
            this.dataGridViewTextBoxColumn3.HeaderText = "robots_method_of_piloting";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "robots_bobber";
            this.dataGridViewTextBoxColumn4.HeaderText = "robots_bobber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "robots_depth";
            this.dataGridViewTextBoxColumn5.HeaderText = "robots_depth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "robots_dive_method";
            this.dataGridViewTextBoxColumn6.HeaderText = "robots_dive_method";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "robots_exit_to_water";
            this.dataGridViewTextBoxColumn7.HeaderText = "robots_exit_to_water";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "robots_cameras_from";
            this.dataGridViewTextBoxColumn8.HeaderText = "robots_cameras_from";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "robots_cameras_to";
            this.dataGridViewTextBoxColumn9.HeaderText = "robots_cameras_to";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "robots_illums";
            this.dataGridViewTextBoxColumn10.HeaderText = "robots_illums";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "robots_conn_with_surface";
            this.dataGridViewTextBoxColumn11.HeaderText = "robots_conn_with_surface";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "robots_capacity_from";
            this.dataGridViewTextBoxColumn12.HeaderText = "robots_capacity_from";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "robots_capacity_to";
            this.dataGridViewTextBoxColumn13.HeaderText = "robots_capacity_to";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // ChangeKb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ChangeKb";
            this.Text = "Change KB";
            this.Load += new System.EventHandler(this.ChangeKb_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot_search_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotsearchdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot_search_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotsBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource robotsearchdbDataSetBindingSource;
        private robot_search_dbDataSet robot_search_dbDataSet;
        private System.Windows.Forms.BindingSource robotsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsmethodofpilotingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsbobberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsdepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsdivemethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsexittowaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotscamerasfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotscamerastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsillumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotsconnwithsurfaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotscapacityfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robotscapacitytoDataGridViewTextBoxColumn;
        private robot_search_dbDataSet1 robot_search_dbDataSet1;
        private System.Windows.Forms.BindingSource robotsBindingSource1;
        private robot_search_dbDataSet1TableAdapters.robotsTableAdapter robotsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}