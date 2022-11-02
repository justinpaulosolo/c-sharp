namespace DataStructures.LinkedList.SinglyLinkedList;

public class SinglyLinkedList<T>
{
    private SinglyLinkedListNode<T>? Head { get; set; }

    public void AddFirst(T data)
    {
        var newNode = new SinglyLinkedListNode<T>(data)
        {
            Next = Head,
        };

        Head = newNode;
    }

    public void AddLast(T data)
    {
        var newNode = new SinglyLinkedListNode<T>(data);
        
        if(Head is null)
        {
            Head = newNode;
            return;
        }
        
        var curr = Head;

        while (curr.Next is not null)
        {
            curr = curr.Next;
        }

        curr.Next = newNode;
    }

    public void Display()
    {
        var curr = Head;

        while (curr != null)
        {
            Console.Write(curr.Data + " -> ");
            curr = curr.Next;
        }
    }

    public int Length()
    {
        if (Head is null)
        {
            return 0;
        }

        var curr = Head;
        var length = 1;

        while (curr.Next is not null)
        {
            curr = curr.Next;
            length++;
        }

        return length;
    }

}