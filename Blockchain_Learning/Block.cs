using System;
using System.Collections.Generic;

namespace Blockchain_Learning
{
    [Serializable]
    public class Block
    {
        public string Hash { get; set; }
        public string PreviousHash { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public Block(string previousHash)
        {
            PreviousHash = previousHash;
            TransactionList = new List<Transaction>();
        }
        public void AddTransaction(double amount, string from, string to)
        {
            TransactionList.Add(new Transaction
            {
                Amount = amount,
                From = from,
                To = to
            });
        }
    }
}
