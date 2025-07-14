using Turbo.Core.Game.Rooms.Mapping;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Layout;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Room.Layout;

public class RoomOccupiedTilesMessageSerializer() : AbstractSerializer<RoomOccupiedTilesMessage>(MessageComposer.RoomOccupiedTilesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomOccupiedTilesMessage message)
    {
        List<IRoomTile> tiles = message.OccupiedTiles;

        for (int i = 0; i < tiles.Count; i++)
        {
            IRoomTile tile = tiles[i];
            packet.WriteInteger(tile.Location.X)
                .WriteInteger(tile.Location.Y)
                .WriteInteger((int)tile.Location.Rotation);
        }

    }
}