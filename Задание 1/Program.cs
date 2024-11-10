using System;
public class Answer
{
public static void PrintRange(int M, int N)
{
    if ( M > N )
        return;
    
    Console.WriteLine(M);
    PrintRange(M + 1, N);

}
static public void Main(string[] args)
{
int M = 1; 
int N = 9; 
Console.WriteLine("Числа в промежутке:");
PrintRange(M, N);
}
}

