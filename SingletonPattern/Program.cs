﻿using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();
            singleton.data = 45;
            Console.WriteLine($"From instance 1: {singleton.data}");

            Singleton singleton2 = Singleton.getInstance();
            Console.WriteLine($"From instance 2: {singleton.data}");
        }
    }


    // This is Bill Pugh way of creating singleton class which is actuall the most recommended
    public class Singleton
    {
        public int data { get; set; }

        private Singleton() { }

        private class SingletonHolder
        {
            public readonly static Singleton instance = new Singleton();
        }

        public static Singleton getInstance()
        {
            return SingletonHolder.instance;
        }


    }
}
