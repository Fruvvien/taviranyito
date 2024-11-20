using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace taviranyito
{
    internal class RemoteControl <T>
    {
        private Tv tv;

        public RemoteControl(Tv tv)
        {
            this.tv = tv;
        }

        public void Power_On() {


            tv.BekapcsolvaVanE = true;
            Console.WriteLine("Be van kapcsolva");
        
        
        }

        public void Power_Off() {
            tv.BekapcsolvaVanE = false;
            Console.WriteLine("ki van kapcsolva"); 
        
        }

        public void Change_Channel(int channel)
        {

            tv.Channel = channel;
            Console.WriteLine($"csatorna váltás az {channel}-re");

        }

        public void Volume_Up()
        {
            tv.Volume++;
            Console.WriteLine($"Növelve a hangerő, aktuális: {tv.Volume} ");
        }
        public void Volume_Down()
        {
            tv.Volume--;
            Console.WriteLine($"Csökkentve a hangerő, aktuális: {tv.Volume} ");
        }

        public override string ToString()
        {
            return $"adás: {tv.Channel}, hangerő: {tv.Volume}, be van e kapcsolva? {tv.BekapcsolvaVanE}";
        }

    }

}
