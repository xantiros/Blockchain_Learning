using System;
namespace Blockchain_Learning
{
    [Serializable]
    public class Transaction
    {
        public double Amount { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
