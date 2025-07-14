using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class FloorHeightMapMessageSerializer() : AbstractSerializer<FloorHeightMapMessage>(MessageComposer.FloorHeightMapMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FloorHeightMapMessage message)
    {
        packet.WriteBoolean(message.IsZoomedIn);
        packet.WriteInteger(message.WallHeight);
        packet.WriteString(message.RoomModel.Model);

        //TODO: Include the area hide data count foreach (var area in message.AreaHideData) area.Serialize(packet);
        packet.WriteInteger(0);
    }
}