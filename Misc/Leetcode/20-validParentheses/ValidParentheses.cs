using System;
using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(); //Create a stack(LIFO) to store open parentheses 

        Dictionary<char, char> closeToOpenMap = new Dictionary<char, char> {
            //Key:Value Closing:Open - Hashmap
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s) {
            if (!closeToOpenMap.ContainsKey(c)) {
                stack.Push(c); //If the character is an open parentheses, push it onto the stack
            }
            else {
                if (stack.Count == 0) {
                    return false;
                }
                
                if (stack.Peek() == closeToOpenMap[c]) { 
                    stack.Pop();
                }
                else {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
} 

//Time Complexity: O(n)
//Space Complexity: O(n)