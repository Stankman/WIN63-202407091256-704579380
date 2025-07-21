using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class FollowFriendFailedSerializer() : AbstractSerializer<FollowFriendFailedMessage>(MessageComposer.FollowFriendFailedComposer)
{
    protected override void Serialize(IServerPacket packet, FollowFriendFailedMessage message)
    {
        packet.WriteInteger(message.ErrorCode);
    }
}
