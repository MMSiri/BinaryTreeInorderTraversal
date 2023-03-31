using System.Collections;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var output = new List<int>();

        if (root == null) return output;

        TreeNode current = root;

        while (current != null || !(stack.Count == 0))
        {
            while (current != null) 
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            output.Add(current.val);
            current = current.right;
        }

        return output;
    }
}