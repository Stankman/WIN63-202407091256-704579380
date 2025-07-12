using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class UserEventCatsSerializer() : AbstractSerializer<UserEventCatsMessage>(MessageComposer.UserEventCatsEvent)
{
    protected override void Serialize(IServerPacket packet, UserEventCatsMessage message)
    {
        packet.WriteInteger(message.EventCategories?.Count ?? 0);

        foreach (var category in message.EventCategories)
        {
            packet.WriteInteger(category.Id);
            packet.WriteString(category.Name);
            packet.WriteBoolean(category.Visible);
        }
    }

} 