using System;

class Program {
    static void Main() {
        Console.Write("Enter array elements separated by a space: ");
        string[] arr = Console.ReadLine().Split();
        
        string[] result = new string[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i].Length <= 3) {
                result[j] = arr[i];
                j++;
            }
        }
        
        Array.Resize(ref result, j);
        
        Console.WriteLine("Array of strings less than or equal to 3 characters long:");
        foreach (string s in result) {
            Console.WriteLine(s);
        }
    }
}
