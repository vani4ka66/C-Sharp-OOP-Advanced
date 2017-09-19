using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2017
{

    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i += 2)
            {
                yield return stones[i];
            }
            for (int i = stones.Count - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));

        }
    }
}
