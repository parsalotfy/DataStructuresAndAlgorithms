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
        public void Graph_P_Null_AddNode_AddEdge()
        {
            // Arrange
            Graph<int> intGraph = new Graph<int>();


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

    }
}
