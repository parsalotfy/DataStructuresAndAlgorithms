using DataStructures;
using Xunit;

namespace Tests
{
    public class GraphTest
    {
        [Fact]
        public void NodeTest()
        {
            // Arrange
            Node<int> n = new Node<int>(5);
            int a1 = n.Value;
            n.Value=6;
            int a2=n.Value;
            // Act

            // Assert
            Assert.True(true);
        }
    }
}
