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
        public void EdgeT_Value_Test()
        {
            Graph g = new Graph(INodeEqualityComparer.Instance, IEdgeEqualityComparer.Instance);

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(1);


            HashSet<INode> nodes = new HashSet<INode>(INodeEqualityComparer.Instance);
            nodes.Add(n1);
            nodes.Add(n2);
            nodes.Add(n3);
            nodes.Add(n4);




            g.AddNode(n1);
            g.AddNode(n2);
            g.AddNode(n3);
            g.AddNode(n4);

            // g.AddEdge(new Edge(n1, n6));
            // g.AddEdge(new Edge(n2, n6));
            // g.AddEdge(new Edge(n3, n6));
            // g.AddEdge(new Edge(n4, n6));
            // g.AddEdge(new Edge(n5, n6));
            // g.AddEdge(new Edge(n7, n6));

            Assert.True(true);


        }
    }

}
