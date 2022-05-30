using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using Xunit;

namespace Algorithms.Tests;

public class TreesTests
{
    [Fact]
    public void IterativeBfsCount_WithOneNode_WhenValueIsNotPresent_ReturnsZero()
    {
        // Arrange.
        int valueToFind = 2;
        var root = new IntTreeNode(1, left: null, right: null);

        // Act.
        int result = Trees.IterativeBfsCount(root, valueToFind);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void IterativeBfsCount_WithOneNode_WhenValueIsPresent_ReturnsOne()
    {
        // Arrange.
        int valueToFind = 1;
        var root = new IntTreeNode(valueToFind, left: null, right: null);

        // Act.
        int result = Trees.IterativeBfsCount(root, valueToFind);

        // Assert.
        Assert.Equal(1, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    public void IterativeBfsCount_WithBalancedSevenNodes_WhenValueIsPresentOnce_ReturnsOne(int valueToFind)
    {
        // Arrange.
        var node1_1 = new IntTreeNode(1, left: null, right: null);
        var node1_2 = new IntTreeNode(2, left: null, right: null);
        var node2_1 = new IntTreeNode(3, left: null, right: null);
        var node2_2 = new IntTreeNode(4, left: null, right: null);
        var node1 = new IntTreeNode(5, left: node1_1, right: node1_2);
        var node2 = new IntTreeNode(6, left: node2_1, right: node2_2);
        var root = new IntTreeNode(7, left: node1, right: node2);

        // Act.
        int result = Trees.IterativeBfsCount(root, valueToFind);

        // Assert.
        Assert.Equal(1, result);
    }

    [Fact]
    public void IterativeBfsCount_WithBalancedSevenNodes_WhenValueIsNotPresent_ReturnsZero()
    {
        // Arrange.
        int valueToFind = 100;
        var node1_1 = new IntTreeNode(1, left: null, right: null);
        var node1_2 = new IntTreeNode(2, left: null, right: null);
        var node2_1 = new IntTreeNode(3, left: null, right: null);
        var node2_2 = new IntTreeNode(4, left: null, right: null);
        var node1 = new IntTreeNode(5, left: node1_1, right: node1_2);
        var node2 = new IntTreeNode(6, left: node2_1, right: node2_2);
        var root = new IntTreeNode(7, left: node1, right: node2);

        // Act.
        int result = Trees.IterativeBfsCount(root, valueToFind);

        // Assert.
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void IterativeBfsCount_WithWorstCaseUnbalancedFiveNodes_WhenValueIsPresentOnce_ReturnsOne(int valueToFind)
    {
        // Arrange.
        var node1_1_1_1 = new IntTreeNode(1, left: null, right: null);
        var node1_1_1 = new IntTreeNode(2, left: node1_1_1_1, right: null);
        var node1_1 = new IntTreeNode(3, left: node1_1_1, right: null);
        var node1 = new IntTreeNode(4, left: node1_1, right: null);
        var root = new IntTreeNode(5, left: node1, right: null);

        // Act.
        int result = Trees.IterativeBfsCount(root, valueToFind);

        // Assert.
        Assert.Equal(1, result);
    }
}
