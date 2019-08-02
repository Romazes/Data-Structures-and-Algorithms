// Deriving From the Queue Class

using System;
using System.Collections;

namespace LeetCodeFirstTry
{
    public struct pqItem
    {
        public int priority;
        public string name;
    }
    public class PQueue : Queue
    {
        public PQueue() : base()
        { }

        public override object Dequeue()
        {
            object[] items;
            int x, min;
            int minindex = 0;
            items = this.ToArray();

            min = ((pqItem)items[0]).priority;
            for (x = 1; x <= items.GetUpperBound(0); x++)
                if (((pqItem)items[x]).priority < min)
                {
                    min = ((pqItem)items[x]).priority;
                    minindex = x;
                }
            this.Clear();
            for (x = 0; x <= items.GetUpperBound(0); x++)
                if (x != minindex && ((pqItem)items[x]).name != "")
                    this.Enqueue(items[x]);
            return items[minindex];
        }
    }
}

/********** MAIN TEST **********/
*The following program simulates three patients entering an emergency room at approximately the same time
*/
static void Main(string[] args)
{

    PQueue erwait = new PQueue();
    pqItem[] erPatient = new pqItem[3];
    pqItem nextPatient;

    erPatient[0].name = "Joe Smith";
    erPatient[0].priority = 1;

    erPatient[1].name = "Mary Brown";
    erPatient[1].priority = 0;

    erPatient[2].name = "Sam Jones";
    erPatient[2].priority = 3;

    for (int x = 0; x <= erPatient.GetUpperBound(0); x++)
        erwait.Enqueue(erPatient[x]);
    nextPatient = (pqItem)erwait.Dequeue();
    Console.WriteLine(nextPatient.name);
}
