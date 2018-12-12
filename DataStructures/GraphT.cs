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

        public Graph(IEnumerable<INode<T>> nodes, IEnumerable<IEdge<T>> edges)
        {
            _nodes = new HashSet<INode<T>>(nodes);
            _edges = new HashSet<IEdge<T>>(edges);
        }

        public Graph(IEnumerable<INode<T>> nodes,
                    IEnumerable<IEdge<T>> edges,
                    IEqualityComparer<INode<T>> nodeEqualityComparer,
                    IEqualityComparer<IEdge<T>> edgeEqualityComparer)
        {
            _nodes = new HashSet<INode<T>>(nodes, nodeEqualityComparer);
            _edges = new HashSet<IEdge<T>>(edges, edgeEqualityComparer);
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


    }
}