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
    public TreeNode InvertTree(TreeNode root) {
        MOrder(root);
        return root;
    }

    public void MOrder(TreeNode root){
        // terminator
        if(root==null)
        {
            return;
        }
        // process current logic
        TreeNode tmpLeft = root.left;
        root.left = root.right;
        root.right=tmpLeft;
        // drill down
        MOrder(root.left);
        MOrder(root.right);
        // reverse
    }
}