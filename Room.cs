using System;
using System.Numerics;
using System.Drawing;
using System.Xml;


namespace ProceduralGen
{
    /// <summary>
    /// Basic single unit used in procedural generation
    /// </summary>
    public class Room
    {
        public Size Size { get; private set; }
        public Vector2 StartPos { get; private set; }
        public string Name { get; private set; }
        
        

        public Room(string name, Size size = default, Vector2 startPos = default)
        {
            Name = name;
            Size = size;
            StartPos = startPos;
        }

        public void RandomizeRoom()
        {
            Random seed = new Random();
            int i = seed.Next();
            //Vector2 s = new Vector2()
        }
        
    }
}