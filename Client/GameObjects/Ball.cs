using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.GameObjects
{
    public class Ball : RotatingSpriteGameObject
    {
        public float x, y;
        public Vector2 dir;
        Vector2 pos = new Vector2();
        //Vector2 bounceVertical = new Vector2(1, -1);
        //Vector2 bounceHorizontal = new Vector2(-1, 1);
        public int size = 30;

        public Ball(int startPosX, int startPosY, int velocityX, int velocityY) : base("spr_ball")
        {
            x = startPosX;
            y = startPosY;
            dir = new Vector2 (velocityX, velocityY);
          
            //why circumvent MonoGames 'Position' and 'Velocity', you ask?
            //..Because Monogame Update() WILL use it for its own physics, but DOES NOT play nice with dropped frames :/ 
        }

        public void BounceHorizontal()
        {
            dir.X *= -1;
        }
        public void BounceVertical()
        {
            dir.Y *= -1;
        }

        public void Tick() // DON't use "Update" (else MonoGame will mess with it when frames drop)
        {
            //physics:
            x += dir.X;
            y += dir.Y;

            //update position to Monogame
            pos.X = x;
            pos.Y = y;
            position = pos;
        }
    }
}
