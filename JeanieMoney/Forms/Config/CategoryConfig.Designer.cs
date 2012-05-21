namespace JeanieMoney.Forms.Config
{
    partial class CategoryConfig
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
            this.treeViewIncome = new System.Windows.Forms.TreeView();
            this.contextMenuStripCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxIncome = new System.Windows.Forms.GroupBox();
            this.buttonIncomeCancel = new System.Windows.Forms.Button();
            this.labelIncomeAbbr = new System.Windows.Forms.Label();
            this.textBoxIncomeAbbr = new System.Windows.Forms.TextBox();
            this.labelIncomeName = new System.Windows.Forms.Label();
            this.textBoxIncomeName = new System.Windows.Forms.TextBox();
            this.buttonIncomeOK = new System.Windows.Forms.Button();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageIncome = new System.Windows.Forms.TabPage();
            this.tabPageOutgoing = new System.Windows.Forms.TabPage();
            this.groupBoxOutgoing = new System.Windows.Forms.GroupBox();
            this.buttonOutgoingCancel = new System.Windows.Forms.Button();
            this.labelOutgoingAbbr = new System.Windows.Forms.Label();
            this.textBoxOutgoingAbbr = new System.Windows.Forms.TextBox();
            this.labelOutgoingName = new System.Windows.Forms.Label();
            this.textBoxOutgoingName = new System.Windows.Forms.TextBox();
            this.buttonOutgoingOK = new System.Windows.Forms.Button();
            this.treeViewOutgoing = new System.Windows.Forms.TreeView();
            this.contextMenuStripCategory.SuspendLayout();
            this.groupBoxIncome.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageIncome.SuspendLayout();
            this.tabPageOutgoing.SuspendLayout();
            this.groupBoxOutgoing.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewIncome
            // 
            this.treeViewIncome.AllowDrop = true;
            this.treeViewIncome.FullRowSelect = true;
            this.treeViewIncome.Location = new System.Drawing.Point(6, 11);
            this.treeViewIncome.Name = "treeViewIncome";
            this.treeViewIncome.ShowNodeToolTips = true;
            this.treeViewIncome.Size = new System.Drawing.Size(200, 272);
            this.treeViewIncome.TabIndex = 0;
            this.treeViewIncome.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewIncome.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewIncome_NodeMouseDoubleClick);
            this.treeViewIncome.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewIncome_DragDrop);
            this.treeViewIncome.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeViewIncome.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewIncome_DragOver);
            this.treeViewIncome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewIncome_MouseUp);
            // 
            // contextMenuStripCategory
            // 
            this.contextMenuStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemDelete});
            this.contextMenuStripCategory.Name = "contextMenuStripCategory";
            this.contextMenuStripCategory.Size = new System.Drawing.Size(153, 70);
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemNew.Text = "&New";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemDelete.Text = "&Delete";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // groupBoxIncome
            // 
            this.groupBoxIncome.Controls.Add(this.buttonIncomeCancel);
            this.groupBoxIncome.Controls.Add(this.labelIncomeAbbr);
            this.groupBoxIncome.Controls.Add(this.textBoxIncomeAbbr);
            this.groupBoxIncome.Controls.Add(this.labelIncomeName);
            this.groupBoxIncome.Controls.Add(this.textBoxIncomeName);
            this.groupBoxIncome.Controls.Add(this.buttonIncomeOK);
            this.groupBoxIncome.Location = new System.Drawing.Point(215, 7);
            this.groupBoxIncome.Name = "groupBoxIncome";
            this.groupBoxIncome.Size = new System.Drawing.Size(200, 126);
            this.groupBoxIncome.TabIndex = 2;
            this.groupBoxIncome.TabStop = false;
            this.groupBoxIncome.Visible = false;
            // 
            // buttonIncomeCancel
            // 
            this.buttonIncomeCancel.Location = new System.Drawing.Point(109, 85);
            this.buttonIncomeCancel.Name = "buttonIncomeCancel";
            this.buttonIncomeCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonIncomeCancel.TabIndex = 5;
            this.buttonIncomeCancel.Text = "Cancel";
            this.buttonIncomeCancel.UseVisualStyleBackColor = true;
            this.buttonIncomeCancel.Click += new System.EventHandler(this.buttonIncomeCancel_Click);
            // 
            // labelIncomeAbbr
            // 
            this.labelIncomeAbbr.AutoSize = true;
            this.labelIncomeAbbr.Location = new System.Drawing.Point(6, 52);
            this.labelIncomeAbbr.Name = "labelIncomeAbbr";
            this.labelIncomeAbbr.Size = new System.Drawing.Size(29, 13);
            this.labelIncomeAbbr.TabIndex = 4;
            this.labelIncomeAbbr.Text = "Abbr";
            // 
            // textBoxIncomeAbbr
            // 
            this.textBoxIncomeAbbr.Location = new System.Drawing.Point(41, 48);
            this.textBoxIncomeAbbr.Name = "textBoxIncomeAbbr";
            this.textBoxIncomeAbbr.Size = new System.Drawing.Size(144, 20);
            this.textBoxIncomeAbbr.TabIndex = 3;
            // 
            // labelIncomeName
            // 
            this.labelIncomeName.AutoSize = true;
            this.labelIncomeName.Location = new System.Drawing.Point(6, 22);
            this.labelIncomeName.Name = "labelIncomeName";
            this.labelIncomeName.Size = new System.Drawing.Size(35, 13);
            this.labelIncomeName.TabIndex = 2;
            this.labelIncomeName.Text = "Name";
            // 
            // textBoxIncomeName
            // 
            this.textBoxIncomeName.Location = new System.Drawing.Point(41, 20);
            this.textBoxIncomeName.Name = "textBoxIncomeName";
            this.textBoxIncomeName.Size = new System.Drawing.Size(144, 20);
            this.textBoxIncomeName.TabIndex = 1;
            // 
            // buttonIncomeOK
            // 
            this.buttonIncomeOK.Location = new System.Drawing.Point(16, 85);
            this.buttonIncomeOK.Name = "buttonIncomeOK";
            this.buttonIncomeOK.Size = new System.Drawing.Size(75, 23);
            this.buttonIncomeOK.TabIndex = 0;
            this.buttonIncomeOK.Text = "OK";
            this.buttonIncomeOK.UseVisualStyleBackColor = true;
            this.buttonIncomeOK.Click += new System.EventHandler(this.buttonIncomeOK_Click);
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 2000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(85, 341);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageIncome);
            this.tabControl.Controls.Add(this.tabPageOutgoing);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(222, 315);
            this.tabControl.TabIndex = 8;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageIncome
            // 
            this.tabPageIncome.Controls.Add(this.treeViewIncome);
            this.tabPageIncome.Controls.Add(this.groupBoxIncome);
            this.tabPageIncome.Location = new System.Drawing.Point(4, 22);
            this.tabPageIncome.Name = "tabPageIncome";
            this.tabPageIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncome.Size = new System.Drawing.Size(214, 289);
            this.tabPageIncome.TabIndex = 0;
            this.tabPageIncome.Text = "Income";
            this.tabPageIncome.UseVisualStyleBackColor = true;
            // 
            // tabPageOutgoing
            // 
            this.tabPageOutgoing.Controls.Add(this.groupBoxOutgoing);
            this.tabPageOutgoing.Controls.Add(this.treeViewOutgoing);
            this.tabPageOutgoing.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutgoing.Name = "tabPageOutgoing";
            this.tabPageOutgoing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutgoing.Size = new System.Drawing.Size(214, 289);
            this.tabPageOutgoing.TabIndex = 1;
            this.tabPageOutgoing.Text = "Outgoing";
            this.tabPageOutgoing.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutgoing
            // 
            this.groupBoxOutgoing.Controls.Add(this.buttonOutgoingCancel);
            this.groupBoxOutgoing.Controls.Add(this.labelOutgoingAbbr);
            this.groupBoxOutgoing.Controls.Add(this.textBoxOutgoingAbbr);
            this.groupBoxOutgoing.Controls.Add(this.labelOutgoingName);
            this.groupBoxOutgoing.Controls.Add(this.textBoxOutgoingName);
            this.groupBoxOutgoing.Controls.Add(this.buttonOutgoingOK);
            this.groupBoxOutgoing.Location = new System.Drawing.Point(215, 7);
            this.groupBoxOutgoing.Name = "groupBoxOutgoing";
            this.groupBoxOutgoing.Size = new System.Drawing.Size(200, 126);
            this.groupBoxOutgoing.TabIndex = 3;
            this.groupBoxOutgoing.TabStop = false;
            this.groupBoxOutgoing.Visible = false;
            // 
            // buttonOutgoingCancel
            // 
            this.buttonOutgoingCancel.Location = new System.Drawing.Point(109, 85);
            this.buttonOutgoingCancel.Name = "buttonOutgoingCancel";
            this.buttonOutgoingCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonOutgoingCancel.TabIndex = 5;
            this.buttonOutgoingCancel.Text = "Cancel";
            this.buttonOutgoingCancel.UseVisualStyleBackColor = true;
            this.buttonOutgoingCancel.Click += new System.EventHandler(this.buttonOutgoingCancel_Click);
            // 
            // labelOutgoingAbbr
            // 
            this.labelOutgoingAbbr.AutoSize = true;
            this.labelOutgoingAbbr.Location = new System.Drawing.Point(6, 52);
            this.labelOutgoingAbbr.Name = "labelOutgoingAbbr";
            this.labelOutgoingAbbr.Size = new System.Drawing.Size(29, 13);
            this.labelOutgoingAbbr.TabIndex = 4;
            this.labelOutgoingAbbr.Text = "Abbr";
            // 
            // textBoxOutgoingAbbr
            // 
            this.textBoxOutgoingAbbr.Location = new System.Drawing.Point(41, 48);
            this.textBoxOutgoingAbbr.Name = "textBoxOutgoingAbbr";
            this.textBoxOutgoingAbbr.Size = new System.Drawing.Size(144, 20);
            this.textBoxOutgoingAbbr.TabIndex = 3;
            // 
            // labelOutgoingName
            // 
            this.labelOutgoingName.AutoSize = true;
            this.labelOutgoingName.Location = new System.Drawing.Point(6, 22);
            this.labelOutgoingName.Name = "labelOutgoingName";
            this.labelOutgoingName.Size = new System.Drawing.Size(35, 13);
            this.labelOutgoingName.TabIndex = 2;
            this.labelOutgoingName.Text = "Name";
            // 
            // textBoxOutgoingName
            // 
            this.textBoxOutgoingName.Location = new System.Drawing.Point(41, 20);
            this.textBoxOutgoingName.Name = "textBoxOutgoingName";
            this.textBoxOutgoingName.Size = new System.Drawing.Size(144, 20);
            this.textBoxOutgoingName.TabIndex = 1;
            // 
            // buttonOutgoingOK
            // 
            this.buttonOutgoingOK.Location = new System.Drawing.Point(16, 85);
            this.buttonOutgoingOK.Name = "buttonOutgoingOK";
            this.buttonOutgoingOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOutgoingOK.TabIndex = 0;
            this.buttonOutgoingOK.Text = "OK";
            this.buttonOutgoingOK.UseVisualStyleBackColor = true;
            this.buttonOutgoingOK.Click += new System.EventHandler(this.buttonOutgoingOK_Click);
            // 
            // treeViewOutgoing
            // 
            this.treeViewOutgoing.AllowDrop = true;
            this.treeViewOutgoing.Location = new System.Drawing.Point(6, 11);
            this.treeViewOutgoing.Name = "treeViewOutgoing";
            this.treeViewOutgoing.ShowNodeToolTips = true;
            this.treeViewOutgoing.Size = new System.Drawing.Size(200, 272);
            this.treeViewOutgoing.TabIndex = 1;
            this.treeViewOutgoing.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewOutgoing.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewOutgoing_NodeMouseDoubleClick);
            this.treeViewOutgoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewOutgoing_DragDrop);
            this.treeViewOutgoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeViewOutgoing.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewOutgoing_DragOver);
            this.treeViewOutgoing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewOutgoing_MouseUp);
            // 
            // CategoryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 376);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category";
            this.contextMenuStripCategory.ResumeLayout(false);
            this.groupBoxIncome.ResumeLayout(false);
            this.groupBoxIncome.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageIncome.ResumeLayout(false);
            this.tabPageOutgoing.ResumeLayout(false);
            this.groupBoxOutgoing.ResumeLayout(false);
            this.groupBoxOutgoing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewIncome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCategory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.GroupBox groupBoxIncome;
        private System.Windows.Forms.Button buttonIncomeCancel;
        private System.Windows.Forms.Label labelIncomeAbbr;
        private System.Windows.Forms.TextBox textBoxIncomeAbbr;
        private System.Windows.Forms.Label labelIncomeName;
        private System.Windows.Forms.TextBox textBoxIncomeName;
        private System.Windows.Forms.Button buttonIncomeOK;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageIncome;
        private System.Windows.Forms.TabPage tabPageOutgoing;
        private System.Windows.Forms.GroupBox groupBoxOutgoing;
        private System.Windows.Forms.Button buttonOutgoingCancel;
        private System.Windows.Forms.Label labelOutgoingAbbr;
        private System.Windows.Forms.TextBox textBoxOutgoingAbbr;
        private System.Windows.Forms.Label labelOutgoingName;
        private System.Windows.Forms.TextBox textBoxOutgoingName;
        private System.Windows.Forms.Button buttonOutgoingOK;
        private System.Windows.Forms.TreeView treeViewOutgoing;
    }
}