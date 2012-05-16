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

        List<Category> categoryListAll;
        public CategoryConfig()
        {
            InitializeComponent();
            categoryAction = new CategoryAction();
            categoryListAll = categoryAction.retrieveCategoryList();
            ControlHandler.buildupCategoryTreeView(treeViewCategory,categoryListAll);
        }
        private void init()
        {
            setCaption();
            textBoxName.Clear();
            textBoxAbbr.Clear();
            categoryListAll = categoryAction.retrieveCategoryList();
            radioButtonIncome.Checked = true;
        }
        private void setCaption()
        {
            this.radioButtonIncome.Text = G18NHandler.GetValue("JeanieMoney/Caption/Radio/Income");
            this.radioButtonOutgoing.Text = G18NHandler.GetValue("JeanieMoney/Caption/Radio/Outgoing");

            this.Text = G18NHandler.GetValue("JeanieMoney/Caption/Form/Category");
        }
        

        private void treeViewCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStripCategory.Show(e.Location);
            else
            {
                treeViewCategory.SelectedNode = treeViewCategory.GetNodeAt(e.X, e.Y);
            }
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            groupBoxCategory.Show();
        }

        private void treeViewCategory_DragDrop(object sender, DragEventArgs e)
        {
            //获得拖放中的节点
            TreeNode moveNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

            //根据鼠标坐标确定要移动到的目标节点
            Point pt;
            TreeNode targeNode;
            pt = ((TreeView)(sender)).PointToClient(new Point(e.X, e.Y));
            targeNode = treeViewCategory.GetNodeAt(pt);
            if (targeNode == null)
            {
                TreeNode NewMoveNode = (TreeNode)moveNode.Clone();
                treeViewCategory.Nodes.Add(NewMoveNode);
            }
            else
            {
                TreeNode NewMoveNode = (TreeNode)moveNode.Clone();
                targeNode.Nodes.Add(NewMoveNode);
                targeNode.BackColor = Color.White;
                targeNode.ForeColor = Color.Black;
                //更新当前拖动的节点选择
                treeViewCategory.SelectedNode = NewMoveNode;
                //展开目标节点,便于显示拖放效果
                // targeNode.Expand();
            }

            //移除拖放的节点
            moveNode.Remove();
        }

        private void treeViewCategory_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private TreeNode dropTargetNode = new TreeNode();
        private void treeViewCategory_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void treeViewCategory_DragOver(object sender, DragEventArgs e)
        {
            Point pt;
            pt = ((TreeView)(sender)).PointToClient(new Point(e.X, e.Y));
            if (treeViewCategory.GetNodeAt(pt) != null)
            {
                if (!dropTargetNode.Equals(treeViewCategory.GetNodeAt(pt)))
                {
                    dropTargetNode.BackColor = Color.White;
                    dropTargetNode.ForeColor = Color.Black;
                    dropTargetNode = treeViewCategory.GetNodeAt(pt);
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
    }
}
