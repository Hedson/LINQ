using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    class LINQQueryExpressions
    {
        static void Main()
        {

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60, 111 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score == 111 || score == 81
                select score;

            // Executte the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
