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
        public void EdgeT_Constructor_T_Base_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>(2, 3);

            // Act

            // Assert
            Assert.Equal(2, ((IEdge)e).A_Node.Value);
            Assert.Equal(3, ((IEdge)e).Another_Node.Value);
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

        [Fact]
        public void EdgeT_Constructor_INodeT_Base_Test()
        {
            // Arrange
            INode<int> n1 = new Node<int>(2);
            INode<int> n2 = new Node<int>(3);

            Edge<int> e = new Edge<int>(n1, n2);


            // Act

            // Assert
            Assert.Equal(2, ((IEdge)e).A_Node.Value);
            Assert.Equal(3, ((IEdge)e).Another_Node.Value);
        }




        [Fact]
        public void EdgeT_Setter_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>();
            INode<int> n1 = new Node<int>(2);
            INode<int> n2 = new Node<int>(3);


            // Act
            e.A_Node=n1;
            e.Another_Node=n2;


            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }


        [Fact]
        public void EdgeT_Setter_Base_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>();
            INode<int> n1 = new Node<int>(2);
            INode<int> n2 = new Node<int>(3);


            // Act
            e.A_Node=n1;
            e.Another_Node=n2;


            // Assert
            Assert.Equal(2, ((IEdge)e).A_Node.Value);
            Assert.Equal(3, ((IEdge)e).Another_Node.Value);
        }






        [Fact]
        public void EdgeT_INodeSetter_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>();


            // Act
            e.A_Node.Value=2;
            e.Another_Node.Value=3;


            // Assert
            Assert.Equal(2, e.A_Node.Value);
            Assert.Equal(3, e.Another_Node.Value);
        }

        [Fact]
        public void EdgeT_INodeSetter_Base_Test()
        {
            // Arrange
            Edge<int> e = new Edge<int>();


            // Act
            e.A_Node.Value=2;
            e.Another_Node.Value=3;


            // Assert
            Assert.Equal(2, ((IEdge)e).A_Node.Value);
            Assert.Equal(3, ((IEdge)e).Another_Node.Value);
        }


    }
}
