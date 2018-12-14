using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Graph<T> : IGraph<T>
    {
        public Graph(IEqualityComparer<INode<T>> nodeEqualityComparer,
                     IEqualityComparer<IEdge<T>> edgeEqualityComparer)
        {
            _nodes = new HashSet<INode<T>>(nodeEqualityComparer);
            _edges = new HashSet<IEdge<T>>(edgeEqualityComparer);

            NodeTEqualityComparer = nodeEqualityComparer;
            EdgeTEqualityComparer = edgeEqualityComparer;
        }

        public Graph(
            Func<INode<T>, INode<T>, bool> nodeEqualityMethod,
            Func<INode<T>, int> nodeGetHashCodeMethod,
            Func<IEdge<T>, IEdge<T>, bool> edgeEqualityMethod,
            Func<IEdge<T>, int> edgeGetHashCodeMethod) : this(
                new TEqualityComparer<INode<T>>(nodeEqualityMethod, nodeGetHashCodeMethod),
                new TEqualityComparer<IEdge<T>>(edgeEqualityMethod, edgeGetHashCodeMethod)
                )
        {

        }


        public Graph(
            IEnumerable<INode<T>> nodes,
            IEnumerable<IEdge<T>> edges,
            IEqualityComparer<INode<T>> nodeEqualityComparer,
            IEqualityComparer<IEdge<T>> edgeEqualityComparer)
        {
            _nodes = new HashSet<INode<T>>(nodes, nodeEqualityComparer);
            _edges = new HashSet<IEdge<T>>(edges, edgeEqualityComparer);

            NodeTEqualityComparer = nodeEqualityComparer;
            EdgeTEqualityComparer = edgeEqualityComparer;
        }


        public Graph(IEnumerable<INode<T>> nodes,
                    IEnumerable<IEdge<T>> edges,
                    Func<INode<T>, INode<T>, bool> nodeEqualityMethod,
                    Func<INode<T>, int> nodeGetHashCodeMethod,
                    Func<IEdge<T>, IEdge<T>, bool> edgeEqualityMethod,
                    Func<IEdge<T>, int> edgeGetHashCodeMethod) : this(
                        nodes,
                        edges,
                        new TEqualityComparer<INode<T>>(nodeEqualityMethod, nodeGetHashCodeMethod),
                        new TEqualityComparer<IEdge<T>>(edgeEqualityMethod, edgeGetHashCodeMethod)
                    )
        {

        }





        private HashSet<INode<T>> _nodes;
        public IEnumerable<INode<T>> Nodes
        {
            get { return _nodes; }
        }

        private HashSet<IEdge<T>> _edges;
        public IEnumerable<IEdge<T>> Edges
        {
            get { return _edges; }
        }


        public IEqualityComparer<INode<T>> NodeTEqualityComparer { get; }
        public IEqualityComparer<IEdge<T>> EdgeTEqualityComparer { get; }




        public bool AddNode(INode<T> node)
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

        public bool RemoveNode(INode<T> node, out int numberOfDeletedIEdges)
        {
            if (_nodes.Remove(node) == true)
            {
                numberOfDeletedIEdges = _edges.RemoveWhere(e =>
                        NodeTEqualityComparer.Equals(e.A_Node, node) ||
                        NodeTEqualityComparer.Equals(e.Another_Node, node));

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


    }
}