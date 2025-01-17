using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;


class Sample
{
    public void Dictionary()
    {

        Hashtable ht = new Hashtable();
        ht.Add("irina","Irina SP");
        ht.Add("tom","Tom Cr");

        if(ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }
        //dictionary
        Dictionary<int,string> emp = new Dictionary<int, string>();
        emp.Add(1001,"Jane");
        emp.Add(1002,"Tom");
        emp.Add(1003,"Cindy");
        Console.WriteLine("Count:" + emp.Count);
        string name = emp[1002];
        Console.WriteLine(name);
        if(emp.ContainsKey(1004))
        {
        name = emp[1004];
        Console.WriteLine(name);
        }
    }
    public void Queue()
    {
        Queue<int> q= new Queue<int>();

        q.Enqueue(120);
        q.Enqueue(130);
        q.Enqueue(150);

        int next = q.Dequeue();
        Console.WriteLine("Next:" + next);
        Console.WriteLine("Count:" + q.Count);
        next = q.Dequeue();
        Console.WriteLine("Next:" + next);
    }
    public void Array()
     {
        
        //1차 배열
        string[] players = new string [10];
        Console.WriteLine(players.Length);
        int[] intarray = new int[100];
        Console.WriteLine(intarray.Length);
        char[] cc = new char[5];

        int[]abc=new int[3];
        int[] abc2 = new int [3]{1,2,3};
        string[] Regions = new string[3]{"seoul","kk","busan"};
        //2
        string[,] Depts = new string[2,2];
        Console.WriteLine(Depts.Length);
        int[,] inta2 = new int[3,2]{{1,2},{2,3},{3,4}};
        Console.WriteLine(inta2.Length);
        //3
        string[,,] cubes = new string[2,3,4];
        Console.WriteLine(cubes.Length);    
        // 아래 방법은 가능하지만, 2차원 배열[,]을 사용하지 않고
        //차원별 배열 크기가 다를 경우 사용
        int[][] ii = new int [3][];
        int[][] iii = new int [3][];
        iii[0] = new int[2]{1,2};
        iii[1] = new int[2]{2,3};
        iii[2] = new int[2]{3,4};

        int sum = 0;
        int[] scores = new int []{80,78,60,90,100};
        for(int i = 0; i < scores.Length; i++)
        {
            /*sum = sum + scores[i];
            sum = sum - scores[i];
            sum = sum * scores[i];
            sum = sum / scores[i];
            sum += scores[i];*/
        }
        sum += scores[0];
        sum += scores[1];
        sum += scores[2];
        sum = sum + scores[3];
        sum = sum + scores[4];
        Console.WriteLine("sum : " + sum);
     }
     public void RandomSum()
     {
        //random
        int sum = 0;
        int[] nums = new int[10];
        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next()%100;
            Console.WriteLine("nums["+i+"]:"+nums[i]);
        }
        for(int i = 0; i< nums.Length;i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
     }
       
        void DataType()
    {
        bool b = true;

        short sh = -32768;
        int i = 2147483647;
        long l = 1234L;
        float f = 123.45F;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;
        //Char/string
        char c = 'A';
        string s = "Hello";
        // == !=
        if (s[0] == 'e')
            b = true;
        else
            b = false;

        //DateTime
        DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

        // max, min
        int i2 = int.MaxValue;
        float f2 = float.MinValue; 

        // 기억해야 되는 datatype
        bool bb = true;

        
    }
}