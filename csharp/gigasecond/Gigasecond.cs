using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime NewMoment = moment.AddSeconds(1000000000);
        return NewMoment;
    }
}