using System;

public static class Hamming
{
    //public static string firstStrand;
    //public static string secondStrand;
    //static int lengthFirst = firstStrand.Length;
    //static int lengthSecond = secondStrand.Length;

    public static int Distance(string firstStrand, string secondStrand)
    {
        if (String.IsNullOrEmpty(firstStrand))
            return 0;
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("length suks");
        int dist = 0;
        for(int i = 0; i < firstStrand.Length; i++)
            {
              Console.WriteLine(firstStrand[i]);  
              Console.WriteLine(secondStrand[i]);  
             if(firstStrand[i] != secondStrand[i])
                dist++;
            }
        return dist;
    }

}