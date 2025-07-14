using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class FurnitureAliasesMessageSerializer() : AbstractSerializer<FurnitureAliasesMessage>(MessageComposer.FurnitureAliasesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FurnitureAliasesMessage message)
    {
        packet.WriteInteger(message.Aliases.Count);
        foreach (var entry in message.Aliases)
        {
            packet.WriteString(entry.Key);
            packet.WriteString(entry.Value);
        }
    }
}