using DataStructures;
using Xunit;

namespace Tests
{
    public class EdgeTest
    {
        [Fact]
        public void EdgeOfT_Value_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>(2, 3);
            int a1 = e.A_Node.Value;
            int b1 = e.Another_Node.Value;

            // Act
            e.A_Node.Value = 7;
            e.Another_Node.Value = 8;

            int a2 = e.A_Node.Value;
            int b2 = e.Another_Node.Value;

            // Assert
            Assert.Equal(7, a2);
            Assert.Equal(8, b2);
        }

        [Fact]
        public void EdgeOfT_BaseValue_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>(2, 3);
            int a1 = e.A_Node.Value;
            int b1 = e.Another_Node.Value;

            // Act
            e.A_Node.Value = 7;
            e.Another_Node.Value = 8;

            object a2 = ((Edge)e).A_Node.Value;
            object b2 = ((Edge)e).Another_Node.Value;

            // Assert
            Assert.Equal(7, a2);
            Assert.Equal(8, b2);
        }

    }
}
