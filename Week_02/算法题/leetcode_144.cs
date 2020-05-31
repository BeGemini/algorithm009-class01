public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();
        PreorderTraversal(root, list);
        return list;
    }

    void PreorderTraversal(TreeNode root, IList<int> list)
    {
        if (root != null)
        {
            list.Add(root.val);
            if (root.left != null)
            {
                PreorderTraversal(root.left, list);
            }
            if (root.right != null)
            {
                PreorderTraversal(root.right, list);
            }
        }
    }
}