/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        bool valid = true;
        MOrder(root,ref valid);
        return valid;
    }

    public void MOrder(TreeNode root,TreeNode up,TreeNode down,ref bool valid)
    {
        if (root==null)
            return;
        if (root.left!=null&&root.val<=root.left.val&& )
        {
            valid=false;
            return;
        }
        if(root.right!=null&&root.val>=root.right.val)
        {
            valid=false;
            return;
        }
        MOrder(root.left,ref valid);
        MOrder(root.right,ref valid);
    }
}