using System;

namespace Blockchain_Learning
{
    class Program
    {
        //https://devstyle.pl/2018/09/17/budowanie-blockchain-w-15-minut/
        static void Main(string[] args)
        {
            Blockchain blockchain1 = new Blockchain();  //nowy blockchain -> nowy block 
                                                        //nowa lista BlockList i Block(null)
                                                        //PreviousHash - null i TransactionList - nowa lista
            blockchain1.AddTransaction(5, "Jan", "Michał");
            //blockchain1.AddTransaction(2.1, "Grzegorz", "Kamil");
            //blockchain1.AddTransaction(1.23, "Paweł", "Jakub");

            Console.WriteLine($"Prevous Hash: {blockchain1.CurrentBlock.PreviousHash} ");
            Console.WriteLine($"Hash: {blockchain1.CurrentBlock.Hash} ");
            Console.WriteLine($"Hash actual: {Helper.GetSha256Hash(blockchain1.CurrentBlock)} ");
            blockchain1.SaveBlock(); //dodanie aktualengo bloku do łańcucha i utworzenie nowego, pustego bloku
            Console.WriteLine($"Prevous Hash: {blockchain1.CurrentBlock.PreviousHash} ");
            Console.WriteLine($"Hash: {blockchain1.CurrentBlock.Hash} ");
            Console.WriteLine($"Hash actual: {Helper.GetSha256Hash(blockchain1.CurrentBlock)} ");
            blockchain1.SaveBlock();
            Console.WriteLine($"Prevous Hash: {blockchain1.CurrentBlock.PreviousHash} ");
            Console.WriteLine($"Hash: {blockchain1.CurrentBlock.Hash} ");
            Console.WriteLine($"Hash actual: {Helper.GetSha256Hash(blockchain1.CurrentBlock)} ");
            //blockchain1.SaveBlock();
            //Console.WriteLine(blockchain1.CurrentBlock.PreviousHash);


            //string[] test1 = { "a", "b", "c" };
            //string[] test2 = { "a", "b", "c" };
            //int test3 = 1;

            //Console.WriteLine($"Hash 1: {Helper.GetSha256Hash(test1) }");
            //Console.WriteLine($"Hash 2: {Helper.GetSha256Hash(test2) }");
            //Console.WriteLine($"Hash 2: {Helper.GetSha256Hash(test3) }");
            //Console.WriteLine($"Hash 2: {Helper.GetSha256Hash(1) }");
            //Console.WriteLine($"Hash 2: {Helper.GetSha256Hash("ben ben") }");

            Console.ReadKey();
        }
    }
}
