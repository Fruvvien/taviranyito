using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taviranyito
{
    internal class Tv
    {
        private int channel;
        private int volume;
        private bool bekapcsolvaVanE;

        public Tv(int channel, int volume, bool bekapcsolvaVanE)
        {
            this.Channel = channel;
            this.Volume = volume;
            this.BekapcsolvaVanE = bekapcsolvaVanE;
        }

        public int Channel { get => channel; set => channel = value; }
        public int Volume { get => volume; set => volume = value; }
        public bool BekapcsolvaVanE { get => bekapcsolvaVanE; set => bekapcsolvaVanE = value; }

        public override string ToString()
        {
            return $"adás: {channel}, hangerő: {volume}, be van e kapcsolva? {bekapcsolvaVanE}";
        }
    }
}
