from collections import deque

queue = deque()

# Enqueue
queue.append('a')
queue.append('b')

# Dequeue
item = queue.popleft()
print(item)  # Output: 'a'
print(queue)  # Output: deque(['b'])