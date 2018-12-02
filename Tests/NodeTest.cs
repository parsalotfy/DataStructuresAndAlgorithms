using DataStructures;
using Xunit;

namespace Tests
{
    public class NodeTest
    {
        [Fact]
        public void NodeOfT_Value_Test()
        {
            // Arrange
            Node<int> n = new Node<int>(5);
            int a1 = n.Value;

            // Act
            n.UpdateValue(6);
            int a2 = n.Value;

            // Assert
            Assert.Equal(6, a2);
        }

        [Fact]
        public void NodeOfT_BaseValue_Test()
        {
            // Arrange
            Node<int> n = new Node<int>(5);
            int a1 = n.Value;

            // Act
            n.UpdateValue(6);
            object a2 = ((Node)n).Value;

            // Assert
            Assert.Equal(6, a2);
        }

    }
}
