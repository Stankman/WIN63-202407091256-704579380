using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202407091256704579380.Serializer.room.Types;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class ItemsMessageSerializer() : AbstractSerializer<ItemsMessage>(MessageComposer.ItemsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ItemsMessage message)
    {
        packet.WriteInteger(message.OwnersIdToUsername.Count);

        foreach (var entry in message.OwnersIdToUsername)
        {
            packet.WriteInteger(entry.Key);
            packet.WriteString(entry.Value);
        }

        packet.WriteInteger(message.Objects.Count);

        foreach (var obj in message.Objects)
        {
            ItemDataSerializer.Serialize(packet, obj);
        }
    }
}