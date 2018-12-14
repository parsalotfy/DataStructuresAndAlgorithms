using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Graph<T> : IGraph<T>
    {

        public Graph()
        {
            _nodes = new HashSet<INode<T>>();
            _edges = new HashSet<IEdge<T>>();
        }

        public Graph(IEqualityComparer<INode<T>> nodeEqualityComparer,
                     IEqualityComparer<IEdge<T>> edgeEqualityComparer)
        {
            _nodes = new HashSet<INode<T>>(nodeEqualityComparer);
            _edges = new HashSet<IEdge<T>>(edgeEqualityComparer);
        }

        public Graph(Func<INode<T>, INode<T>, bool> nodeEqualityMethod,
                    Func<INode<T>, int> nodeGetHashCodeMethod,
                    Func<IEdge<T>, IEdge<T>, bool> edgeEqualityMethod,
                    Func<IEdge<T>, int> edgeGetHashCodeMethod)
        {
            TEqualityComparer<INode<T>> nodeComparer =
            new TEqualityComparer<INode<T>>(nodeEqualityMethod, nodeGetHashCodeMethod);

            TEqualityComparer<IEdge<T>> edgeComparer =
            new TEqualityComparer<IEdge<T>>(edgeEqualityMethod, edgeGetHashCodeMethod);

            _nodes = new HashSet<INode<T>>(nodeComparer);
            _edges = new HashSet<IEdge<T>>(edgeComparer);
        }

        public Graph(IEnumerable<INode<T>> nodes, IEnumerable<IEdge<T>> edges)
        {
            _nodes = new HashSet<INode<T>>(nodes);
            _edges = new HashSet<IEdge<T>>(edges);
        }

        public Graph(IEnumerable<INode<T>> nodes,
                    IEnumerable<IEdge<T>> edges,
                    Func<INode<T>, INode<T>, bool> nodeEqualityMethod,
                    Func<INode<T>, int> nodeGetHashCodeMethod,
                    Func<IEdge<T>, IEdge<T>, bool> edgeEqualityMethod,
                    Func<IEdge<T>, int> edgeGetHashCodeMethod)
        {
            TEqualityComparer<INode<T>> nodeComparer =
            new TEqualityComparer<INode<T>>(nodeEqualityMethod, nodeGetHashCodeMethod);

            TEqualityComparer<IEdge<T>> edgeComparer =
            new TEqualityComparer<IEdge<T>>(edgeEqualityMethod, edgeGetHashCodeMethod);

            _nodes = new HashSet<INode<T>>(nodes, nodeComparer);
            _edges = new HashSet<IEdge<T>>(edges, edgeComparer);
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

        public bool RemoveNode(INode<T> node, out int numberOfDeletedINodes)
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