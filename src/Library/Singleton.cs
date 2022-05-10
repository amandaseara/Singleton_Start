using System;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        public static T Instance {get;} = new T();
    }
}