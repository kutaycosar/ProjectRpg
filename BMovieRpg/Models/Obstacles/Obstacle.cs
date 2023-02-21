using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRpg.Models.Obstacles
{
    public class Obstacle : GameObject
    {
        public Obstacle(Texture2D texture, float radius, string tag, Vector2 position, Vector2 hitCenter) : base(texture, radius, tag, position, hitCenter)
        {

        }
    }

    public class Tree : Obstacle
    {
        public Tree(Texture2D texture, string tag, Vector2 position) : base(texture, 0, tag, position, Vector2.Zero)
        {
            _radius = 18;
            _hitPosBox = new Vector2(Position.X + 15, Position.Y + 100);

        }

    }

    public class Bush : Obstacle
    {
        public Bush(Texture2D texture, string tag, Vector2 position) : base(texture, 0, tag, position, Vector2.Zero)
        {
            _radius = 25;
            _hitPosBox = new Vector2(Position.X + 10, Position.Y + 5);
        }
    }
}
//TODO : didcollide i static class yapmayi dusun
/*
    tree radius 20;
    bush radius 56;

    tree hitBoxPos = new Vector2(pos.x + 64, pos.y + 86) we adding half of the widh and height to position to find center 
    bush hitboxpos = new Vector2(pos.x + 56, pos.y + 57)
    

    //private variable can only be accessed with baseclass protecteds can be accessible form both base and derived classes
    
    public static bool didCollide(Vector2 otherPos, int otherRad
    {
        foreach(Obstacle o in Obstacle.obstacles)
    {
        int sum = o.Radius + otherRad;
        if(Vector2.Distance(o.HitBoxPos, otherPos) < sum)
        {
            return true;
        }
        return false;

   }

    






*/