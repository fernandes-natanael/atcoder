
public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> stack = new();
        foreach(var c in s)
        {
            if(stack.Count == 0)
            {
                stack.Push(c);
            }
            else if(c == '[' || c == '{' || c == '(') {
                stack.Push(c);
            }
            else
            {
                var top = stack.Peek();
                if(top == '[' && c != ']' ) return false;
                if(top == '(' && c != ')' ) return false;
                if(top == '{' && c != '}' ) return false;
                if(top == ']' || top == ')' || top == '}') return false;
                stack.Pop();
            }
        }
        return stack.Count==0 ;

    }
}

//public class Solution {
//    public bool IsValid(string s)
//    {
//
//        if((s.Length & 1) == 1) return false;
//        var mid = s.Length >> 1;
//        for(int i =  mid-1, j = mid; i >=0; --i, ++j)
//        {
//            if(s[i] == '[' && s[j] != ']' ) return false;
//            if(s[i] == '(' && s[j] != ')' ) return false;
//            if(s[i] == '{' && s[j] != '}' ) return false;
//        }
//        return true;
//    }
//}