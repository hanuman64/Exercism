using System;

public static class ResistorColor
{
    public static string[] tab = {"black","brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
 
    public static int ColorCode(string color)
    {
        int index = Array.IndexOf(tab, color);
        return index;
    }

    public static string[] Colors() => tab;   
}