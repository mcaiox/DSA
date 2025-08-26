class Solution:
    def isValid(self, s: str) -> bool:
        stack = [] #Create a stack(LIFO) to store open parentheses 
        #HashMap K:V Closing:Open
        closeToOpenHashMap = {  
            ")" : "(",
            "]" : "[",
            "}" : "{"
        }
        for c in s:
            if c not in closeToOpenHashMap:
                stack.append(c)
            # Check if closing parentheses matches the one in the stack, if yes pop off stack
            else:
                if not stack: #If the stack is empty
                    return False
                else:
                    if stack[-1] == closeToOpenHashMap[c]:
                        stack.pop()
                    else:
                        return False
        return not stack
