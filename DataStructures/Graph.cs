using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Graph<T> : IGraph<T>
    {
        #region Constructors

        public Graph(IEqualityComparer<T> nodeEqualityComparer)
        {
            _nodes = new HashSet<T>(nodeEqualityComparer);
            TEqualityComparer<IEdge<T>> edgeEqualityComparer = new TEqualityComparer<IEdge<T>>
            (
                (e1, e2) =>
                (nodeEqualityComparer.Equals(e1.A_Node, e2.A_Node) && nodeEqualityComparer.Equals(e1.Another_Node, e2.Another_Node)) ||
                (nodeEqualityComparer.Equals(e1.A_Node, e2.Another_Node) && nodeEqualityComparer.Equals(e1.Another_Node, e2.A_Node)),
                (e) => nodeEqualityComparer.GetHashCode(e.A_Node) ^ nodeEqualityComparer.GetHashCode(e.Another_Node)
            );
            _edges = new HashSet<IEdge<T>>(edgeEqualityComparer);

            _nodeTEqualityComparer = nodeEqualityComparer;
        }


        public Graph(
            Func<T, T, bool> nodeEqualityMethod,
            Func<T, int> nodeGetHashCodeMethod)
            : this(new TEqualityComparer<T>(nodeEqualityMethod, nodeGetHashCodeMethod))
        {

        }


        public Graph(
            IEnumerable<T> nodes,
            IEnumerable<IEdge<T>> edges,
            IEqualityComparer<T> nodeEqualityComparer)
            : this(nodeEqualityComparer)
        {
            _nodes.UnionWith(nodes);
            _edges.UnionWith(edges);
        }


        public Graph(IEnumerable<T> nodes,
                    IEnumerable<IEdge<T>> edges,
                    Func<T, T, bool> nodeEqualityMethod,
                    Func<T, int> nodeGetHashCodeMethod)
            : this(nodes, edges, new TEqualityComparer<T>(nodeEqualityMethod, nodeGetHashCodeMethod))
        {

        }

        #endregion Constructors


        #region Properties

        private HashSet<T> _nodes;
        public IEnumerable<T> Nodes
        {
            get { return _nodes; }
        }

        private HashSet<IEdge<T>> _edges;
        public IEnumerable<IEdge<T>> Edges
        {
            get { return _edges; }
        }

        private readonly IEqualityComparer<T> _nodeTEqualityComparer;

        #endregion Properties


        #region Methods

        public bool AddNode(T node)
        {
            return _nodes.Add(node);
        }

        public bool AddEdge(IEdge<T> edge)
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

        public bool AddEdge(T aNode, T anotherNode)
        {
            return AddEdge(new Edge<T>(aNode, anotherNode));
        }

        public bool RemoveNode(T node, out int numberOfDeletedIEdges)
        {
            if (_nodes.Remove(node) == true)
            {
                numberOfDeletedIEdges = _edges.RemoveWhere(e =>
                        _nodeTEqualityComparer.Equals(e.A_Node, node) ||
                        _nodeTEqualityComparer.Equals(e.Another_Node, node));

                return true;
            }
            else
            {
                numberOfDeletedIEdges = 0;
                return false;
            }
        }


        public bool RemoveEdge(IEdge<T> edge)
        {
            return _edges.Remove(edge);
        }

        public void ClearGraph()
        {
            _edges.Clear();
            _nodes.Clear();
        }

        #endregion Methods

    }
}