using DataStructures;
using Xunit;

namespace Tests
{
    public class EdgeTest
    {
        [Fact]
        public void Edge_Constructor_Object_Test()
        {
            // Arrange
            Edge e = new Edge(2, 3);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }


        [Fact]
        public void Edge_Constructor_INode_Test()
        {
            // Arrange
            INode n1 = new Node(2);
            INode n2 = new Node(3);

            Edge e = new Edge(n1, n2);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }
    }
}