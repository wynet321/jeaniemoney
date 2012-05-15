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

namespace JeanieMoney.Forms.Config
{
    public partial class CategoryConfig : Form
    {
        CategoryAction categoryAction=new CategoryAction();

        List<Category> categoryListAll;
        public CategoryConfig()
        {
            InitializeComponent();
            categoryListAll = categoryAction.retrieveCategoryList();
            buildupTreeView(categoryListAll, null);
        }
        private void buildupTreeView(List<Category> list, TreeNode parent)
        {
            if (parent == null)
            {
                foreach (Category category in list)
                {
                    if (category.ParentId == String.Empty)
                    {
                        TreeNode temp = new TreeNode();
                        temp.Name=category.Id;
                        temp.Text=category.Name;
                        temp.ToolTipText = category.Abbr;
                        treeViewCategory.Nodes.Add(temp);
                        buildupTreeView(list, temp);
                    }
                }
            }
            else
            {
                foreach (Category category in list)
                {
                    if (category.ParentId == parent.Name)
                    {
                        TreeNode temp = parent.Nodes.Add(category.Id, category.Name);
                        temp.ToolTipText = category.Abbr;
                        buildupTreeView(list, temp);
                    }
                }
            }
        }

        private void treeViewCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStripCategory.Show(e.Location);
            else
            {
                //change parent

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

                    targeNode.Nodes.Add( NewMoveNode);
             
                //更新当前拖动的节点选择
                treeViewCategory.SelectedNode = NewMoveNode;
                //展开目标节点,便于显示拖放效果
                targeNode.Expand();
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

        private void treeViewCategory_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
            {
                e.Effect = DragDropEffects.Move;
                Point pt;
                TreeNode targeNode;
                pt = ((TreeView)(sender)).PointToClient(new Point(e.X, e.Y));
                targeNode = treeViewCategory.GetNodeAt(pt);
                if (targeNode != null&&targeNode.no)
                {
                    targeNode.Expand();
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
