﻿namespace NadekoBot
{
    public class Program
    {
        public static void Main(string[] args) => 
            new NadekoBot().RunAsync(args).GetAwaiter().GetResult();
    }
}
