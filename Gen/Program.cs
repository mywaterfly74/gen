using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeap<double> maxBinaryHeap = new MaxBinaryHeap<double>();
            maxBinaryHeap.Insert(15);
            maxBinaryHeap.Insert(11);
            maxBinaryHeap.Insert(6);
            maxBinaryHeap.Insert(9);
            maxBinaryHeap.Insert(7);
            maxBinaryHeap.Insert(8);
            maxBinaryHeap.Insert(1);
            maxBinaryHeap.Insert(3);
            maxBinaryHeap.Insert(5);
            maxBinaryHeap.Insert(17);

            for (int i = 0; i < maxBinaryHeap.HeapSize; i++)
            {
                Console.WriteLine(maxBinaryHeap.ValuesOfBinaryHeap[i]);
            }
            /*MinBinaryHeap<double> minBinaryHeap = new MinBinaryHeap<double>();
            minBinaryHeap.Insert(15);
            minBinaryHeap.Insert(11);
            minBinaryHeap.Insert(6);
            minBinaryHeap.Insert(9);
            minBinaryHeap.Insert(7);
            minBinaryHeap.Insert(8);
            minBinaryHeap.Insert(1);
            minBinaryHeap.Insert(3);
            minBinaryHeap.Insert(5);
            minBinaryHeap.Insert(17);

            for (int i = 0; i < minBinaryHeap.HeapSize; i++)
            {
                Console.WriteLine(minBinaryHeap.ValuesOfBinaryHeap[i]);
            }*/
            Console.ReadKey();
        }

    }
}