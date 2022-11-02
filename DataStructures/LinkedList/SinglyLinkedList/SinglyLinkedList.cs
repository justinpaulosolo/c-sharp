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

    public bool Delete(T element)
    {
        var curr = Head;
        SinglyLinkedListNode<T>? prev = null;

        while (curr is not null)
        {
            if (curr.Data is null && element is null || curr.Data is not null && curr.Data.Equals(element))
            {
                if (curr.Equals(Head))
                {
                    Head = Head.Next;
                    return true;
                }

                if (prev is not null)
                {
                    prev.Next = curr.Next;
                    return true;
                }
            }
            prev = curr;
            curr = curr.Next;
        }

        return false;
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

    public IEnumerable<T> GetListData()
    {
        var curr = Head;

        while (curr is not null)
        {
            yield return curr.Data;
            curr = curr.Next;
        }
    }

}