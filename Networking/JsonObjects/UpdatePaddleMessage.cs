using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Networking.JsonObjects
{
    public class UpdatePaddleMessage : MessagePacket
    {
        public uint tickNumber;
        public Vector2 position;
        public Vector2 direction;
        public UpdatePaddleMessage() 
        {
            msgType = "UPDATE_POS";        
        }
    }
}
