using DataStructures;
using Xunit;

namespace Tests
{

    // Constructor
    // Setter
    // Parent
    public class EdgeTest
    {

        [Fact]
        public void Edge_Constructor_Object_Test()
        {
            // Arrange
            Edge e = new Edge(2, 3);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }



        [Fact]
        public void Edge_Constructor_INode_Test()
        {
            // Arrange
            INode n1 = new Node(2);
            INode n2 = new Node(3);

            Edge e = new Edge(n1, n2);

            // Act

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }



        [Fact]
        public void Edge_Setter_Test()
        {
            // Arrange
            Edge e = new Edge();
            INode a = new Node(2);
            INode b = new Node(3);

            // Act
            e.A_Node = a;
            e.Another_Node = b;

            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }

        [Fact]
        public void Edge_INodeSetter_Test()
        {
            // Arrange
            Edge e = new Edge();

            // Act
            e.A_Node.Value = 2;
            e.Another_Node.Value = 3;


            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }

    }

}
