using Turbo.Core.Game.Rooms.Mapping;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class HeightMapMessageSerializer() : AbstractSerializer<HeightMapMessage>(MessageComposer.HeightMapMessageComposer)
{
    protected override void Serialize(IServerPacket packet, HeightMapMessage message)
    {
        packet.WriteInteger(message.RoomModel.TotalX)
            .WriteInteger(message.RoomModel.TotalSize);

        foreach (IRoomTile tile in message.RoomMap.Tiles)
        {
            packet.WriteShort(tile.RelativeHeight);
        }
    }
}