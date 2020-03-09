using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class GraphE<T> : IGraphE<T> where T : IEquatable<T>
    {

        #region Constructors

        // Primitive Graph Null
        public GraphE()
        {
            _nodes = new HashSet<T>();
            _edges = new HashSet<IEdgeE<T>>();
        }

        // Primitive Graph Node
        public GraphE(IEnumerable<T> nodes) : this()
        {
            _nodes.UnionWith(nodes);
        }

        // Primitive Graph Node+Edge
        public GraphE(IEnumerable<T> nodes, IEnumerable<IEdgeE<T>> edges) : this(nodes)
        {
            _edges.UnionWith(edges);
        }

        #endregion Constructors


        #region Properties

        private readonly HashSet<T> _nodes;
        public ISet<T> Nodes
        {
            get { return _nodes; }
        }

        private readonly HashSet<IEdgeE<T>> _edges;
        public ISet<IEdgeE<T>> Edges
        {
            get { return _edges; }
        }

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

        public bool AddEdge(IEdgeE<T> edge)
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
            return AddEdge(new EdgeE<T>(aNode, anotherNode));
        }

        public bool RemoveNode(T node)
        {
            if (_nodes.RemoveWhere(n => n.Equals(node)) > 0)
            {
                _edges.RemoveWhere(e => e.A_Node.Equals(node) || e.Another_Node.Equals(node));

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

        public bool RemoveEdge(IEdgeE<T> edge)
        {
            return _edges.RemoveWhere(e => e.Equals(edge)) > 0;
        }

        public bool RemoveEdge(T aNode, T anotherNode)
        {
            return RemoveEdge(new EdgeE<T>(aNode, anotherNode));
        }

        public void ClearGraph()
        {
            _edges.Clear();
            _nodes.Clear();
        }

        #endregion Methods

    }
}