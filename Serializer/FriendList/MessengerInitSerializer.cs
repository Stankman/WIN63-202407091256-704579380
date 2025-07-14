using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class MessengerInitSerializer() : AbstractSerializer<MessengerInitMessage>(MessageComposer.MessengerInitComposer)
{
    protected override void Serialize(IServerPacket packet, MessengerInitMessage message)
    {
        packet.WriteInteger(message.userFriendLimit);
        packet.WriteInteger(message.normalFriendLimit);
        packet.WriteInteger(message.extendedFriendLimit);
        packet.WriteInteger(0);  //Categories Count

        //packet.WriteInteger(0);  //Category ID
        //packet.WriteString(""); //Category Name
    }
}
