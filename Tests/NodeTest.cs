using DataStructures;
using Xunit;

namespace Tests
{
    public class NodeTest
    {
        // Constructor
        // Setter

        [Fact]
        public void Node_Constructor_Test()
        {
            // Arrange
            Node n = new Node(5);

            // Act

            // Assert
            Assert.Equal(5, n.Value);
        }


        [Fact]
        public void Node_Setter_Test()
        {
            // Arrange
            Node n = new Node();

            // Act
            n.Value = 6;

            // Assert
            Assert.Equal(6, n.Value);
        }



    }
}
