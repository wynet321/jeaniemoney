﻿namespace JeanieMoney.Forms
{
    partial class formMain
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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridViewJournalRecord = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentcategorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jeanieMoneyDataSet = new JeanieMoney.JeanieMoneyDataSet();
            this.panelSearchCondition = new System.Windows.Forms.Panel();
            this.labelSeperator = new System.Windows.Forms.Label();
            this.lablePeriod = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRecordInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.journal_recordTableAdapter = new JeanieMoney.JeanieMoneyDataSetTableAdapters.journal_recordTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalrecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeanieMoneyDataSet)).BeginInit();
            this.panelSearchCondition.SuspendLayout();
            this.toolStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 660);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1264, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridViewJournalRecord);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panelSearchCondition);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1264, 445);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1264, 516);
            this.toolStripContainer1.TabIndex = 1;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripMainMenu);
            // 
            // dataGridViewJournalRecord
            // 
            this.dataGridViewJournalRecord.AllowUserToAddRows = false;
            this.dataGridViewJournalRecord.AllowUserToDeleteRows = false;
            this.dataGridViewJournalRecord.AllowUserToOrderColumns = true;
            this.dataGridViewJournalRecord.AutoGenerateColumns = false;
            this.dataGridViewJournalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournalRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locationnameDataGridViewTextBoxColumn,
            this.payernameDataGridViewTextBoxColumn,
            this.paymentcategorynameDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridViewJournalRecord.DataSource = this.journalrecordBindingSource;
            this.dataGridViewJournalRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJournalRecord.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewJournalRecord.Name = "dataGridViewJournalRecord";
            this.dataGridViewJournalRecord.ReadOnly = true;
            this.dataGridViewJournalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJournalRecord.Size = new System.Drawing.Size(1264, 417);
            this.dataGridViewJournalRecord.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationnameDataGridViewTextBoxColumn
            // 
            this.locationnameDataGridViewTextBoxColumn.DataPropertyName = "location_name";
            this.locationnameDataGridViewTextBoxColumn.HeaderText = "location_name";
            this.locationnameDataGridViewTextBoxColumn.Name = "locationnameDataGridViewTextBoxColumn";
            this.locationnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payernameDataGridViewTextBoxColumn
            // 
            this.payernameDataGridViewTextBoxColumn.DataPropertyName = "payer_name";
            this.payernameDataGridViewTextBoxColumn.HeaderText = "payer_name";
            this.payernameDataGridViewTextBoxColumn.Name = "payernameDataGridViewTextBoxColumn";
            this.payernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentcategorynameDataGridViewTextBoxColumn
            // 
            this.paymentcategorynameDataGridViewTextBoxColumn.DataPropertyName = "payment_category_name";
            this.paymentcategorynameDataGridViewTextBoxColumn.HeaderText = "payment_category_name";
            this.paymentcategorynameDataGridViewTextBoxColumn.Name = "paymentcategorynameDataGridViewTextBoxColumn";
            this.paymentcategorynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // journalrecordBindingSource
            // 
            this.journalrecordBindingSource.DataMember = "journal_record";
            this.journalrecordBindingSource.DataSource = this.jeanieMoneyDataSet;
            // 
            // jeanieMoneyDataSet
            // 
            this.jeanieMoneyDataSet.DataSetName = "JeanieMoneyDataSet";
            this.jeanieMoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelSearchCondition
            // 
            this.panelSearchCondition.Controls.Add(this.labelSeperator);
            this.panelSearchCondition.Controls.Add(this.lablePeriod);
            this.panelSearchCondition.Controls.Add(this.dateTimePickerStart);
            this.panelSearchCondition.Controls.Add(this.buttonSearch);
            this.panelSearchCondition.Controls.Add(this.dateTimePickerEnd);
            this.panelSearchCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchCondition.Location = new System.Drawing.Point(0, 0);
            this.panelSearchCondition.Name = "panelSearchCondition";
            this.panelSearchCondition.Size = new System.Drawing.Size(1264, 28);
            this.panelSearchCondition.TabIndex = 7;
            // 
            // labelSeperator
            // 
            this.labelSeperator.AutoSize = true;
            this.labelSeperator.Location = new System.Drawing.Point(185, 7);
            this.labelSeperator.Name = "labelSeperator";
            this.labelSeperator.Size = new System.Drawing.Size(10, 13);
            this.labelSeperator.TabIndex = 6;
            this.labelSeperator.Text = "-";
            // 
            // lablePeriod
            // 
            this.lablePeriod.AutoSize = true;
            this.lablePeriod.Location = new System.Drawing.Point(12, 7);
            this.lablePeriod.Name = "lablePeriod";
            this.lablePeriod.Size = new System.Drawing.Size(37, 13);
            this.lablePeriod.TabIndex = 5;
            this.lablePeriod.Text = "Period";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(53, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(344, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 21);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(201, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRecordInput,
            this.toolStripButton3});
            this.toolStripMainMenu.Location = new System.Drawing.Point(3, 0);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(148, 71);
            this.toolStripMainMenu.TabIndex = 0;
            // 
            // toolStripButtonRecordInput
            // 
            this.toolStripButtonRecordInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRecordInput.Image = global::JeanieMoney.Properties.Resources.ConsumeRecord;
            this.toolStripButtonRecordInput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRecordInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRecordInput.Name = "toolStripButtonRecordInput";
            this.toolStripButtonRecordInput.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonRecordInput.Click += new System.EventHandler(this.toolStripButtonRecordInput_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::JeanieMoney.Properties.Resources.ConsumeRecord;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 68);
            // 
            // toolStripButton
            // 
            this.toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton.Image = global::JeanieMoney.Properties.Resources.ConsumeRecord;
            this.toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton.Name = "toolStripButton";
            this.toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton.Text = "toolStripButton1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::JeanieMoney.Properties.Resources.ConsumeRecord;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // journal_recordTableAdapter
            // 
            this.journal_recordTableAdapter.ClearBeforeFill = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStripMain);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalrecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeanieMoneyDataSet)).EndInit();
            this.panelSearchCondition.ResumeLayout(false);
            this.panelSearchCondition.PerformLayout();
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripMainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton;
        private System.Windows.Forms.Label labelSeperator;
        private System.Windows.Forms.Label lablePeriod;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView dataGridViewJournalRecord;
        private System.Windows.Forms.Panel panelSearchCondition;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecordInput;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private JeanieMoneyDataSet jeanieMoneyDataSet;
        private System.Windows.Forms.BindingSource journalrecordBindingSource;
        private JeanieMoneyDataSetTableAdapters.journal_recordTableAdapter journal_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentcategorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
    }
}