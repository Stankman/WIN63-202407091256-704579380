using Turbo.Core.Game.Messenger.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;
public class FriendListUpdateSerializer() : AbstractSerializer<FriendListUpdateMessage>(MessageComposer.FriendListUpdateComposer)
{
    protected override void Serialize(IServerPacket packet, FriendListUpdateMessage message)
    {
        packet.WriteInteger(0); //Categories Count

        packet.WriteInteger(message.FriendListUpdate.Count);

        foreach(var friend in message.FriendListUpdate)
        {
            if(friend.UpdateType.Equals(FriendListUpdateActionEnum.Added) || friend.UpdateType.Equals(FriendListUpdateActionEnum.Updated))
            {
                packet.WriteInteger((int)friend.UpdateType);
                FriendDataSerializer.Serialize(packet, friend);
            }
            else if(friend.UpdateType.Equals(FriendListUpdateActionEnum.Removed))
            {
                packet.WriteInteger((int)friend.UpdateType);
                packet.WriteInteger(friend.FriendId);
            }
        }
    }
}
