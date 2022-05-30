using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;

namespace Algorithms;

public static class Trees
{
    /// <summary>
    /// Uses BFS to count the number of times the specified value occurs in the tree.
    /// </summary>
    public static int IterativeBfsCount(IntTreeNode root, int value)
    {
        var queue = new Queue<IntTreeNode>();
        queue.Enqueue(root);

        int count = 0;
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current.Value == value)
            {
                count++;
            }

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        return count;
    }

    /// <summary>
    /// Uses DFS to count the number of times the specified value occurs in the tree.
    /// </summary>
    public static int IterativeDfsCount(IntTreeNode root, int value)
    {
        var stack = new Stack<IntTreeNode>();
        stack.Push(root);

        int count = 0;
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current.Value == value)
            {
                count++;
            }

            if (current.Left != null)
            {
                stack.Push(current.Left);
            }

            if (current.Right != null)
            {
                stack.Push(current.Right);
            }
        }

        return count;
    }
}
