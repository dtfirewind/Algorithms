using System;
using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class NodeTest
    {
        [Fact]
        public void AddToTailTest()
        {
            var node = new Node(1);
            var n = node;

            node.AppendToTail(2);

            while(n.next != null)
            {
                n = n.next;
            }

            Assert.Equal(2,n.data);
        }

        [Fact]
        public void DeleteNodeTest()
        {
        //Given
        Node node = new Node(1);
        var n = node;
        //When
        node.AppendToTail(2);
        node.AppendToTail(3);
        node.AppendToTail(4);

        node.DeleteNode(3);

        while(n.data != 2)
        {
            n = n.next;
        }
        //Then
        Assert.Equal(4,n.next.data);
        }
    }
}
