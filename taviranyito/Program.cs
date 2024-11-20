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
            Tv tv = new Tv(10, 5, false);

            RemoteControl<Tv> remoteControl = new RemoteControl<Tv>(tv);
            remoteControl.Power_On();
            remoteControl.Change_Channel(3);
            remoteControl.Volume_Up();
            remoteControl.Volume_Up();
            remoteControl.Volume_Up();
            remoteControl.Volume_Down();
            remoteControl.Power_Off();

        }
    }
}
