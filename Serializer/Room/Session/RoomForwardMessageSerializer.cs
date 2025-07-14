using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Parsers.room;

public class RoomForwardMessageSerializer() : AbstractSerializer<RoomForwardMessage>(MessageComposer.RoomForwardMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomForwardMessage message)
    {
        packet.WriteInteger(message.RoomId);
    }
}