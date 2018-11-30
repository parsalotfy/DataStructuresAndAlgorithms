namespace DataStructures
{
    public class Edge<T> : IEdge<T>
    {
        public INode<T> A_Node { get; set; }
        public INode<T> Another_Node { get; set; }
    }
}