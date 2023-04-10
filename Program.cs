using System;

namespace BlockChainDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ the genesis transaction begin ============");
            BlockChain bc = new BlockChain();
            Console.WriteLine(bc.ToString());
            Console.WriteLine(bc.blockArray[0].ToString());

            Miner mining = new Miner(bc);
            Console.WriteLine("============ the genesis transaction end ============");

            Console.WriteLine("============ the first transaction begin ============");
            string[] transaction1 = new string[] { "A", "B", "MOP", "200" };
            mining.Mine(transaction1);
            Console.WriteLine(bc.ToString());
            Console.WriteLine(bc.blockArray[1].ToString());
            Console.WriteLine("============ the first transaction end ============");

            Console.WriteLine("============ the second transaction begin ============");
            string[] transaction2 = new string[] { "B", "C", "USD", "300" };
            mining.Mine(transaction2);
            Console.WriteLine(bc.ToString());
            Console.WriteLine(bc.blockArray[2].ToString());
            Console.WriteLine("============ the second transaction end ============");

            Console.WriteLine("============ the third transaction begin ============");
            string[] transaction3 = new string[] { "C", "A", "HKD", "700" };
            mining.Mine(transaction3);
            Console.WriteLine(bc.ToString());
            Console.WriteLine(bc.blockArray[3].ToString());
            Console.WriteLine("============ the third transaction end ============");

        }
    }
}
