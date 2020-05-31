public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();
        // ① 递归
        InorderTraversal(root, list);

        // ② 栈迭代
        if (root == null)
            return list;
        Stack<TreeNode> statck = new Stack<TreeNode>();
        while (root != null)
        {
            statck.Push(root);
            root = root.left;
        }
        while (statck.Any())
        {
            root = statck.Pop();
            list.Add(roor.val);
            root = root.right;
        }
        return list;
    }

    public void InorderTraversal(TreeNode root, IList<int> list)
    {
        if (root != null)
        {
            if (root.left != null)
                InorderTraversal(root.left, list);
            if (root != null)
                list.Add(root.val);
            if (root.right != null)
                InorderTraversal(root.right, list);
        }

    }
}