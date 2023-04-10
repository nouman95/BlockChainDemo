using System;
using System.Collections.Generic;
using System.Linq;

namespace BlockChainDemo
{
    public class BlockChain
    {
        public int totalCount { get; set; } // used to record the number of blocks
        public List<Block> blockArray { get; set; } // this is a list object that used to store the blockchain

        public BlockChain()
        {
            blockArray = new List<Block> { new Block(0, new string[] { "Genesis Block", "ABC" }) }; // genesis block
            totalCount = 1;
            calculateGenesisBlockHash(); // calculate the hash of genesis block
        }

        public Block getLatest() // get the last block on the current blockchain                         
        {
            return blockArray.Last();
        }

        public void calculateGenesisBlockHash()
        {
            Block gb = blockArray[0];
            string str = gb.Index.ToString() + gb.Data;
            Console.WriteLine(str);
            gb.SelfHash = Util.ComputeHash(str); // calculate current hash
        }

        public void AddBlock(Block newBlock) // when Miner.m successfully 'digs out' a block that meets the requirements
        {
            if (validateNewBlock(newBlock)) // call this function
            {
                blockArray.Add(newBlock); // and then add this block to this blockchain
            }
        }

        public bool validateNewBlock(Block newBlock) // verify that the newly added block meets the requirements or not. 
        {
            string newHash = Util.ComputeHash(newBlock.GetCombined() + newBlock.Nonce.ToString());
            if (newHash.Substring(0, 3) == "000" && newBlock.SelfHash == newHash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}