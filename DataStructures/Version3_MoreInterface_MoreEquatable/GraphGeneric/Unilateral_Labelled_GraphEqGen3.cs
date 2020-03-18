using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Version3_MoreInterface_MoreEquatable.GraphGeneric
{
    public class Unilateral_Labelled_GraphEqGen3<T> : IGraphEqGen3<Unilateral_LabelledEdgeE3<T>, T> where T : IEquatable<T>
    {

        #region Constructors

        // Primitive Graph Null
        public Unilateral_Labelled_GraphEqGen3()
        {
            _nodes = new HashSet<T>();
            _edges = new HashSet<Unilateral_LabelledEdgeE3<T>>();
        }

        // Primitive Graph Node
        public Unilateral_Labelled_GraphEqGen3(ISet<T> nodes) : this()
        {
            _nodes.UnionWith(nodes);
        }

        // Primitive Graph Node+Edge
        public Unilateral_Labelled_GraphEqGen3(ISet<T> nodes, ISet<Unilateral_LabelledEdgeE3<T>> edges) : this(nodes)
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

        private readonly HashSet<Unilateral_LabelledEdgeE3<T>> _edges;
        public ISet<Unilateral_LabelledEdgeE3<T>> Edges
        {
            get { return _edges; }
        }

        #endregion Properties


        #region Methods

        public bool AddNode(T node)
        {
            return _nodes.Add(node);
        }

        public bool AddEdge(Unilateral_LabelledEdgeE3<T> edge)
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

        public bool RemoveEdge(Unilateral_LabelledEdgeE3<T> edge)
        {
            return _edges.RemoveWhere(e => e.Equals(edge)) > 0;
        }

        public void ClearGraph()
        {
            _edges.Clear();
            _nodes.Clear();
        }

        #endregion Methods


        #region Non-Interface

        // Not sure about this method.
        public void AddNode(params T[] nodes)
        {
            foreach (T node in nodes)
            {
                AddNode(node);
            }
        }

        public bool AddEdge(T source, T target, string label)
        {
            return AddEdge(new Unilateral_LabelledEdgeE3<T>(source, target, label));
        }

        // Not sure about this method.
        public void RemoveNode(params T[] nodes)
        {
            foreach (T node in nodes)
            {
                RemoveNode(node);
            }
        }

        public bool RemoveEdge(T aNode, T anotherNode, string label)
        {
            return RemoveEdge(new Unilateral_LabelledEdgeE3<T>(aNode, anotherNode, label));
        }

        #endregion Non-Interface

    }
}
