using System;

namespace Blockchain_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockchain blockchain1 = new Blockchain(); 
            blockchain1.AddTransaction(5, "Jan", "Michał");
            blockchain1.AddTransaction(2.1, "Grzegorz", "Kamil");
            blockchain1.AddTransaction(1.23, "Paweł", "Jakub");

            blockchain1.SaveBlock();
            Console.WriteLine(blockchain1.CurrentBlock.PreviousHash);
            blockchain1.SaveBlock();
            Console.WriteLine(blockchain1.CurrentBlock.PreviousHash);
            blockchain1.SaveBlock();
            Console.WriteLine(blockchain1.CurrentBlock.PreviousHash);


            //string[] test1 = { "a", "b", "c" };
            //string[] test2 = { "a", "b", "c" };

            //Console.WriteLine($"Hash 1: {Helper.GetSha256Hash(test1) }");
            //Console.WriteLine($"Hash 2: {Helper.GetSha256Hash(test2) }");

            Console.ReadKey();
        }


    }
}
