using System;
public class Answer
{
    public static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0) return;
        Console.Write(array[index]);
        if (index > 0) Console.Write(", ");
        PrintArrayReverse(array, index - 1);
    }
    static public void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Массив в обратном порядке:");
        PrintArrayReverse(array, array.Length - 1);
    }
}
