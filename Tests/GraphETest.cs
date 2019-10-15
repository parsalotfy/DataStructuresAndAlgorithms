using DataStructures;
using System.Linq;
using Xunit;

namespace Tests
{
    public class GraphETest
    {
        [Fact]
        public void GraphE_P_Null_AddNode_AddEdge_RemoveNode_RemoveEdge()
        {
            // Arrange
            GraphE<int> intGraph = new GraphE<int>();


            // Act
            intGraph.AddNode(1);
            intGraph.AddNode(2);
            intGraph.AddNode(3);
            intGraph.AddNode(4);
            intGraph.AddNode(5);
            intGraph.AddNode(6);

            intGraph.AddEdge(1, 6);
            intGraph.AddEdge(2, 6);
            intGraph.AddEdge(3, 6);
            intGraph.AddEdge(4, 6);
            intGraph.AddEdge(5, 6);

            intGraph.AddEdge(1, 1);
            intGraph.AddEdge(2, 2);
            intGraph.AddEdge(3, 3);
            intGraph.AddEdge(4, 4);
            intGraph.AddEdge(5, 5);

            intGraph.RemoveNode(6);
            intGraph.RemoveEdge(1, 1);
            intGraph.RemoveEdge(2, 3);



            // Assert
            Assert.Equal(5, intGraph.Nodes.Count());
            Assert.Equal(4, intGraph.Edges.Count());
        }


        [Fact]
        public void GraphE_ADT_Null_AddNode_AddEdge_RemoveNode_RemoveEdge()
        {
            // Arrange
            GraphE<StudentE> intGraph = new GraphE<StudentE>();

            // Act
            intGraph.AddNode(new StudentE(1, "a", 15));
            intGraph.AddNode(new StudentE(2, "b", 16));
            intGraph.AddNode(new StudentE(3, "c", 17));
            intGraph.AddNode(new StudentE(4, "d", 18));
            intGraph.AddNode(new StudentE(5, "e", 19));
            intGraph.AddNode(new StudentE(6, "f", 20));

            intGraph.AddEdge(new StudentE(1, "a", 15), new StudentE(6, "f", 20));
            intGraph.AddEdge(new StudentE(2, "b", 16), new StudentE(6, "f", 20));
            intGraph.AddEdge(new StudentE(3, "c", 17), new StudentE(6, "f", 20));
            intGraph.AddEdge(new StudentE(4, "d", 18), new StudentE(6, "f", 20));
            intGraph.AddEdge(new StudentE(5, "e", 19), new StudentE(6, "f", 20));

            intGraph.AddEdge(new StudentE(1, "a", 15), new StudentE(1, "a", 15));
            intGraph.AddEdge(new StudentE(2, "b", 16), new StudentE(2, "b", 16));
            intGraph.AddEdge(new StudentE(3, "c", 17), new StudentE(3, "c", 17));
            intGraph.AddEdge(new StudentE(4, "d", 18), new StudentE(4, "d", 18));
            intGraph.AddEdge(new StudentE(5, "e", 19), new StudentE(5, "e", 19));

            intGraph.AddEdge(new StudentE(2, "b", 16), new StudentE(3, "c", 17));


            intGraph.RemoveNode(new StudentE(6, "f", 20));
            intGraph.RemoveEdge(new StudentE(1, "a", 15), new StudentE(1, "a", 15));

            intGraph.RemoveEdge(new StudentE(3, "c", 17), new StudentE(2, "b", 16));
            intGraph.RemoveEdge(new StudentE(2, "b", 16), new StudentE(3, "c", 17));


            // Assert
            Assert.Equal(5, intGraph.Nodes.Count());
            Assert.Equal(4, intGraph.Edges.Count());
        }


        [Fact]
        public void GraphE_ADT_Null_Add_Duplicate_Node_Edge()
        {
            // Arrange
            GraphE<StudentE> intGraph = new GraphE<StudentE>();

            // Act

            intGraph.AddNode(new StudentE(1, "a", 15));
            intGraph.AddNode(new StudentE(1, "a", 15));
            intGraph.AddNode(new StudentE(2, "b", 16));
            intGraph.AddNode(new StudentE(3, "c", 17));

            intGraph.AddEdge(new StudentE(1, "a", 15), new StudentE(1, "a", 15));
            intGraph.AddEdge(new StudentE(2, "b", 16), new StudentE(3, "c", 17));
            intGraph.AddEdge(new StudentE(3, "c", 17), new StudentE(2, "b", 16));


            // Assert
            Assert.Equal(3, intGraph.Nodes.Count());
            Assert.Equal(2, intGraph.Edges.Count());
        }
    }
}
