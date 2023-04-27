using static System.Console;
class Program
{
    static void Main()
    {
        Task3();
    }
    static void Task3()
    {
        SLL sll = new SLL();//create an instance
        int[] a = GenerateUniqueNumbers(10);
        foreach (int i in a)
        {
            sll.AddFirst(i); 
        }
        //a.ToList().ForEach(n=>Write(n + " "));
        //WriteLine("SLL nodes");//title of printSLL
        PrintSLL(sll.Head);
        WriteLine($"SLL length: {GetSLLSize(sll.Head)}");
        FindSLLMiddle(sll.Head);
        Write("The algorithm to find the middle node of an SLL begins with traversing the whole linked list and count the number of nodes.");
    }
    static void PrintSLL(SLLNode? node)
    {
        if(node == null) return;
        SLLNode? t = node;
        //WriteLine();//empty line
        while(t != null){//node contains number
            Write(t.Num + " ");
            t = t.Next;//move t to its successor
        }
        WriteLine();
    }
    static int GetSLLSize(SLLNode? node)//find length
    {
        SLLNode? t = node;
        int i = 0;
        while(t != null){
            t = t.Next;
            i++;//increase the i value
        }
        return i;
    }

    static void FindSLLMiddle(SLLNode? node)
    //to find middle number, we have to divide whole legnth by 2.
    {
        // //GetSLLSize(t); //this result is equal to 10.
        // if(node == null) return;
        // SLLNode? t = node;
        // int i = 0;
        // while(t != null && i <= GetSLLSize(t)/2)//whole liked size divide 2: two get middle and (+ 1) to get the next middle one. 
        // {
        //     i++;//if we run this loop, i is increasing 1 by 1.
        //     t = t.Next;
        // }
        // WriteLine($"Middle node: {t.Num}");

        SLLNode? t = node;
        if (t != null) {
            int i = GetSLLSize(t);
            int mid = i / 2;
            while (mid != 0 && t != null) {
                t = t.Next;
                mid--;
            }
            if (t != null) 
            Console.WriteLine($"Middle node: {t.Num}");
        }
    }
    static int [] GenerateUniqueNumbers(int size)
    {
        Random random = new Random();
        HashSet<int> values = new HashSet<int>();
        while (true){
            values.Add(random.Next(1, 100));
            if(values.Count == size) break;
        }
        return values.ToArray();
    }
}
class SLL
{
    public SLLNode? Head {get; set;}
    public SLLNode? Tail {get; set;}

    public SLL()
    {
        Head = Tail = null;
    }
    public void AddFirst(int e)
    {
        SLLNode node = new SLLNode(e);
        if (Head == null) //empty list
        {
            Head = Tail = node;
        }
        else
        {
            node.Next = Head;
            Head = node; //update the Head
        }
    }
}
class SLLNode
{
    public int Num {get; set;}
    public SLLNode? Next {get; set;}
    public SLLNode(int elem)
    {
        this.Num = elem;
    }
}