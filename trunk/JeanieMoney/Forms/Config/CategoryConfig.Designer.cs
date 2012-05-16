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
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.contextMenuStripCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.groupBoxInOrOut = new System.Windows.Forms.GroupBox();
            this.radioButtonOutgoing = new System.Windows.Forms.RadioButton();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.buttonGroupCancel = new System.Windows.Forms.Button();
            this.labelAbbr = new System.Windows.Forms.Label();
            this.textBoxAbbr = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGroupOK = new System.Windows.Forms.Button();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.contextMenuStripCategory.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxInOrOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.AllowDrop = true;
            this.treeViewCategory.Location = new System.Drawing.Point(12, 13);
            this.treeViewCategory.Name = "treeViewCategory";
            this.treeViewCategory.ShowNodeToolTips = true;
            this.treeViewCategory.Size = new System.Drawing.Size(187, 324);
            this.treeViewCategory.TabIndex = 0;
            this.treeViewCategory.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewCategory_ItemDrag);
            this.treeViewCategory.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewCategory_DragDrop);
            this.treeViewCategory.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewCategory_DragEnter);
            this.treeViewCategory.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewCategory_DragOver);
            this.treeViewCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewCategory_MouseDown);
            // 
            // contextMenuStripCategory
            // 
            this.contextMenuStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemModify,
            this.toolStripMenuItemDelete});
            this.contextMenuStripCategory.Name = "contextMenuStripCategory";
            this.contextMenuStripCategory.Size = new System.Drawing.Size(107, 70);
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItemNew.Text = "&New";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // toolStripMenuItemModify
            // 
            this.toolStripMenuItemModify.Name = "toolStripMenuItemModify";
            this.toolStripMenuItemModify.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItemModify.Text = "&Modify";
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItemDelete.Text = "&Delete";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.groupBoxInOrOut);
            this.groupBoxCategory.Controls.Add(this.buttonGroupCancel);
            this.groupBoxCategory.Controls.Add(this.labelAbbr);
            this.groupBoxCategory.Controls.Add(this.textBoxAbbr);
            this.groupBoxCategory.Controls.Add(this.labelName);
            this.groupBoxCategory.Controls.Add(this.textBoxName);
            this.groupBoxCategory.Controls.Add(this.buttonGroupOK);
            this.groupBoxCategory.Location = new System.Drawing.Point(205, 13);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(230, 197);
            this.groupBoxCategory.TabIndex = 2;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Visible = false;
            // 
            // groupBoxInOrOut
            // 
            this.groupBoxInOrOut.Controls.Add(this.radioButtonOutgoing);
            this.groupBoxInOrOut.Controls.Add(this.radioButtonIncome);
            this.groupBoxInOrOut.Location = new System.Drawing.Point(25, 15);
            this.groupBoxInOrOut.Name = "groupBoxInOrOut";
            this.groupBoxInOrOut.Size = new System.Drawing.Size(179, 53);
            this.groupBoxInOrOut.TabIndex = 6;
            this.groupBoxInOrOut.TabStop = false;
            // 
            // radioButtonOutgoing
            // 
            this.radioButtonOutgoing.AutoSize = true;
            this.radioButtonOutgoing.Location = new System.Drawing.Point(93, 22);
            this.radioButtonOutgoing.Name = "radioButtonOutgoing";
            this.radioButtonOutgoing.Size = new System.Drawing.Size(68, 18);
            this.radioButtonOutgoing.TabIndex = 1;
            this.radioButtonOutgoing.TabStop = true;
            this.radioButtonOutgoing.Text = "Outgoing";
            this.radioButtonOutgoing.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(16, 22);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(60, 18);
            this.radioButtonIncome.TabIndex = 0;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // buttonGroupCancel
            // 
            this.buttonGroupCancel.Location = new System.Drawing.Point(124, 154);
            this.buttonGroupCancel.Name = "buttonGroupCancel";
            this.buttonGroupCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonGroupCancel.TabIndex = 5;
            this.buttonGroupCancel.Text = "Cancel";
            this.buttonGroupCancel.UseVisualStyleBackColor = true;
            // 
            // labelAbbr
            // 
            this.labelAbbr.AutoSize = true;
            this.labelAbbr.Location = new System.Drawing.Point(6, 112);
            this.labelAbbr.Name = "labelAbbr";
            this.labelAbbr.Size = new System.Drawing.Size(29, 13);
            this.labelAbbr.TabIndex = 4;
            this.labelAbbr.Text = "Abbr";
            // 
            // textBoxAbbr
            // 
            this.textBoxAbbr.Location = new System.Drawing.Point(41, 108);
            this.textBoxAbbr.Name = "textBoxAbbr";
            this.textBoxAbbr.Size = new System.Drawing.Size(183, 20);
            this.textBoxAbbr.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonGroupOK
            // 
            this.buttonGroupOK.Location = new System.Drawing.Point(31, 154);
            this.buttonGroupOK.Name = "buttonGroupOK";
            this.buttonGroupOK.Size = new System.Drawing.Size(75, 23);
            this.buttonGroupOK.TabIndex = 0;
            this.buttonGroupOK.Text = "OK";
            this.buttonGroupOK.UseVisualStyleBackColor = true;
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 2000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(301, 366);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(124, 366);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // CategoryConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 401);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.treeViewCategory);
            this.Name = "CategoryConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category";
            this.contextMenuStripCategory.ResumeLayout(false);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.groupBoxInOrOut.ResumeLayout(false);
            this.groupBoxInOrOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCategory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxInOrOut;
        private System.Windows.Forms.RadioButton radioButtonOutgoing;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.Button buttonGroupCancel;
        private System.Windows.Forms.Label labelAbbr;
        private System.Windows.Forms.TextBox textBoxAbbr;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGroupOK;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}