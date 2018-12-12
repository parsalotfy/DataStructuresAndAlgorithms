using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Graph : IGraph
    {
        // public Graph()
        // {
        //     _nodes = new HashSet<INode>();
        //     _edges = new HashSet<IEdge>();
        // }

        public Graph(IEqualityComparer<INode> nodeEqualityComparer,
                     IEqualityComparer<IEdge> edgeEqualityComparer)
        {
            _nodes = new HashSet<INode>(nodeEqualityComparer);
            _edges = new HashSet<IEdge>(edgeEqualityComparer);
        }

        public Graph(IEnumerable<INode> nodes, IEnumerable<IEdge> edges)
        {
            _nodes = new HashSet<INode>(nodes);
            _edges = new HashSet<IEdge>(edges);
        }

        public Graph(IEnumerable<INode> nodes,
                    IEnumerable<IEdge> edges,
                    IEqualityComparer<INode> nodeEqualityComparer,
                    IEqualityComparer<IEdge> edgeEqualityComparer)
        {
            _nodes = new HashSet<INode>(nodes, nodeEqualityComparer);
            _edges = new HashSet<IEdge>(edges, edgeEqualityComparer);
        }


        private HashSet<INode> _nodes;
        public IEnumerable<INode> Nodes { get { return _nodes; } }


        private HashSet<IEdge> _edges;
        public IEnumerable<IEdge> Edges { get { return _edges; } }


        public bool AddNode(INode node)
        {
            return _nodes.Add(node);
        }

        public bool AddEdge(IEdge edge)
        {
            if (_edges.Add(edge) == true)
            {
                AddNode(edge.A_Node);
                AddNode(edge.Another_Node);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveNode(INode node, out int numberOfDeletedINodes)
        {
            if (_nodes.Remove(node) == true)
            {
                numberOfDeletedINodes = _edges.RemoveWhere(e => e.A_Node == node || 
                                                            e.Another_Node == node);
                return true;
            }
            else
            {
                numberOfDeletedINodes = 0;
                return false;
            }

        }


        public bool RemoveEdge(IEdge edge)
        {
            return _edges.Remove(edge);
        }

    }
}