using System;
using System.Security.Cryptography;
using System.Text;

namespace BlockChainDemo
{
    public class Block
    {
        public int Index { get; set; }
        public string[] Data { get; set; }
        public string PreviousHash { get; set; }
        public string SelfHash { get; set; }
        public int Nonce { get; set; }

        public Block(int index, string[] data, string previousHash = null)
        {
            this.Index = index;
            this.Data = data;
            this.PreviousHash = previousHash;
        }

        public string GetCombined()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Index.ToString());
            sb.Append(this.PreviousHash);
            sb.Append(string.Join("", this.Data));
            return sb.ToString();
        }

        public void CalculateSelfHash()
        {
            string combinedData = this.GetCombined();
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(combinedData);
            byte[] hashBytes = sha256.ComputeHash(bytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            this.SelfHash = hash;
        }
    }
}