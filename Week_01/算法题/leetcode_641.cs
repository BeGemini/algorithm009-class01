public class MyCircularDeque
{

    /** Initialize your data structure here. Set the size of the deque to be k. */
    private int[] data;
    // private int 
    private int size;
    public MyCircularDeque(int k)
    {
        data = new int[k];
        size = 0;
    }

    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value)
    {
        if (IsEmpty())
        {
            data[0] = value;
            size++;
            return true;
        }
        else if (IsFull())
        {
            return false;
        }
        else
        {
            for (int i = size; i > 0; i--)
            {
                data[i] = data[i - 1];
            }
            data[0] = value;
            size++;
            return true;
        }
    }

    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value)
    {
        if (IsFull())
        {
            return false;
        }
        data[size] = value;
        size++;
        return true;
    }

    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront()
    {
        if (IsEmpty())
        {
            return false;
        }
        for (int i = 1; i < size; i++)
        {
            data[i - 1] = data[i];
        }
        size--;
        return true;
    }

    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast()
    {
        if (IsEmpty())
        {
            return false;
        }
        size--;
        return true;
    }

    /** Get the front item from the deque. */
    public int GetFront()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return data[0];
    }

    /** Get the last item from the deque. */
    public int GetRear()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return data[size - 1];
    }

    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty()
    {
        return size == 0;
    }

    /** Checks whether the circular deque is full or not. */
    public bool IsFull()
    {
        return size == data.Length;
    }
}