// From scratch

class Queues
{
    private ArrayList pqueue;
    public Queues() { pqueue = new ArrayList(); }
    public void EnQueue(object item) { pqueue.Add(item); }
    public void DeQueue() { pqueue.RemoveAt(0); }
    public object Peek() { return pqueue[0]; }
    public void ClearQueue() { pqueue.Clear(); }
    public int Count() { return pqueue.Count; }
}


/********** Main Test **********/
static void Main(string[] args)
{
    Queues qu = new Queues();

    qu.EnQueue("1");
    qu.EnQueue(2);
    qu.EnQueue(3);
    qu.EnQueue("four");

    Console.WriteLine(qu.Count());
    Console.WriteLine(qu.Peek());
    qu.DeQueue();
    Console.WriteLine(qu.Count());

    qu.ClearQueue();
    if(qu.Count() == 0)
        Console.WriteLine("Queues is clear");

}
