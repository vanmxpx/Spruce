using System;
using Spruce.Props;

namespace Spruce
{
    public abstract class Plant
    {
        private Colors _color;
        private string _appearance;

        public Colors Color
        {
            get
            {
                return _color;
            }
        }
        public string Appearance
        {
            get
            {
                return _appearance;
            }
        }

        public abstract void ChangeAppearance(object sender, SeasonsEventArgs e);
        public void Grow()
        {
            Console.WriteLine("Growing..");
        }
        public void ToSprout()
        {
            Console.WriteLine("I was born!");
        }


    }
}
