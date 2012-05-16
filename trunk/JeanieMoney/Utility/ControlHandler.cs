using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JeanieMoney.Entities;

namespace JeanieMoney.Utility
{
    class ControlHandler
    {
        public static void buildupCategoryTreeView(TreeView treeView, List<Category> list)
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
        private static void buildupCategoryTreeViewChild(TreeView treeView, List<Category> list, TreeNode parent)
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
    }
}
