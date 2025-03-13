using System;


class myApp
{

    static void Main()
    {

        sual4();

    }// Main



    static void sual1(){
        int M = 60, count=0;
        float sum=0.0f;
        while(M>=15){
            if(M%15==0){
                ++count;
                sum+=M;
            } --M;
        }
        Console.WriteLine(sum/count);
    }// SUAL1


    static void sual2(){
        int N = 56;
        while(N<=84)
        {   
            if(N%21==0)
            {
                Console.WriteLine(N);
                return;
            }
            N++;
        }
    }// SUAL2


    static void sual3(){
        int n = 123, s=0;;
        while(n!=0)
        {
            s+=n%10;n/=10;
        }
        Console.WriteLine(s);
    }// SUAL3


    static void sual4(){
        int[] arr = new int[4]{12,3,1,2};
        int hasil=1;
        foreach(int t in arr)
        {
            if(t%2==0)
            {
                hasil*=t;
            }    
        }
        Console.WriteLine(hasil);
    }// SUAL4


    static void sual6(){


        int[] arr = new int[5] { 1, 2, 3, 5, 4 };
        int num = Convert.ToInt32(Console.ReadLine());
        foreach (int a in arr)
        {
            if (a < num)
            {
                Console.WriteLine("True");
                return;
            }
        }
        Console.WriteLine("false");
    }// SUAL6


    static void sual7(){
        int[] arr = new int[10] { 2, 3, 6, 8, 34, 67, 123, 5634, 734, -123 };
        int max = arr[0];

        foreach(int a in arr)
        {
            if (a > max) { max = a; }
        }
        Console.WriteLine(max); 
    }// SUAL7
    

    static void sual9(){

        string str = Convert.ToString(Console.ReadLine());
        int f=0,b=str.Length-1; 
        while(f<b)
        {
            if (str[b] == str[f]) 
            {
                b--;++f;
                continue; 
            }
            Console.WriteLine("polindrom deyil");
            return;
        }
        Console.WriteLine("polindromdur");
    }// SUAL9


    static void sual8(){
                string[] arr = new string[7]{"line1", "line2", "line3", "line4", "line5", "line6", "line7"};
        string target = "line3";
        for(int t=0; t<7;++t){
            if(target == arr[t]){
                Console.Write($"sira nomresi: {t}\n");
                return;
            }// if
        }// for
        Console.Write("Tapilmadi\n");

    }// SUAL8


    static void sual9_2(){
        
        string word = "qwertyuioasdfghjklzxcvbnm";
        char target = '2';

        for(int front=0,back=word.Length-1; front <= back;)
        {
            if(word[front] == target || word[back] == target){
                Console.Write($"'{target}' Found!\n");
                return;
            }
            front++;--back;
        }

        Console.Write($"'{target}' Not found!\n");
    }// SUAL9_2


    static void sual10(){
        int n = 5,f = 1;
        Console.Write($"!{n} = ");
        while(n!=0)
        {
            f*=n;--n;
        }
        Console.WriteLine(f);
    }// SUAL10


    static void sual11(){
        int n = 123, t=1;
        
        while(n!=0)
        {                
            t*=(n%10);n/=10;
        }
        Console.WriteLine(" = "+t);
    }


    static void sual11_2(){
        string[] strarr = new string[3]{"abcde", "12345", "bye World"};

        
        for(int t=0; t<strarr.Length;t++)// for-1
        {
            char[] reverse = new char[strarr[t].Length];
            for(int front=0,back=strarr[t].Length-1;back>=0;front++)// for-2
            {
                
                reverse[front] = strarr[t][back];

                --back;
            }// for-2

            strarr[t] = new string(reverse);
            Console.Write(strarr[t] + " ");
        }// for-1

        Console.Write('\n');
    }// SUAL11_2


    static void sual12(){
        string[] str = new string[6]{"line1", "line2", "line3", "line4", "line5", "\0"};
        for(int front=0, back=str.Length-2;front<back;){
            str[5] = str[front];
            str[front] = str[back];
            str[back] = str[5];
            --back;++front;
        }

        foreach (string item in str)
        {
            Console.Write(item + " ");
        }
        Console.Write("\n");

    }// SUAL12

}// class