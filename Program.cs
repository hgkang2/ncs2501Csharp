﻿internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] intarray = new int[]{1,2,3,4,5};
        string str = "happy birthday!";
        //Console.WriteLine(sol.solution01162(intarray,1,3));

        Util.printIntArray(sol.solution01162(intarray,1,3));
      /* Sample sam = new Sample();
        sam.Queue();*/
    }
}