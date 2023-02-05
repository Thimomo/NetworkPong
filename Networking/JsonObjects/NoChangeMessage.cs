using System;
using System.Collections.Generic;
using System.Text;

namespace Networking.JsonObjects
{
    public class NoChangeMessage : MessagePacket
    {
        public int tickNumber;
        public sbyte direction;

        public NoChangeMessage() 
        {
        
        }
    }
}
