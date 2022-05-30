using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures;

/// <summary>
/// Describes a node in a simple tree which uses ints for values.
/// </summary>
public class IntTreeNode
{
    public int Value { get; }

    public IntTreeNode? Left { get; }

    public IntTreeNode? Right { get; }

    public IntTreeNode(int value, IntTreeNode? left, IntTreeNode? right)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }
}
