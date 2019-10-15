using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class GraphC<T> : IGraphC<T>
    {
        #region Constructors

        // Primitive Graph Null
        public GraphC()
        {
            _nodeTEqualityComparer = new TEqualityComparer<T>((n1, n2) => n1.Equals(n2), (n) => n.GetHashCode());
            _edgeTEqualityComparer = new TEqualityComparer<IEdgeC<T>>
            (
                (e1, e2) =>
                (e1.A_Node.Equals(e2.A_Node) && e1.Another_Node.Equals(e2.Another_Node)) ||
                (e1.A_Node.Equals(e2.Another_Node) && e1.Another_Node.Equals(e2.A_Node)),
                (e) => e.A_Node.GetHashCode() ^ e.Another_Node.GetHashCode()
            );

            _nodes = new HashSet<T>(_nodeTEqualityComparer);
            _edges = new HashSet<IEdgeC<T>>(_edgeTEqualityComparer);
        }

        // Primitive Graph Node
        public GraphC(IEnumerable<T> nodes) : this()
        {
            _nodes.UnionWith(nodes);
        }

        // Primitive Graph Node+Edge
        public GraphC(IEnumerable<T> nodes, IEnumerable<IEdgeC<T>> edges) : this(nodes)
        {
            _edges.UnionWith(edges);
        }



        // ADT Graph Null
        public GraphC(IEqualityComparer<T> nodeEqualityComparer)
        {
            TEqualityComparer<IEdgeC<T>> edgeEqualityComparer = new TEqualityComparer<IEdgeC<T>>
            (
                (e1, e2) =>
                (nodeEqualityComparer.Equals(e1.A_Node, e2.A_Node) && nodeEqualityComparer.Equals(e1.Another_Node, e2.Another_Node)) ||
                (nodeEqualityComparer.Equals(e1.A_Node, e2.Another_Node) && nodeEqualityComparer.Equals(e1.Another_Node, e2.A_Node)),
                (e) => nodeEqualityComparer.GetHashCode(e.A_Node) ^ nodeEqualityComparer.GetHashCode(e.Another_Node)
            );

            _nodeTEqualityComparer = nodeEqualityComparer;
            _edgeTEqualityComparer = edgeEqualityComparer;

            _nodes = new HashSet<T>(nodeEqualityComparer);
            _edges = new HashSet<IEdgeC<T>>(edgeEqualityComparer);
        }


        // ADT Graph Null(Lambada)
        public GraphC(
            Func<T, T, bool> nodeEqualityMethod,
            Func<T, int> nodeGetHashCodeMethod)
            : this(new TEqualityComparer<T>(nodeEqualityMethod, nodeGetHashCodeMethod))
        {

        }

        // ADT Graph Node
        public GraphC(
            IEnumerable<T> nodes,
            IEqualityComparer<T> nodeEqualityComparer)
            : this(nodeEqualityComparer)
        {
            _nodes.UnionWith(nodes);
        }

        // ADT Graph Node(Lambada)
        public GraphC(
            IEnumerable<T> nodes,
            Func<T, T, bool> nodeEqualityMethod,
            Func<T, int> nodeGetHashCodeMethod)
            : this(nodes, new TEqualityComparer<T>(nodeEqualityMethod, nodeGetHashCodeMethod))
        {

        }


        // ADT Graph Node+Edge
        public GraphC(
            IEnumerable<T> nodes,
            IEnumerable<IEdgeC<T>> edges,
            IEqualityComparer<T> nodeEqualityComparer)
            : this(nodes, nodeEqualityComparer)
        {
            _edges.UnionWith(edges);
        }


        // ADT Graph Node+Edge(Lambada)
        public GraphC(
            IEnumerable<T> nodes,
            IEnumerable<IEdgeC<T>> edges,
            Func<T, T, bool> nodeEqualityMethod,
            Func<T, int> nodeGetHashCodeMethod)
            : this(nodes, edges, new TEqualityComparer<T>(nodeEqualityMethod, nodeGetHashCodeMethod))
        {

        }

        #endregion Constructors


        #region Properties

        private HashSet<T> _nodes;
        public ISet<T> Nodes
        {
            get { return _nodes; }
        }

        private HashSet<IEdgeC<T>> _edges;
        public ISet<IEdgeC<T>> Edges
        {
            get { return _edges; }
        }

        private readonly IEqualityComparer<T> _nodeTEqualityComparer;
        private readonly IEqualityComparer<IEdgeC<T>> _edgeTEqualityComparer;

        #endregion Properties


        #region Methods

        public bool AddNode(T node)
        {
            return _nodes.Add(node);
        }

        // Not sure about this method.
        public void AddNode(params T[] nodes)
        {
            foreach (T node in nodes)
            {
                AddNode(node);
            }
        }

        public bool AddEdge(IEdgeC<T> edge)
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
            return AddEdge(new EdgeC<T>(aNode, anotherNode));
        }

        // Not sure about this method.
        public bool RemoveNode(T node, out int numberOfDeletedIEdges)
        {

            if (_nodes.RemoveWhere(n => _nodeTEqualityComparer.Equals(n, node)) > 0)
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

        public bool RemoveNode(T node)
        {
            if (_nodes.RemoveWhere(n => _nodeTEqualityComparer.Equals(n, node)) > 0)
            {
                _edges.RemoveWhere(e =>
                           _nodeTEqualityComparer.Equals(e.A_Node, node) ||
                           _nodeTEqualityComparer.Equals(e.Another_Node, node));

                return true;
            }
            else
            {
                return false;
            }
        }

        // Not sure about this method.
        public void RemoveNode(params T[] nodes)
        {
            foreach (T node in nodes)
            {
                RemoveNode(node);
            }
        }

        public bool RemoveEdge(IEdgeC<T> edge)
        {
            return _edges.RemoveWhere(e => _edgeTEqualityComparer.Equals(e, edge)) > 0;
        }

        public bool RemoveEdge(T aNode, T anotherNode)
        {
            return RemoveEdge(new EdgeC<T>(aNode, anotherNode));
        }

        public void ClearGraph()
        {
            _edges.Clear();
            _nodes.Clear();
        }

        #endregion Methods

    }
}