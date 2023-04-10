using System;
using System.Security.Cryptography;
using System.Text;

namespace BlockChainDemo
{
    internal class Miner
    {
        private BlockChain blockchain;

        public Miner(BlockChain blockchain)
        {
            this.blockchain = blockchain;
        }

        public void Mine(string[] newData)
        {
            Block latestBlock = blockchain.getLatest();
            Block newBlock = new Block(latestBlock.Index + 1, newData, latestBlock.SelfHash);
            bool notFound = true;
            int iter = 1;
            SHA256 sha256 = SHA256.Create();

            DateTime startTime = DateTime.Now;
            while (notFound)
            {
                string combined = newBlock.GetCombined() + iter;
                byte[] inputBytes = Encoding.ASCII.GetBytes(combined);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                string newHash = BitConverter.ToString(hashBytes).Replace("-", "");

                if (newHash.Substring(0, 3).Equals("000"))
                {
                    newBlock.Nonce = iter;
                    newBlock.SelfHash = newHash;
                    Console.WriteLine(newHash);
                    blockchain.AddBlock(newBlock);
                    break;
                }
                iter++;
            }
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - startTime;
            Console.WriteLine("Elapsed time: " + timeSpan.TotalSeconds + " seconds");
        }
    }
}
