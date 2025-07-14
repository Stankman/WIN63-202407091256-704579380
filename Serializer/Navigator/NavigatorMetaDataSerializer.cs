using Turbo.Core.Game.Navigator;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class NavigatorMetaDataSerializer() : AbstractSerializer<NavigatorMetaDataMessage>(MessageComposer.NavigatorMetaDataComposer)
{
    protected override void Serialize(IServerPacket packet, NavigatorMetaDataMessage message)
    {
        if (message.TopLevelContexts.Count == 0)
        {
            packet.WriteInteger(0);
            return;
        }

        packet.WriteInteger(message.TopLevelContexts.Count);

        foreach (var context in message.TopLevelContexts)
        {
            packet.WriteString(context.SearchCode);

            packet.WriteInteger(context.SavedSearches?.Count ?? 0);
            foreach (var savedSearch in context.SavedSearches ?? new List<INavigatorSavedSearch>())
            {
                packet.WriteInteger(savedSearch.Id);
                packet.WriteString(savedSearch.SearchCode);
                packet.WriteString(savedSearch.Filter);
                packet.WriteString(savedSearch.Localization);
            }
        }
    }
}