using DataStructures;
using Xunit;

namespace Tests
{
    public class NodeTTest
    {
        [Fact]
        public void Node_Int_Constructor_Test()
        {
            // Arrange
            Node<int> n = new Node<int>(5);

            // Act

            // Assert
            Assert.Equal(5, n.Value);
        }
    }
}
