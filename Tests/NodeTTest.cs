using DataStructures;
using Xunit;

namespace Tests
{
    public class NodeTTest
    {
        [Fact]
        public void NodeT_Constructor_Test()
        {
            // Arrange
            Node<int> n = new Node<int>(5);

            // Act

            // Assert
            Assert.Equal(5, n.Value);
        }


        [Fact]
        public void NodeT_Constructor_Base_Test()
        {
            // Arrange
            Node<int> n = new Node<int>(5);

            // Act

            // Assert
            Assert.Equal(5, ((INode<object>)n).Value);
        }
    }
}
