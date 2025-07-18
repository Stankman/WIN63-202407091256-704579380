using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class NewFriendRequestSerializer() : AbstractSerializer<NewFriendRequestMessage>(MessageComposer.NewFriendRequestComposer)
{
    protected override void Serialize(IServerPacket packet, NewFriendRequestMessage message)
    {
        packet.WriteInteger(message.Request.PlayerEntityId);
        packet.WriteString(message.Request.PlayerEntity.Name);
        packet.WriteString(message.Request.PlayerEntity.Figure);
    }
}
