﻿using DataStructures;
using Xunit;

namespace Tests
{
    public class NodeTest
    {
        [Fact]
        public void Node_Constructor_Test()
        {
            // Arrange
            Node<object> n = new Node<object>(5);

            // Act

            // Assert
            Assert.Equal(5, n.Value);
        }

        [Fact]
        public void Node_Setter_Test()
        {
            // Arrange
            Node<object> n = new Node<object>(6);

            // Act

            // Assert
            Assert.Equal(6, n.Value);
        }
    }
}
