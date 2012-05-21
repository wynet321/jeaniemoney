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
        private void init()
        {
            setCaption();
            categoryAction = new CategoryAction();

            categoryListIncome = categoryAction.retrieveCategoryList(true);
            ControlHandler.buildupCategoryTreeView(treeViewIncome, categoryListIncome);
            categoryListOutgoing = categoryAction.retrieveCategoryList(false);
            ControlHandler.buildupCategoryTreeView(treeViewOutgoing, categoryListOutgoing);
        }
        private void setCaption()
        {
            this.tabPageIncome.Text = G18NHandler.GetValue("JeanieMoney/Caption/Tab/Income");
            this.tabPageOutgoing.Text = G18NHandler.GetValue("JeanieMoney/Caption/Tab/Outgoing");
            this.buttonClose.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Close");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Category");
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

        #region drag&drop
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
                    targetNode = treeView.GetNodeAt(pt);
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
            if (String.IsNullOrEmpty(treeView.SelectedNode.Name))
            {
                //new

            }
            else
            {
                //modify
                Category category = new Category();
                category.Id = treeView.SelectedNode.Name;
                category.Name = textBoxOutgoingName.Text;
                category.Abbr = textBoxOutgoingAbbr.Text;
                if (treeView.SelectedNode.Parent != null)
                    category.ParentId = treeView.SelectedNode.Parent.Name;
                category.InOrOut = '1';
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
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node != null)
                {
                    toolStripMenuItemDelete.Visible = true;
                    ((TreeView)sender).SelectedNode = e.Node;
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
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageIncome)
            {
                if (treeViewIncome.SelectedNode == null)
                {
                    //root node
                    treeViewIncome.SelectedNode = treeViewIncome.Nodes.Add("");
                }
                else
                {
                    treeViewIncome.SelectedNode.Expand();
                    treeViewIncome.SelectedNode = treeViewIncome.SelectedNode.Nodes.Add("");
                }
                showGroup(treeViewIncome);
            }
            else
            {
                if (treeViewOutgoing.SelectedNode == null)
                {
                    //root node
                    treeViewOutgoing.SelectedNode = treeViewOutgoing.Nodes.Add("");
                }
                else
                {
                    treeViewOutgoing.SelectedNode.Expand();
                    treeViewOutgoing.SelectedNode = treeViewOutgoing.SelectedNode.Nodes.Add("");
                }
                showGroup(treeViewOutgoing);
            }
        }
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageIncome)
                treeViewIncome.SelectedNode.Remove();
            else
                treeViewOutgoing.SelectedNode.Remove();
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
            buttonClose.Left = 156;
            tabControl.Width = 430;
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
            buttonClose.Left = 85;
            tabControl.Width = 222;

        }
        #endregion
    }
}
