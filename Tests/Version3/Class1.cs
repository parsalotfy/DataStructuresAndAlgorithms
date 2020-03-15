using DataStructures.Version3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests.Version3
{
    public class Class1
    {
        [Fact]
        public void UnilateralWeightedEdgeE3Test()
        {
            Unilateral_WeightedEdgeE3<StudentE> e3 = new Unilateral_WeightedEdgeE3<StudentE>(new StudentE(1, "a", 15), new StudentE(6, "f", 20) , 5);
            

        }
    }
}
