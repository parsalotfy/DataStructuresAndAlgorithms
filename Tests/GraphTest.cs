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
        public void Graph_int_AddEdge_Test()
        {
            // Arrange
            Graph<int> intGraph = new Graph<int>((n1, n2) => n1.Value == n2.Value,
                                                n => n.Value.GetHashCode(),
                                                (e1, e2) => e1.A_Node.Value == e2.A_Node.Value &&
                                                e1.Another_Node.Value == e2.Another_Node.Value,
                                                e => e.A_Node.GetHashCode() ^
                                                e.Another_Node.GetHashCode());


            // Act
            intGraph.AddEdge(new Edge<int>(1, 6));
            intGraph.AddEdge(new Edge<int>(2, 6));
            intGraph.AddEdge(new Edge<int>(3, 6));
            intGraph.AddEdge(new Edge<int>(4, 6));
            intGraph.AddEdge(new Edge<int>(5, 6));


            // Assert
            Assert.Equal(6, intGraph.Nodes.Count());
            Assert.Equal(5, intGraph.Edges.Count());
        }



        [Fact]
        public void Graph_int_RemoveNode_Test()
        {
            // Arrange
            Graph<int> intGraph = new Graph<int>((n1, n2) => n1.Value == n2.Value,
                                                n => n.Value.GetHashCode(),
                                                (e1, e2) => e1.A_Node.Value == e2.A_Node.Value &&
                                                e1.Another_Node.Value == e2.Another_Node.Value,
                                                e => e.A_Node.GetHashCode() ^
                                                e.Another_Node.GetHashCode());
            intGraph.AddEdge(new Edge<int>(1, 6));
            intGraph.AddEdge(new Edge<int>(2, 6));
            intGraph.AddEdge(new Edge<int>(3, 6));
            intGraph.AddEdge(new Edge<int>(4, 6));
            intGraph.AddEdge(new Edge<int>(5, 6));

            // Act
            int result;
            bool isdeleted = intGraph.RemoveNode(new Node<int>(6), out result);


            Assert.Equal(5,intGraph.Nodes.Count());
            Assert.Equal(0,intGraph.Edges.Count());
        }
    }
}
