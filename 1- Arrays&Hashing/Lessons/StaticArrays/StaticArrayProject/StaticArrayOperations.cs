using System.Runtime.InteropServices.Marshalling;

public class StaticArray
{ 
    public void InsertEnd(int[] arr, int n, int length, int capacity)
    {
        if (length < capacity)
        {
            arr[length] = n;
        }
    }
    public void removeEnd(int[] arr, int length)
    {
        if (length > 0)
        {
            arr[length - 1] = 0;
            length--;
        }
        // For statically typed languages, when we want to remove an element from the end of an array, we just need to set the last element to 0 and decrement the length of the array.
        // Removing an element from the end of an array takes O(1) time.
        // This means the number of operations is constant and does not depend on the size of the array.
    }

    public void InsertMiddle(int[] arr, int i, int n, int length)
    {
        // Shift starting from the end to i.
        for (int index = length - 1; index > i - 1; index--)
        {
            arr[index + 1] = arr[index];
        }
        // Insert at i
        arr[i] = n;
    }

    public void RemoveMiddle(int[] arr, int i, int length)
    {
        // Shift starting from i + 1 to end.
        for (int index = i + 1; index < length; index++)
        {
            arr[index - 1] = arr[index];
        }
        // No need to 'remove' arr[i], since we already shifted
    }
    public void PrintArr(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        // Traversing through an array of size n takes O(n) time.
        // This means the number of operations is directly proportional to the size of the array.
    }
    public static void Main(){
        StaticArray arrayOps = new StaticArray();
        int[] myArray = new int[5]; // capacity is 5
        // In statically typed languages, all array indices are filled with 0s or some default value upon initialization, denoting an empty array.
        int length = 0;
        arrayOps.InsertEnd(myArray, 1, length, myArray.Length);
        arrayOps.PrintArr(myArray);
    }
}