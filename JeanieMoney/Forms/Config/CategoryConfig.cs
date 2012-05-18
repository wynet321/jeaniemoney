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


        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            groupBoxIncome.Show();
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
                //展开目标节点,便于显示拖放效果
                // targeNode.Expand();
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

        private void showIncomeGroup()
        {
            groupBoxIncome.Visible = true;
            this.Width = 460;
            buttonClose.Left = 156;
            tabControl.Width = 430;
            treeViewIncome.Enabled = false;

            textBoxIncomeAbbr.Clear();
            textBoxIncomeName.Clear();
        }

        private void hideIncomeGroup()
        {
            groupBoxIncome.Visible = false;
            this.Width = 250;
            buttonClose.Left = 85;
            tabControl.Width = 222;
            treeViewIncome.Enabled = true;
        }

        private void treeViewIncome_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Modify node
            showIncomeGroup();
            textBoxIncomeName.Text = e.Node.Text;
            textBoxIncomeAbbr.Text = e.Node.ToolTipText;

        }

        private void buttonIncomeOK_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = treeViewIncome.SelectedNode.Name;
            category.Name = textBoxIncomeName.Text;
            category.Abbr = textBoxIncomeAbbr.Text;
            if (treeViewIncome.SelectedNode.Parent!=null)
                category.ParentId = treeViewIncome.SelectedNode.Parent.Name;
            category.InOrOut = '1';
            if (categoryAction.updateCategoryById(category))
            {
                hideIncomeGroup();
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
            hideIncomeGroup();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripCategory.Show(e.X, e.Y);
            }
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
            showOutgoingGroup();
            textBoxOutgoingName.Text = e.Node.Text;
            textBoxOutgoingAbbr.Text = e.Node.ToolTipText;
        }

        private void showOutgoingGroup()
        {
            groupBoxOutgoing.Visible = true;
            this.Width = 460;
            buttonClose.Left = 156;
            tabControl.Width = 430;
            treeViewOutgoing.Enabled = false;

            textBoxOutgoingAbbr.Clear();
            textBoxOutgoingName.Clear();
        }
        private void hideOutgoingGroup()
        {
            groupBoxOutgoing.Visible = false;
            this.Width = 250;
            buttonClose.Left = 85;
            tabControl.Width = 222;
            treeViewOutgoing.Enabled = true;
        }

        private void buttonOutgoingOK_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = treeViewOutgoing.SelectedNode.Name;
            category.Name = textBoxOutgoingName.Text;
            category.Abbr = textBoxOutgoingAbbr.Text;
            if (treeViewOutgoing.SelectedNode.Parent!=null)
                category.ParentId = treeViewOutgoing.SelectedNode.Parent.Name;
            category.InOrOut = '1';
            if (categoryAction.updateCategoryById(category))
            {
                hideOutgoingGroup();
                treeViewOutgoing.SelectedNode.Text = category.Name;
                treeViewOutgoing.SelectedNode.ToolTipText = category.Abbr;
            }
            else
            {
                MessageBox.Show("Fail modify!");
                return;
            }
        }

        private void buttonOutgoingCancel_Click(object sender, EventArgs e)
        {
            hideOutgoingGroup();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideIncomeGroup();
            hideOutgoingGroup();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
