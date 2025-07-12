using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class NavigatorEventCategoriesSerializer()
    : AbstractSerializer<NavigatorEventCategoriesMessage>(MessageComposer.UserEventCatsEvent)
{
    protected override void Serialize(IServerPacket packet, NavigatorEventCategoriesMessage message)
    {
        packet.WriteInteger(message.EventCategories?.Count ?? 0);

        foreach (var category in message.EventCategories)
        {
            packet.WriteInteger(category.Id);
            packet.WriteString(category.Name ?? string.Empty);
            packet.WriteBoolean(category.Visible);
        }
    }
}