using System;

namespace Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton singleton = Singleton.NesneVer();
            //Singleton singleton2 = Singleton.NesneVer();

            var instance = Singleton.Instance;


        }
    }
    //class Singleton
    //{
    //    private Singleton(string isim)
    //    {
    //        Console.WriteLine(isim);
    //    }
    //    private static Singleton nesne;
    //    public static Singleton NesneVer()
    //    {
    //        if (nesne == null)
    //        {
    //            nesne = new Singleton("ahmet");
    //        }
    //        return nesne;
    //    }
    //}


    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _lazyInstance = new Lazy<Singleton>(() => new Singleton());

        private Singleton() {  }

        public static Singleton Instance
        {
            get { return _lazyInstance.Value; }
        }

    }
}
