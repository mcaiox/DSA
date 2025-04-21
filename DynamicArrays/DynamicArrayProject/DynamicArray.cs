public class DynamicArray {
    
    private int[] arr;
    private int length;
    private int capacity;
    // Constructor to initialize the dynamic array
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.arr = new int[this.capacity];
    }

    // Get value at the i-th index
    public int Get(int i) {
        return arr[i];
    }

    // Insert value at the i-th index
    public void Set(int i, int n) {
        arr[i] = n;
    }

    // Insert value at the last position of the array
    public void PushBack(int n) {
        if (length == capacity){
            Resize();
        }
        arr[length] = n;
        length++;

    }
    // soft delete the last element
    public int PopBack() {
        if (length > 0){
            length--;
        }
        return arr[length];
    }

    // resize the array
    private void Resize() {
        capacity = capacity * 2;
        int [] newArr = new int[capacity];
        for(int i=0; i<length; i++){
            newArr[i] = arr[i];
        }
        arr = newArr;

    }

    // get the size of the array
    public int GetSize() {
        return length;

    }

    public int GetCapacity() {
        return capacity;

    }
}
