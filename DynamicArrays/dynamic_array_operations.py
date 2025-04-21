# Python arrays are dynamic by default, but this is an example of resizing.
class DynamicArray:
    def __init__(self, capacity: int):
        self.capacity = capacity
        self.size = 0 
        self.arr = [0] * self.capacity # If capacity is 4, arr will look like this = [0, 0, 0, 0]

    def get(self, i: int) -> int:
        if i >= self.size:
            return None
        return self.arr[i]
    
    def set(self, i: int, n: int) -> None:
        self.arr[i] = n

    def pushback(self, n: int) -> None:
        if self.size == self.capacity:
            self.resize()
        self.arr[self.size] = n
        self.size += 1
    
    def popback(self) -> int:
        # soft Delete
        self.size -= 1
        return self.arr[self.size]
    
    def resize(self) -> None:
        self.capacity = 2 * self.capacity
        new_arr = [0] * self.capacity
        for i in range(self.size):
            new_arr[i] = self.arr[i]
        self.arr = new_arr

    def getCapacity(self) -> int:
        return self.capacity
    def getSize(self) -> int:
        return self.size
