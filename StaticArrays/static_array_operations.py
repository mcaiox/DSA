class StaticArray:
    def __init__(self, capacity):
        self.arr = [0] * capacity
        self.capacity = capacity
        self.size = 0

    def insertEnd(self, n):
        if self.size < self.capacity:
            self.arr[self.size] = n
            self.size += 1

    def removeEnd(self):
        if self.size > 0:
            self.arr[self.size - 1] = 0
            self.size -= 1

    def insertMiddle(self, i, n):
        if self.size < self.capacity and i <= self.size:
            for index in range(self.size - 1, i - 1, -1):
                self.arr[index + 1] = self.arr[index]
            self.arr[i] = n
            self.size += 1

    def removeMiddle(self, i):
        if i < self.size:
            for index in range(i + 1, self.size):
                self.arr[index - 1] = self.arr[index]
            self.arr[self.size - 1] = 0
            self.size -= 1

    def printArr(self):
        for i in range(self.size):
            print(self.arr[i])

def main():
    # Create a static array with capacity 10
    arr = StaticArray(10)
    
    # Insert some elements
    arr.insertEnd(1)
    arr.insertEnd(2)
    arr.insertEnd(3)
    arr.insertEnd(4)
    arr.insertEnd(5)
    
    # Print the array
    print("Initial array:")
    arr.printArr()
    
    # Insert in middle
    arr.insertMiddle(2, 10)
    print("\nAfter inserting 10 at index 2:")
    arr.printArr()
    
    # Remove from middle
    arr.removeMiddle(2)
    print("\nAfter removing element at index 2:")
    arr.printArr()
    
    # Remove from end
    arr.removeEnd()
    print("\nAfter removing last element:")
    arr.printArr()

if __name__ == "__main__":
    main()