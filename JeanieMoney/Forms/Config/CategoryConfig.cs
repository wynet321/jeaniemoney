using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            categoryAction = new CategoryAction();
            init();
        }
        private void init()
        {
            setCaption();
            textBoxIncomeName.Clear();
            textBoxIncomeAbbr.Clear();
            categoryListIncome = categoryAction.retrieveCategoryList(true);
            categoryListOutgoing = categoryAction.retrieveCategoryList(false);
            ControlHandler.buildupCategoryTreeView(treeViewIncome, categoryListIncome);
            ControlHandler.buildupCategoryTreeView(treeViewOutgoing, categoryListOutgoing);
        }
        private void setCaption()
        {
            this.tabPageIncome.Text = G18NHandler.GetValue("JeanieMoney/Caption/Tab/Income");
            this.tabPageOutgoing.Text = G18NHandler.GetValue("JeanieMoney/Caption/Tab/Outgoing");
            this.buttonClose.Text = G18NHandler.GetValue("JeanieMoney/Caption/Button/Close");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Category");
        }


        private void treeViewIncome_DragDrop(object sender, DragEventArgs e)
        {
            dragDropNode(sender, e, treeViewIncome);
        }
        private void dragDropNode(object sender, DragEventArgs e, TreeView treeView)
        {
            //获得拖放中的节点
            TreeNode moveNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            //根据鼠标坐标确定要移动到的目标节点
            Point pt;
            TreeNode targeNode;
            pt = ((TreeView)(sender)).PointToClient(new Point(e.X, e.Y));
            targeNode = treeView.GetNodeAt(pt);
            if (targeNode == null)
            {
                TreeNode NewMoveNode = (TreeNode)moveNode.Clone();
                treeView.Nodes.Add(NewMoveNode);
            }
            else
            {
                TreeNode NewMoveNode = (TreeNode)moveNode.Clone();
                targeNode.Nodes.Add(NewMoveNode);
                targeNode.BackColor = Color.White;
                targeNode.ForeColor = Color.Black;
                //更新当前拖动的节点选择
                treeView.SelectedNode = NewMoveNode;

                targeNode.BackColor = Color.White;
                targeNode.ForeColor = Color.Black;
            }

            //remove the original node
            moveNode.Remove();

        }

        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }


        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }


        private void treeViewIncome_DragOver(object sender, DragEventArgs e)
        {
            tragOver(sender, e, treeViewIncome);
        }
        private TreeNode dropTargetNode = new TreeNode();
        private void tragOver(object sender, DragEventArgs e, TreeView treeView)
        {
            Point pt;
            pt = ((TreeView)(sender)).PointToClient(new Point(e.X, e.Y));
            if (treeView.GetNodeAt(pt) != null)
            {
                if (!dropTargetNode.Equals(treeView.GetNodeAt(pt)))
                {
                    dropTargetNode.BackColor = Color.White;
                    dropTargetNode.ForeColor = Color.Black;
                    dropTargetNode = treeView.GetNodeAt(pt);
                    timerDelay.Start();

                }
                if (dropTargetNode != null)
                {
                    dropTargetNode.BackColor = Color.DarkBlue;
                    dropTargetNode.ForeColor = Color.White;
                }
            }
        }
        private void timerDelay_Tick(object sender, EventArgs e)
        {
            dropTargetNode.Expand();
            timerDelay.Stop();
        }



        private void treeViewIncome_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Modify node
            showGroup(treeViewIncome);
            textBoxIncomeName.Text = e.Node.Text;
            textBoxIncomeAbbr.Text = e.Node.ToolTipText;

        }

        private void buttonIncomeOK_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = treeViewIncome.SelectedNode.Name;
            category.Name = textBoxIncomeName.Text;
            category.Abbr = textBoxIncomeAbbr.Text;
            if (treeViewIncome.SelectedNode.Parent != null)
                category.ParentId = treeViewIncome.SelectedNode.Parent.Name;
            category.InOrOut = '1';
            if (categoryAction.updateCategoryById(category))
            {
                hideGroup(treeViewIncome);
                treeViewIncome.SelectedNode.Text = category.Name;
                treeViewIncome.SelectedNode.ToolTipText = category.Abbr;
            }
            else
            {
                MessageBox.Show("Fail modify!");
                return;
            }
        }

        private void buttonIncomeCancel_Click(object sender, EventArgs e)
        {
            buttonCancelClick(treeViewIncome);
        }



        private void treeViewOutgoing_DragDrop(object sender, DragEventArgs e)
        {
            dragDropNode(sender, e, treeViewOutgoing);
        }



        private void treeViewOutgoing_DragOver(object sender, DragEventArgs e)
        {
            tragOver(sender, e, treeViewOutgoing);
        }

        private void treeViewOutgoing_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Modify node
            showGroup(treeViewOutgoing);
            textBoxOutgoingName.Text = e.Node.Text;
            textBoxOutgoingAbbr.Text = e.Node.ToolTipText;
        }



        private void buttonOutgoingOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(treeViewOutgoing.SelectedNode.Name))
            {
                //new

            }
            else
            {
                //modify
                Category category = new Category();
                category.Id = treeViewOutgoing.SelectedNode.Name;
                category.Name = textBoxOutgoingName.Text;
                category.Abbr = textBoxOutgoingAbbr.Text;
                if (treeViewOutgoing.SelectedNode.Parent != null)
                    category.ParentId = treeViewOutgoing.SelectedNode.Parent.Name;
                category.InOrOut = '1';
                if (categoryAction.updateCategoryById(category))
                {
                    hideGroup(treeViewOutgoing);
                    treeViewOutgoing.SelectedNode.Text = category.Name;
                    treeViewOutgoing.SelectedNode.ToolTipText = category.Abbr;
                }
                else
                {
                    MessageBox.Show("Fail modify!");
                    return;
                }
            }
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideGroup(treeViewOutgoing);
            hideGroup(treeViewIncome);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
