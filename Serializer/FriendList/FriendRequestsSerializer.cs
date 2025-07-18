using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class FriendRequestsSerializer() : AbstractSerializer<FriendRequestsMessage>(MessageComposer.FriendRequestsComposer)
{
    protected override void Serialize(IServerPacket packet, FriendRequestsMessage message)
    {
        packet.WriteInteger(message.Requests.Count);
        packet.WriteInteger(message.Requests.Count);

        foreach(var request in message.Requests)
        {
            FriendRequestDataSerializer.Serialize(packet, request);
        }
    }
}
