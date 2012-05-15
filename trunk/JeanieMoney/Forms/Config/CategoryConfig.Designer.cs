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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxInOrOut = new System.Windows.Forms.GroupBox();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonOutcome = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStripCategory.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxInOrOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.AllowDrop = true;
            this.treeViewCategory.Location = new System.Drawing.Point(12, 12);
            this.treeViewCategory.Name = "treeViewCategory";
            this.treeViewCategory.ShowNodeToolTips = true;
            this.treeViewCategory.Size = new System.Drawing.Size(366, 407);
            this.treeViewCategory.TabIndex = 0;
            this.treeViewCategory.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewCategory_ItemDrag);
            this.treeViewCategory.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewCategory_DragDrop);
            this.treeViewCategory.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewCategory_DragEnter);
            this.treeViewCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewCategory_MouseDown);
            // 
            // contextMenuStripCategory
            // 
            this.contextMenuStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemModify,
            this.toolStripMenuItemDelete});
            this.contextMenuStripCategory.Name = "contextMenuStripCategory";
            this.contextMenuStripCategory.Size = new System.Drawing.Size(113, 70);
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemNew.Text = "&New";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // toolStripMenuItemModify
            // 
            this.toolStripMenuItemModify.Name = "toolStripMenuItemModify";
            this.toolStripMenuItemModify.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemModify.Text = "&Modify";
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemDelete.Text = "&Delete";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.label3);
            this.groupBoxCategory.Controls.Add(this.textBox3);
            this.groupBoxCategory.Controls.Add(this.groupBoxInOrOut);
            this.groupBoxCategory.Controls.Add(this.button2);
            this.groupBoxCategory.Controls.Add(this.label2);
            this.groupBoxCategory.Controls.Add(this.textBox2);
            this.groupBoxCategory.Controls.Add(this.label1);
            this.groupBoxCategory.Controls.Add(this.textBox1);
            this.groupBoxCategory.Controls.Add(this.button1);
            this.groupBoxCategory.Location = new System.Drawing.Point(385, 13);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(230, 316);
            this.groupBoxCategory.TabIndex = 2;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "groupBox1";
            this.groupBoxCategory.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxInOrOut
            // 
            this.groupBoxInOrOut.Controls.Add(this.radioButtonOutcome);
            this.groupBoxInOrOut.Controls.Add(this.radioButtonIncome);
            this.groupBoxInOrOut.Location = new System.Drawing.Point(25, 20);
            this.groupBoxInOrOut.Name = "groupBoxInOrOut";
            this.groupBoxInOrOut.Size = new System.Drawing.Size(179, 73);
            this.groupBoxInOrOut.TabIndex = 6;
            this.groupBoxInOrOut.TabStop = false;
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(6, 30);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonIncome.TabIndex = 0;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutcome
            // 
            this.radioButtonOutcome.AutoSize = true;
            this.radioButtonOutcome.Location = new System.Drawing.Point(84, 30);
            this.radioButtonOutcome.Name = "radioButtonOutcome";
            this.radioButtonOutcome.Size = new System.Drawing.Size(68, 17);
            this.radioButtonOutcome.TabIndex = 1;
            this.radioButtonOutcome.TabStop = true;
            this.radioButtonOutcome.Text = "Outcome";
            this.radioButtonOutcome.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 465);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.treeViewCategory);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBoxInOrOut;
        private System.Windows.Forms.RadioButton radioButtonOutcome;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}