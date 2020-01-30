using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Node
{
    public int key;
    public Node next;
    public Node(int key)
    {
        this.key = key;
        this.next = null;
    }
}
class Queue
{
    Node front, rear;

    public Queue()
    {
        this.front = this.rear = null;
    }
    public void enqueue(int key)
    {

        Node temp = new Node(key);
        if (this.rear == null)
        {
            this.front = this.rear = temp;
            return;
        }
        this.rear.next = temp;
        this.rear = temp;
    }
    public Node dequeue()
    {
        if (this.front == null)
            return null;
        Node temp = this.front;
        this.front = this.front.next;
        if (this.front == null)
            this.rear = null;
        return temp;
    }
}
public class Test
{
    public static void Main(String[] args)
    {
        Queue q = new Queue();
        q.enqueue(10);
        q.enqueue(20);
        q.dequeue();
        q.dequeue();
        q.enqueue(30);
        q.enqueue(40);
        q.enqueue(50);

        Console.WriteLine("Dequeued item is " + q.dequeue().key);
    }
}