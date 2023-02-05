using System;
using System.Collections.Generic;
using System.Text;

namespace Networking.JsonObjects
{
    internal class NoChangeMessage : MessagePacket
    {
        public uint tickNumber;
        public sbyte direction;

        public NoChangeMessage() 
        {
        
        }
    }
}
