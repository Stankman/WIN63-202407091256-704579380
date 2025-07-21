using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class FriendNotificationSerializer() : AbstractSerializer<FriendNotificationMessage>(MessageComposer.FriendNotificationComposer)
{
    protected override void Serialize(IServerPacket packet, FriendNotificationMessage message)
    {
        packet.WriteString(""); //Avatar Id
        packet.WriteInteger(0); //Type code
        packet.WriteString(""); //Message
    }
}
