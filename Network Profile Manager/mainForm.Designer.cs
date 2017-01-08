namespace Network_Profile_Manager {
	partial class mainForm {
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.mod_container = new System.Windows.Forms.Panel();
			this.btn_save = new System.Windows.Forms.Button();
			this.chkb_Managed = new System.Windows.Forms.CheckBox();
			this.cb_Category = new System.Windows.Forms.ComboBox();
			this.tb_profileDescription = new System.Windows.Forms.TextBox();
			this.tb_profilenName = new System.Windows.Forms.TextBox();
			this.profile_list = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.profileList_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu.SuspendLayout();
			this.mod_container.SuspendLayout();
			this.profileList_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(720, 24);
			this.mainMenu.TabIndex = 0;
			// 
			// applicationToolStripMenuItem
			// 
			this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.updateToolStripMenuItem});
			this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
			this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.applicationToolStripMenuItem.Text = "Application";
			// 
			// gitHubToolStripMenuItem
			// 
			this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
			this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.gitHubToolStripMenuItem.Text = "GitHub";
			this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 383);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(720, 22);
			this.statusBar.TabIndex = 1;
			this.statusBar.Text = "statusStrip1";
			// 
			// mod_container
			// 
			this.mod_container.AutoSize = true;
			this.mod_container.Controls.Add(this.btn_save);
			this.mod_container.Controls.Add(this.chkb_Managed);
			this.mod_container.Controls.Add(this.cb_Category);
			this.mod_container.Controls.Add(this.tb_profileDescription);
			this.mod_container.Controls.Add(this.tb_profilenName);
			this.mod_container.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mod_container.Enabled = false;
			this.mod_container.Location = new System.Drawing.Point(0, 354);
			this.mod_container.Name = "mod_container";
			this.mod_container.Size = new System.Drawing.Size(720, 29);
			this.mod_container.TabIndex = 2;
			// 
			// btn_save
			// 
			this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_save.Location = new System.Drawing.Point(607, 3);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(110, 23);
			this.btn_save.TabIndex = 4;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// chkb_Managed
			// 
			this.chkb_Managed.AutoSize = true;
			this.chkb_Managed.Checked = true;
			this.chkb_Managed.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.chkb_Managed.Enabled = false;
			this.chkb_Managed.Location = new System.Drawing.Point(530, 7);
			this.chkb_Managed.Name = "chkb_Managed";
			this.chkb_Managed.Size = new System.Drawing.Size(71, 17);
			this.chkb_Managed.TabIndex = 3;
			this.chkb_Managed.Text = "Managed";
			this.chkb_Managed.UseVisualStyleBackColor = true;
			// 
			// cb_Category
			// 
			this.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Category.FormattingEnabled = true;
			this.cb_Category.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Domain"});
			this.cb_Category.Location = new System.Drawing.Point(424, 5);
			this.cb_Category.Name = "cb_Category";
			this.cb_Category.Size = new System.Drawing.Size(100, 21);
			this.cb_Category.TabIndex = 2;
			// 
			// tb_profileDescription
			// 
			this.tb_profileDescription.Location = new System.Drawing.Point(168, 5);
			this.tb_profileDescription.Name = "tb_profileDescription";
			this.tb_profileDescription.Size = new System.Drawing.Size(250, 20);
			this.tb_profileDescription.TabIndex = 1;
			// 
			// tb_profilenName
			// 
			this.tb_profilenName.Location = new System.Drawing.Point(12, 5);
			this.tb_profilenName.Name = "tb_profilenName";
			this.tb_profilenName.Size = new System.Drawing.Size(150, 20);
			this.tb_profilenName.TabIndex = 0;
			// 
			// profile_list
			// 
			this.profile_list.AllowColumnReorder = true;
			this.profile_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.profile_list.CheckBoxes = true;
			this.profile_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.profile_list.ContextMenuStrip = this.profileList_menu;
			this.profile_list.Dock = System.Windows.Forms.DockStyle.Fill;
			this.profile_list.FullRowSelect = true;
			this.profile_list.GridLines = true;
			this.profile_list.HideSelection = false;
			this.profile_list.Location = new System.Drawing.Point(0, 24);
			this.profile_list.MultiSelect = false;
			this.profile_list.Name = "profile_list";
			this.profile_list.Size = new System.Drawing.Size(720, 330);
			this.profile_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.profile_list.TabIndex = 3;
			this.profile_list.UseCompatibleStateImageBehavior = false;
			this.profile_list.View = System.Windows.Forms.View.Details;
			this.profile_list.SelectedIndexChanged += new System.EventHandler(this.profile_list_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Description";
			this.columnHeader2.Width = 225;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Category";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Managed";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "GUID";
			this.columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Signature SubKey";
			this.columnHeader6.Width = 100;
			// 
			// profileList_menu
			// 
			this.profileList_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem,
            this.deleteCheckedToolStripMenuItem});
			this.profileList_menu.Name = "contextMenuStrip1";
			this.profileList_menu.Size = new System.Drawing.Size(157, 48);
			// 
			// deleteSelectedToolStripMenuItem
			// 
			this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
			this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
			this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
			// 
			// deleteCheckedToolStripMenuItem
			// 
			this.deleteCheckedToolStripMenuItem.Name = "deleteCheckedToolStripMenuItem";
			this.deleteCheckedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.deleteCheckedToolStripMenuItem.Text = "Delete Checked";
			this.deleteCheckedToolStripMenuItem.Click += new System.EventHandler(this.deleteCheckedToolStripMenuItem_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 405);
			this.Controls.Add(this.profile_list);
			this.Controls.Add(this.mod_container);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Network Profile Manager";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.mod_container.ResumeLayout(false);
			this.mod_container.PerformLayout();
			this.profileList_menu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.Panel mod_container;
		private System.Windows.Forms.ListView profile_list;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.CheckBox chkb_Managed;
		private System.Windows.Forms.ComboBox cb_Category;
		private System.Windows.Forms.TextBox tb_profileDescription;
		private System.Windows.Forms.TextBox tb_profilenName;
		private System.Windows.Forms.ContextMenuStrip profileList_menu;
		private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteCheckedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

