using System.Drawing;
using System.Numerics;

namespace ProceduralGen
{
    public class RoomManager
    {
        public Room startRoom;
        public Room endRoom;

        public void RoomInit()
        {
            startRoom = new Room("S", Size.Empty, Vector2.Zero);
            endRoom = new Room("E", Size.Empty, Vector2.Zero);
        }

    }
}