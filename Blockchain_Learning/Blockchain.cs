using System.Collections.Generic;

namespace Blockchain_Learning
{
    public class Blockchain
    {
        public List<Block> BlockList { get; set; }
        public Block CurrentBlock { get; set; }

        public Blockchain()
        {
            BlockList = new List<Block>();
            CurrentBlock = new Block(null);
        }

        public void AddTransaction(double amount, string from, string to)
        {
            CurrentBlock.AddTransaction(amount, from, to);
        }

        public void SaveBlock()
        {
            string currentHash = Helper.GetSha256Hash(CurrentBlock);
            CurrentBlock.Hash = Helper.GetSha256Hash(CurrentBlock);
            BlockList.Add(CurrentBlock); //dodanie aktualnego bloku
            CurrentBlock = new Block(currentHash); //nowy blok
        }
    }
}
