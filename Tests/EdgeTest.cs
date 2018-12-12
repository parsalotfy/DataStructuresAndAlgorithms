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
            Edge<object> e = new Edge<object>(2, 3);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }


        [Fact]
        public void Edge_Constructor_INode_Test()
        {
            // Arrange
            INode<object> n1 = new Node<object>(2);
            INode<object> n2 = new Node<object>(3);

            Edge<object> e = new Edge<object>(n1, n2);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }
    }
}