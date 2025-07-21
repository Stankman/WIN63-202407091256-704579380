using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class InstantMessageErrorSerializer() : AbstractSerializer<InstantMessageErrorMessage>(MessageComposer.InstantMessageErrorComposer)
{
    protected override void Serialize(IServerPacket packet, InstantMessageErrorMessage message)
    {
        packet.WriteInteger(message.ErrorCode);
        packet.WriteInteger(message.PlayerId);
        packet.WriteString(message.Message);
    }
}
