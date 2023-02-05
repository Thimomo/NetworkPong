using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Networking.JsonObjects
{
    public class PaddleHitMessage : MessagePacket
    {
        public uint tickNumber;
        public Vector2 position;
        public Vector2 ballPosition;
        public Vector2 ballDirection;

        public PaddleHitMessage() 
        {
            msgType = "HIT";
        }

    }
}
