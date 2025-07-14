using Turbo.Core.Game.Rooms.Utils;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Layout;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Layout
{
    public class UpdateFloorPropertiesMessageParser : AbstractParser<UpdateFloorPropertiesMessage>
    {
        public override IMessageEvent Parse(IClientPacket packet)
        {
            var model = packet.PopString();
            var doorX = packet.PopInt();
            var doorY = packet.PopInt();
            var doorRotation = (Rotation)packet.PopInt();
            var wallThickness = packet.PopInt();
            var floorThickness = packet.PopInt();
            int? wallHeight = null;

            // Check if the packet has more data to read
            try { wallHeight = packet.PopInt(); } catch { /* this is disgusting */  }

            return new UpdateFloorPropertiesMessage
            {
                Model = model,
                DoorX = doorX,
                DoorY = doorY,
                DoorRotation = doorRotation,
                WallThickness = wallThickness,
                FloorThickness = floorThickness,
                WallHeight = wallHeight
            };
        }
    }
}