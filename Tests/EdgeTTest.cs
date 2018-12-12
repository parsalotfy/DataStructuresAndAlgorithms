using DataStructures;
using Xunit;

namespace Tests
{
    public class EdgeTTest
    {
        [Fact]
        public void EdgeT_Constructor_T_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>(2, 3);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }


        [Fact]
        public void EdgeT_Constructor_INodeT_Test()
        {
            // Arrange
            INode<int> n1 = new Node<int>(2);
            INode<int> n2 = new Node<int>(3);

            Edge<int> e = new Edge<int>(n1, n2);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }
    }
}
