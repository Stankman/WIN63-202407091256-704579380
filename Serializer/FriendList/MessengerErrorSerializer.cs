using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;
public class MessengerErrorSerializer() : AbstractSerializer<MessengerErrorMessage>(MessageComposer.MessengerErrorComposer)
{
    protected override void Serialize(IServerPacket packet, MessengerErrorMessage message)
    {
        packet.WriteInteger(0);
        packet.WriteInteger((int)message.ErrorCode);
    }
}
