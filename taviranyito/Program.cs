using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taviranyito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            Hifi hifi = new Hifi();
            RemoteControl<Tv> remoteControlTv = new RemoteControl<Tv>(tv);
            remoteControlTv.Power_On();
            remoteControlTv.Change_Channel(3);
            remoteControlTv.Volume_Up();
            remoteControlTv.Volume_Up();
            remoteControlTv.Volume_Up();
            remoteControlTv.Volume_Down();
            remoteControlTv.Power_Off();


            Console.WriteLine("-----------------------------------------------------------------");
            RemoteControl<Hifi> remoteControlHifi = new RemoteControl<Hifi>(hifi);


            remoteControlHifi.Power_On();
            remoteControlHifi.Change_Channel(3);
            remoteControlHifi.Volume_Up();
            remoteControlHifi.Volume_Up();
            remoteControlHifi.Volume_Up();
            remoteControlHifi.Volume_Down();
            remoteControlHifi.Power_Off();

        }
    }
}
