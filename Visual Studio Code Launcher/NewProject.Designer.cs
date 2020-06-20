namespace Visual_Studio_Code_Launcher
{
    partial class NewProject
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
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Electron JS",
            "Cross Platform JS Application"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Java Application",
            "Cross Platform Application with Java"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Empty Swift Project",
            "Project with Swift scripts"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Vue JS",
            "Web Application"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            ".NET Core Application",
            ".NET Core Console Application"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Standard Webpage",
            "Webpage project with HTML, CSS and JS"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Empty Javascript Project",
            "Project with JS scripts"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Empty C# Project",
            "Project with C# scripts"}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Symfony Project",
            "Symfony PHP Application"}, -1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "Python Project",
            "Cross Platform Project with Python scripts"}, -1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "PHP Project",
            "PHP Project with PHP scripts"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.projectsNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectDescriptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projects = new MaterialSkin.Controls.MaterialListView();
            this.newProjectBtn = new MaterialSkin.Controls.MaterialButton();
            this.vscodeLocationBtn = new MaterialSkin.Controls.MaterialButton();
            this.scrollBar = new System.Windows.Forms.VScrollBar();
            this.projPanel = new System.Windows.Forms.Panel();
            this.rightClickMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.consoleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projPanel.SuspendLayout();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectsNames
            // 
            this.projectsNames.Text = "Project";
            this.projectsNames.Width = 200;
            // 
            // projectDescriptions
            // 
            this.projectDescriptions.Text = "Project Descriptions";
            this.projectDescriptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.projectDescriptions.Width = 300;
            // 
            // projects
            // 
            this.projects.AutoSizeTable = false;
            this.projects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.projects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectsNames,
            this.projectDescriptions});
            this.projects.Depth = 0;
            this.projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projects.FullRowSelect = true;
            this.projects.HideSelection = false;
            this.projects.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22});
            this.projects.Location = new System.Drawing.Point(3, 3);
            this.projects.MinimumSize = new System.Drawing.Size(200, 100);
            this.projects.MouseLocation = new System.Drawing.Point(-1, -1);
            this.projects.MouseState = MaterialSkin.MouseState.OUT;
            this.projects.Name = "projects";
            this.projects.OwnerDraw = true;
            this.projects.Size = new System.Drawing.Size(523, 547);
            this.projects.TabIndex = 0;
            this.projects.UseCompatibleStateImageBehavior = false;
            this.projects.View = System.Windows.Forms.View.Details;
            this.projects.SelectedIndexChanged += new System.EventHandler(this.projects_SelectedIndexChanged);
            this.projects.Leave += new System.EventHandler(this.projects_Leave);
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProjectBtn.AutoSize = false;
            this.newProjectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newProjectBtn.Depth = 0;
            this.newProjectBtn.DrawShadows = true;
            this.newProjectBtn.HighEmphasis = true;
            this.newProjectBtn.Icon = null;
            this.newProjectBtn.Location = new System.Drawing.Point(191, 622);
            this.newProjectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newProjectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(126, 36);
            this.newProjectBtn.TabIndex = 1;
            this.newProjectBtn.Text = "New Project";
            this.newProjectBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newProjectBtn.UseAccentColor = false;
            this.newProjectBtn.UseVisualStyleBackColor = true;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // vscodeLocationBtn
            // 
            this.vscodeLocationBtn.AutoSize = false;
            this.vscodeLocationBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vscodeLocationBtn.Depth = 0;
            this.vscodeLocationBtn.DrawShadows = true;
            this.vscodeLocationBtn.HighEmphasis = true;
            this.vscodeLocationBtn.Icon = null;
            this.vscodeLocationBtn.Location = new System.Drawing.Point(312, 31);
            this.vscodeLocationBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vscodeLocationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.vscodeLocationBtn.Name = "vscodeLocationBtn";
            this.vscodeLocationBtn.Size = new System.Drawing.Size(178, 23);
            this.vscodeLocationBtn.TabIndex = 2;
            this.vscodeLocationBtn.Text = "Set VSCode Location";
            this.vscodeLocationBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.vscodeLocationBtn.UseAccentColor = false;
            this.vscodeLocationBtn.UseVisualStyleBackColor = true;
            this.vscodeLocationBtn.Click += new System.EventHandler(this.vscodeLocationBtn_Click);
            // 
            // scrollBar
            // 
            this.scrollBar.Location = new System.Drawing.Point(482, 66);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(21, 547);
            this.scrollBar.TabIndex = 3;
            // 
            // projPanel
            // 
            this.projPanel.Controls.Add(this.projects);
            this.projPanel.Location = new System.Drawing.Point(0, 63);
            this.projPanel.Name = "projPanel";
            this.projPanel.Size = new System.Drawing.Size(503, 550);
            this.projPanel.TabIndex = 4;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rightClickMenu.Depth = 0;
            this.rightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleModeToolStripMenuItem,
            this.openProjectToolStripMenuItem});
            this.rightClickMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(211, 80);
            // 
            // consoleModeToolStripMenuItem
            // 
            this.consoleModeToolStripMenuItem.Name = "consoleModeToolStripMenuItem";
            this.consoleModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F11)));
            this.consoleModeToolStripMenuItem.ShowShortcutKeys = false;
            this.consoleModeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.consoleModeToolStripMenuItem.Text = "Console Mode";
            this.consoleModeToolStripMenuItem.Click += new System.EventHandler(this.consoleModeToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.ShowShortcutKeys = false;
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(503, 673);
            this.Controls.Add(this.projPanel);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.vscodeLocationBtn);
            this.Controls.Add(this.newProjectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewProject";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VS Code Launcher";
            this.Shown += new System.EventHandler(this.NewProject_Shown);
            this.Enter += new System.EventHandler(this.NewProject_Enter);
            this.projPanel.ResumeLayout(false);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader projectsNames;
        private System.Windows.Forms.ColumnHeader projectDescriptions;
        private MaterialSkin.Controls.MaterialListView projects;
        private MaterialSkin.Controls.MaterialButton newProjectBtn;
        private MaterialSkin.Controls.MaterialButton vscodeLocationBtn;
        private System.Windows.Forms.VScrollBar scrollBar;
        private System.Windows.Forms.Panel projPanel;
        private MaterialSkin.Controls.MaterialContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem consoleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
    }
}

