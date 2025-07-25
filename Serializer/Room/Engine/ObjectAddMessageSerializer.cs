using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202407091256704579380.Serializer.room.Types;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class ObjectAddMessageSerializer() : AbstractSerializer<ObjectAddMessage>(MessageComposer.ObjectAddMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ObjectAddMessage message)
    {
        ObjectDataSerializer.Serialize(packet, message.Object);

        packet.WriteString(message.OwnerName);
    }
}