using Turbo.Core.Game.Messenger.Requests;
using Turbo.Core.Packets.Messages;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;
public static class FriendRequestDataSerializer
{
    public static void Serialize(IServerPacket packet, IMessengerRequest messengerRequest)
    {
        packet.WriteInteger(messengerRequest.PlayerEntityId);
        packet.WriteString(messengerRequest.PlayerEntity.Name);
        packet.WriteString(messengerRequest.PlayerEntity.Figure);
    }
}
