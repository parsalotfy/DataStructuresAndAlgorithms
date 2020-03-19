using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3.GraphGeneric
{
    public class Unilateral_GraphEqGen3<T> : IGraphEqGen3<Unilateral_EdgeE3<T>, T> where T : IEquatable<T>
    {
        #region Constructors

        // Primitive Graph Null
        public Unilateral_GraphEqGen3()
        {
            _nodes = new HashSet<T>();
            _edges = new HashSet<Unilateral_EdgeE3<T>>();
        }

        // Primitive Graph Node
        public Unilateral_GraphEqGen3(ISet<T> nodes) : this()
        {
            _nodes.UnionWith(nodes);
        }

        // Primitive Graph Node+Edge
        public Unilateral_GraphEqGen3(ISet<T> nodes, ISet<Unilateral_LabelledEdgeE3<T>> edges) : this(nodes)
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

        private readonly HashSet<Unilateral_EdgeE3<T>> _edges;
        public ISet<Unilateral_EdgeE3<T>> Edges
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


        public bool AddEdge(Unilateral_EdgeE3<T> edge)
        {
            if (_edges.Add(edge) == true)
            {
                AddNode(edge.Source);
                AddNode(edge.Target);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddEdge(T source, T target)
        {
            return AddEdge(new Unilateral_EdgeE3<T>(source, target));
        }

        public bool RemoveNode(T node)
        {
            if (_nodes.RemoveWhere(n => n.Equals(node)) > 0)
            {
                _edges.RemoveWhere(e => e.Source.Equals(node) || e.Target.Equals(node));

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

        public bool RemoveEdge(Unilateral_EdgeE3<T> edge)
        {
            return _edges.RemoveWhere(e => e.Equals(edge)) > 0;
        }

        public bool RemoveEdge(T aNode, T anotherNode)
        {
            return RemoveEdge(new Unilateral_EdgeE3<T>(aNode, anotherNode));
        }

        public void ClearGraph()
        {
            _edges.Clear();
            _nodes.Clear();
        }

        #endregion Methods

    }
}
