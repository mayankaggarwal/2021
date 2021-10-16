using System;
using mydev.Algos.Contracts;
using mydev.Algos.BinaryTree;

namespace mydev.Algos.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	    IRunner runner = new AlgoRunner();
	    runner.Run();
	    IRunner runnerBT = new BTRunner();
	    runnerBT.Run();
        }
    }
}
