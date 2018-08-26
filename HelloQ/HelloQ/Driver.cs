using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.HelloQ
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                var res = Add.Run(sim, 20, 10).Result;
                Console.WriteLine(res);
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}