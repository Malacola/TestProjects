using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ScratchPad
{
    public class Expressions
    {
        public void Go()
        {
            Func<string, string, string> combine = (a, b) => a.ToLower() + b.ToUpper();
            var one = "One";
            var two = "Two";
            var combined = combine(one, two);

            Expression<Func<string, string, string>> tree = (a, b) => a.ToLower() + b.ToUpper();

            Console.WriteLine("Parameter count: {0}", tree.Parameters.Count);
            foreach (var param in tree.Parameters)
                Console.WriteLine("\tParameter Name: {0}", param.Name);

            var body = (BinaryExpression)tree.Body;
            Console.WriteLine("Binary Expression Type: {0}", body.NodeType);
            Console.WriteLine("Method to be called: {0}", body.Method);
            Console.WriteLine("Return Type: {0}", tree.ReturnType);
        }
    }
}
