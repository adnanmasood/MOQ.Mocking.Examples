using System;
using Moq;

//A preliminary example based on http://blog.adnanmasood.com/2010/05/02/mock-objects-101/
namespace Avantgarde.Moq.Examples
{
    public interface IMathClass
    {
        int Sum(int a, int b);
    }

    public class MathClass : IMathClass
    {
        public int Sum(int a, int b)
        {
            return (a + b);
        }
    }

    public class MatchTestClass
    {
        public void MathTest()
        {
            var mock = new Mock<IMathClass>();

            mock.Setup(s => s.Sum(1, 10)).Returns(10);
            Console.Write("{0}", mock.Object.Sum(1, 10));

            //Actual Object
            var obj = new MathClass();
            Console.Write("{0}", obj.Sum(1, 10));
        }
    }
}