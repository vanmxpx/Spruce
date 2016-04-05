using Spruce.Props;
using System;

namespace Spruce
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest _forest = new Forest();
            _forest.Trees.Add(new Spruce());
            foreach(var tree in _forest.Trees)
            {
                if (tree is Spruce)
                {
                    _forest.Trees[0].ToSprout();
                    _forest.Trees[0].Grow();
                }
            }

            Year.ChangeSeason();
            Year.ChangeSeason();
            Year.ChangeSeason();
            Year.ChangeSeason();

            Console.ReadKey();
        }
    }
}
