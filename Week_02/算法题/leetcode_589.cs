public class Solution
{

    /*
    ① 递归
    */
    public IList<int> Preorder(Node root)
    {
        IList<int> list = new List<int>();
        Preorder(root, list);
        return list;
    }

    public void Preorder(Node root, IList<int> list)
    {
        if (root != null)
        {
            list.Add(root.val);
            if (root.children != null && root.children.Count > 0)
                foreach (Node node in root.children)
                {
                    Preorder(node, list);
                }
        }
    }
}