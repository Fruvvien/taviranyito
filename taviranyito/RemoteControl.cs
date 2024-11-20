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
        private T eszkoz;

        public RemoteControl(T eszkoz)
        {
            this.eszkoz = eszkoz;

            
        }

        public void Power_On() {
            if(eszkoz.GetType() == typeof(Hifi))
            {
                Console.WriteLine("Be van kapcsolva a Hifi");
            }
            if(eszkoz.GetType() == typeof(Tv))
            {
                Console.WriteLine("Be van kapcsolva a Tv");
            }
        }

        public void Power_Off() {
            if (eszkoz.GetType() == typeof(Hifi))
            {
                Console.WriteLine("Ki van kapcsolva a Hifi");
            }
            if (eszkoz.GetType() == typeof(Tv))
            {
                Console.WriteLine("Ki van kapcsolva a Tv");
            }

        }

        public void Change_Channel(int channel)
        {

            Console.WriteLine($"csatorna váltás az {channel}-re");

        }

        public void Volume_Up()
        {
            Console.WriteLine($"Növelve a hangerő, aktuális ");
        }
        public void Volume_Down()
        {
            Console.WriteLine($"Csökkentve a hangerő, aktuális ");
        }

        

    }

}
