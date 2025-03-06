using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int c1= a+b+c;
        int c2 = (int)(Math.Pow(a,2)+Math.Pow(b,2)+Math.Pow(c,2));
        int c3 = (int)(Math.Pow(a,3)+Math.Pow(b,3)+Math.Pow(c,3));
       if(a == b && b == c){return c1*c2*c3;}
        else if(a!=b && b!=c && c!= a){return c1;}
        else return c1*c2;
    }
}