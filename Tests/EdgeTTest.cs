using DataStructures;
using Xunit;

namespace Tests
{
    public class EdgeTest
    {
        [Fact]
        public void Edge_Constructor_T_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>(2,3);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node);
            Assert.Equal(3, e.Another_Node);
        }        
    }
}
