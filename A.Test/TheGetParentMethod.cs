using Xunit;
using Moq;
using B;

namespace A.Test
{

    public class TheGetParentMethod
    {
        [Fact]
        public void TestMethod1()
        {
            var grandparent = new Grandparent();
            var expectedType = typeof(Parent);

            var result = grandparent.GetParent();

            var resultType = result.GetType();
            Assert.True(resultType.Equals(expectedType));            
        }
    }
}
