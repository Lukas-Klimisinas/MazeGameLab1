﻿namespace MazeGameLab1.Singletons
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton() { }

        private Singleton() { }

        public static Singleton Instance
        {
            get { return instance; }
        }
    }
}