using DataStructures;
using Xunit;

namespace Tests
{

    // Constructor
    // Setter
    // Parent

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
            Assert.Equal(5, ((INode)n).Value);
        }




        [Fact]
        public void NodeT_Setter_Test()
        {
            // Arrange
            Node<int> n = new Node<int>();

            // Act
            n.Value = 5;

            // Assert
            Assert.Equal(5, n.Value);
        }


        [Fact]
        public void NodeT_Setter_Base_Test()
        {
            // Arrange
            Node<int> n = new Node<int>();

            // Act
            n.Value = 5;

            // Assert
            Assert.Equal(5, ((INode)n).Value);
        }

    }
}
