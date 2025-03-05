using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        bool result = false;
       
        switch(ineq + eq)
        {
                
            case "<=": result = (n <= m);break;
            case "<!": result =(n<m);break;
            case ">=": result = (n>=m);break;
            case ">!": result = (n>m);break;
            default: return 0;
        }
        if(result)
            return 1;
        else return 0;
       
    }
}