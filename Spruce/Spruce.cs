using Spruce.Props;
using System;

namespace Spruce
{
    public class Spruce : Plant, IPersistent
    {
        private const Colors _color = Colors.Green;
        private const string _appearance = "slim";

        public Spruce()
        {
            Year.SeasonChanged += new EventHandler<SeasonsEventArgs>(ChangeAppearance);
        }

        public void IgnoreSeason(Seasons _season)
        {
            Console.WriteLine("{0} came, but i still {1} and {2}", 
                _season, Appearance, Color);
        }

        public override void ChangeAppearance(object sender, SeasonsEventArgs e)
        {
            IgnoreSeason(e.CurrentSeason);
        }
    }
}
