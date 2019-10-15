using System;
using System.Collections.Generic;
using DataStructures;
using Xunit;
using System.Linq;

namespace Tests
{
    public class GraphTest
    {
        [Fact]
        public void Graph_P_Null_AddNode_AddEdge_RemoveNode_RemoveEdge()
        {
            // Arrange
            GraphC<int> intGraph = new GraphC<int>();


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
        public void Graph_ADT_Null_AddNode_AddEdge_RemoveNode_RemoveEdge()
        {
            // Arrange
            GraphC<Student> intGraph = new GraphC<Student>((n1, n2) => n1.ID == n2.ID, n => n.ID.GetHashCode());

            // Act
            intGraph.AddNode(new Student(1, "a", 15));
            intGraph.AddNode(new Student(2, "b", 16));
            intGraph.AddNode(new Student(3, "c", 17));
            intGraph.AddNode(new Student(4, "d", 18));
            intGraph.AddNode(new Student(5, "e", 19));
            intGraph.AddNode(new Student(6, "f", 20));

            intGraph.AddEdge(new Student(1, "a", 15), new Student(6, "f", 20));
            intGraph.AddEdge(new Student(2, "b", 16), new Student(6, "f", 20));
            intGraph.AddEdge(new Student(3, "c", 17), new Student(6, "f", 20));
            intGraph.AddEdge(new Student(4, "d", 18), new Student(6, "f", 20));
            intGraph.AddEdge(new Student(5, "e", 19), new Student(6, "f", 20));

            intGraph.AddEdge(new Student(1, "a", 15), new Student(1, "a", 15));
            intGraph.AddEdge(new Student(2, "b", 16), new Student(2, "b", 16));
            intGraph.AddEdge(new Student(3, "c", 17), new Student(3, "c", 17));
            intGraph.AddEdge(new Student(4, "d", 18), new Student(4, "d", 18));
            intGraph.AddEdge(new Student(5, "e", 19), new Student(5, "e", 19));

            intGraph.AddEdge(new Student(2, "b", 16), new Student(3, "c", 17));


            intGraph.RemoveNode(new Student(6, "f", 20));
            intGraph.RemoveEdge(new Student(1, "a", 15), new Student(1, "a", 15));
            //intGraph.RemoveEdge(new Student(3, "c", 17), new Student(2, "b", 16));
            intGraph.RemoveEdge(new Student(2, "b", 16), new Student(3, "c", 17));


            // Assert
            Assert.Equal(5, intGraph.Nodes.Count());
            Assert.Equal(4, intGraph.Edges.Count());
        }

    }
}
