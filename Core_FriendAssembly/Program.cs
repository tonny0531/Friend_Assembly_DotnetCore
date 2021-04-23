using System;
using FriendAssembly;

namespace Core_FriendAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            FriendlyClass friendly = new FriendlyClass(1, "MyFriend");
            Console.WriteLine(friendly.Id + "  " + friendly.Name);
        }
    }
}
