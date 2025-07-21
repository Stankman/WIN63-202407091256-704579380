using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class RoomInviteSerializer() : AbstractSerializer<RoomInviteMessage>(MessageComposer.RoomInviteComposer)
{
    protected override void Serialize(IServerPacket packet, RoomInviteMessage message)
    {
        packet.WriteInteger(message.SenderId);
        packet.WriteString(message.Message);
    }
}
