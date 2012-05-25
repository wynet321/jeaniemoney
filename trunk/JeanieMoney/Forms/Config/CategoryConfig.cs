using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using JeanieMoney.Actions;
using JeanieMoney.Entities;
using JeanieMoney.Utility;

namespace JeanieMoney.Forms.Config
{
    public partial class CategoryConfig : Form
    {
        private CategoryAction categoryAction;
        List<Category> categoryListOutgoing;
        List<Category> categoryListIncome;

        public CategoryConfig()
        {
            InitializeComponent();
            init();
        }

        public CategoryConfig(String abbr, char IncomeOrOutgoing)
        {
            InitializeComponent();
            init();
            if (IncomeOrOutgoing == Category.INCOME)
            {
                tabControl.SelectedTab = tabPageIncome;
                createNodeByTreeView(treeViewIncome);
                textBoxIncomeAbbr.Text = abbr;
                textBoxIncomeName.Select();
                textBoxIncomeName.Focus();
            }
            else
            {
                tabControl.SelectedTab = tabPageOutgoing;
                createNodeByTreeView(treeViewOutgoing);
                textBoxOutgoingAbbr.Text = abbr;
                textBoxOutgoingName.Select();
                textBoxOutgoingName.Focus();
            }
        }

        private void init()
        {
            setCaption();
            categoryAction = new CategoryAction();

            categoryListIncome = categoryAction.retrieveCategoryList(true);
            buildupCategoryTreeView(treeViewIncome, categoryListIncome);
            categoryListOutgoing = categoryAction.retrieveCategoryList(false);
            buildupCategoryTreeView(treeViewOutgoing, categoryListOutgoing);
        }

        private void setCaption()
        {
            tabPageIncome.Text = G18NHandler.getValue(Constant.CAPTION_TAB_INCOME);
            tabPageOutgoing.Text = G18NHandler.getValue(Constant.CAPTION_TAB_OUTGOING);

            labelIncomeAbbr.Text = G18NHandler.getValue(Constant.CAPTION_LABEL_ABBR);
            labelIncomeName.Text = G18NHandler.getValue(Constant.CAPTION_LABEL_NAME);
            labelOutgoingAbbr.Text = this.labelIncomeAbbr.Text;
            labelOutgoingName.Text = this.labelIncomeName.Text;

            buttonIncomeCancel.Text = G18NHandler.getValue(Constant.CAPTION_BUTTON_CANCEL);
            buttonIncomeOK.Text = G18NHandler.getValue(Constant.CAPTION_BUTTON_OK);
            buttonOutgoingCancel.Text = buttonIncomeCancel.Text;
            buttonOutgoingOK.Text = buttonIncomeOK.Text;
            buttonClose.Text = G18NHandler.getValue(Constant.CAPTION_BUTTON_CLOSE);

            toolStripMenuItemNew.Text = G18NHandler.getValue(Constant.CAPTION_TOOLSTRIPMENU_NEW);
            toolStripMenuItemDelete.Text = G18NHandler.getValue(Constant.CAPTION_TOOLSTRIPMENU_DELETE);

            Text = G18NHandler.getValue(Constant.CAPTION_FORM_CATEGORY);
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideGroup(treeViewOutgoing);
            hideGroup(treeViewIncome);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void treeViewOutgoing_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Modify node
            showGroup(treeViewOutgoing);
            treeViewOutgoing.SelectedNode = e.Node;
            textBoxOutgoingName.Text = e.Node.Text;
            textBoxOutgoingAbbr.Text = e.Node.ToolTipText;
        }
        private void treeViewIncome_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Modify node
            showGroup(treeViewIncome);
            treeViewIncome.SelectedNode = e.Node;
            textBoxIncomeName.Text = e.Node.Text;
            textBoxIncomeAbbr.Text = e.Node.ToolTipText;

        }
        #region Buildup Treeview
        private void buildupCategoryTreeView(TreeView treeView, List<Category> list)
        {
            foreach (Category category in list)
            {
                if (String.IsNullOrEmpty(category.ParentId))
                {
                    TreeNode temp = treeView.Nodes.Add(category.Id, category.Name);
                    temp.ToolTipText = category.Abbr;
                    buildupCategoryTreeViewChild(treeView, list, temp);
                }
            }
        }
        private void buildupCategoryTreeViewChild(TreeView treeView, List<Category> list, TreeNode parent)
        {
            foreach (Category category in list)
            {
                if (category.ParentId == parent.Name)
                {
                    TreeNode temp = parent.Nodes.Add(category.Id, category.Name);
                    temp.ToolTipText = category.Abbr;
                    buildupCategoryTreeViewChild(treeView, list, temp);
                }

            }
        }
        #endregion
        #region Drag&drop
        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void treeViewIncome_DragDrop(object sender, DragEventArgs e)
        {
            dragDropNode(sender, e, treeViewIncome);
        }

        private void treeViewOutgoing_DragDrop(object sender, DragEventArgs e)
        {
            dragDropNode(sender, e, treeViewOutgoing);
        }

        private void dragDropNode(object sender, DragEventArgs e, TreeView treeView)
        {
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            TreeNode draggedNodeClone = draggedNode.Clone() as TreeNode;
            //update db
            Category category = new Category();
            category.Id = draggedNode.Name;
            category.ParentId = targetNode.Name;
            if (categoryAction.updateCategoryById(category))
            {

                if (String.IsNullOrEmpty(targetNode.Name))
                {
                    //drop to root node
                    treeView.Nodes.Add(draggedNodeClone);
                }
                else
                {
                    //drop clone node to target node
                    targetNode.Nodes.Add(draggedNodeClone);
                    targetNode.BackColor = Color.White;
                    targetNode.ForeColor = Color.Black;
                    treeView.SelectedNode = draggedNodeClone;
                }

                //remove the original node
                draggedNode.Remove();
            }

        }
        #region targetNode color change
        private void treeViewIncome_DragOver(object sender, DragEventArgs e)
        {
            tragOver(sender, e, treeViewIncome);
        }

        private void treeViewOutgoing_DragOver(object sender, DragEventArgs e)
        {
            tragOver(sender, e, treeViewOutgoing);
        }

        private TreeNode targetNode = new TreeNode();
        private void tragOver(object sender, DragEventArgs e, TreeView treeView)
        {
            Point pt;
            pt = (sender as TreeView).PointToClient(new Point(e.X, e.Y));
            TreeNode newTargetNode = treeView.GetNodeAt(pt);

            if (!targetNode.Equals(newTargetNode))
            {
                //change the color of target node before point to new target node
                targetNode.BackColor = Color.White;
                targetNode.ForeColor = Color.Black;

                if (newTargetNode != null)
                {
                    //point to new target node
                    targetNode = newTargetNode;
                    targetNode.BackColor = Color.DarkBlue;
                    targetNode.ForeColor = Color.White;

                    //delay 2 secs to expand
                    timerDelay.Start();
                }
                else
                {
                    targetNode = new TreeNode();
                }
            }
        }
        private void timerDelay_Tick(object sender, EventArgs e)
        {
            targetNode.Expand();
            timerDelay.Stop();
        }
        #endregion
        #endregion
        #region OK
        private void buttonOKClick(object sender, EventArgs e, TreeView treeView)
        {
            Category category = new Category();
            if (treeView.Equals(treeViewOutgoing))
            {
                category.Name = textBoxOutgoingName.Text;
                category.Abbr = textBoxOutgoingAbbr.Text;
                category.IncomeOrOutgoing = Category.OUTGOING;
            }
            else
            {
                category.Name = textBoxIncomeName.Text;
                category.Abbr = textBoxIncomeAbbr.Text;
                category.IncomeOrOutgoing = Category.INCOME;
            }
            if (String.IsNullOrEmpty(treeView.SelectedNode.Name))
            {
                //create
                category.Id = Guid.NewGuid().ToString();
                if (categoryAction.createCategory(category))
                {
                    hideGroup(treeView);
                    treeView.SelectedNode.Name = category.Id;
                    treeView.SelectedNode.Text = category.Name;
                    treeView.SelectedNode.ToolTipText = category.Abbr;
                }
                else
                {
                    MessageBox.Show("Fail create!");
                    return;
                }
            }
            else
            {
                //modify
                category.Id = treeView.SelectedNode.Name;
                if (treeView.SelectedNode.Parent != null)
                    category.ParentId = treeView.SelectedNode.Parent.Name;
                if (categoryAction.updateCategoryById(category))
                {
                    hideGroup(treeView);
                    treeView.SelectedNode.Text = category.Name;
                    treeView.SelectedNode.ToolTipText = category.Abbr;
                }
                else
                {
                    MessageBox.Show("Fail modify!");
                    return;
                }
            }
        }

        private void buttonOutgoingOK_Click(object sender, EventArgs e)
        {
            buttonOKClick(sender, e, treeViewOutgoing);
        }

        private void buttonIncomeOK_Click(object sender, EventArgs e)
        {
            buttonOKClick(sender, e, treeViewIncome);
        }
        #endregion
        #region Cancel
        private void buttonIncomeCancel_Click(object sender, EventArgs e)
        {
            buttonCancelClick(treeViewIncome);
        }

        private void buttonOutgoingCancel_Click(object sender, EventArgs e)
        {
            buttonCancelClick(treeViewOutgoing);
        }
        private void buttonCancelClick(TreeView treeView)
        {
            if (String.IsNullOrEmpty(treeView.SelectedNode.Name))
            {
                //new
                if (treeView.SelectedNode.Parent != null)
                {
                    treeView.SelectedNode.Parent.Collapse();
                }
                treeView.SelectedNode.Remove();
            }
            hideGroup(treeView);
        }
        #endregion
        #region toolStripMenu
        private void treeViewMouseUp(object sender, MouseEventArgs e, TreeView treeView)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode targetNode = treeView.GetNodeAt(new Point(e.X, e.Y));
                if (targetNode != null)
                {
                    toolStripMenuItemDelete.Visible = true;
                    ((TreeView)sender).SelectedNode = targetNode;
                    contextMenuStripCategory.Show(((TreeView)sender).PointToScreen(e.Location));
                }
                else
                {
                    toolStripMenuItemDelete.Visible = false;
                    ((TreeView)sender).SelectedNode = null;
                    contextMenuStripCategory.Show(((TreeView)sender).PointToScreen(e.Location));
                }
            }
        }

        private void treeViewIncome_MouseUp(object sender, MouseEventArgs e)
        {
            treeViewMouseUp(sender, e, treeViewIncome);
        }
        private void treeViewOutgoing_MouseUp(object sender, MouseEventArgs e)
        {
            treeViewMouseUp(sender, e, treeViewOutgoing);
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            createNode();
        }
        private void createNode()
        {
            if (tabControl.SelectedTab == tabPageIncome)
            {
                createNodeByTreeView(treeViewIncome);
            }
            else
            {
                createNodeByTreeView(treeViewOutgoing);
            }
        }
        private void createNodeByTreeView(TreeView treeView)
        {
            if (treeView.SelectedNode == null)
            {
                //root node
                treeView.SelectedNode = treeView.Nodes.Add("");
            }
            else
            {
                treeView.SelectedNode.Expand();
                treeView.SelectedNode = treeView.SelectedNode.Nodes.Add("");
            }
            showGroup(treeView);
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            deleteNode();
        }
        private void deleteNode()
        {
            if (DialogResult.Yes == MessageBox.Show("really delete?", "", MessageBoxButtons.YesNo))
            {
                TreeView treeView = (tabControl.SelectedTab == tabPageIncome) ? treeViewIncome : treeViewOutgoing;
                if (categoryAction.deleteCategoryById(treeView.SelectedNode.Name))
                {
                    treeView.SelectedNode.Remove();
                }
                else
                {
                    MessageBox.Show("Failed delete!");
                }
            }
        }

        #endregion
        #region groupoperation
        private void showGroup(TreeView treeView)
        {
            if (treeView == treeViewIncome)
            {
                groupBoxIncome.Visible = true;
                treeViewIncome.Enabled = false;

                textBoxIncomeAbbr.Clear();
                textBoxIncomeName.Clear();
            }
            else
            {
                groupBoxOutgoing.Visible = true;
                treeViewOutgoing.Enabled = false;

                textBoxOutgoingAbbr.Clear();
                textBoxOutgoingName.Clear();
            }
            this.Width = 460;
            tabControl.Width = 430;
            buttonClose.Left = 156;
            buttonClose.Enabled = false;
        }
        private void hideGroup(TreeView treeView)
        {
            if (treeView == treeViewIncome)
            {
                groupBoxIncome.Visible = false;
                treeViewIncome.Enabled = true;
            }
            else
            {
                groupBoxOutgoing.Visible = false;
                treeViewOutgoing.Enabled = true;
            }
            this.Width = 250;
            tabControl.Width = 222;
            buttonClose.Left = 85;
            buttonClose.Enabled = true;
        }
        #endregion

    }
}
