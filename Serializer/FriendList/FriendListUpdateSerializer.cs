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

        int totalFriends = 0;

        if(message.RemovedFriends != null)
        {
            totalFriends += message.RemovedFriends.Count;
        }

        if(message.UpdatedFriends != null)
        {
            totalFriends += message.UpdatedFriends.Count;
        }

        if(message.AddedFriends != null)
        {
            totalFriends += message.AddedFriends.Count;
        }

        packet.WriteInteger(totalFriends);

        if(message.RemovedFriends != null)
        {
            foreach (var removedFriendId in message.RemovedFriends)
            {
                packet.WriteInteger((int) FriendListUpdateActionEnum.Remove);
                packet.WriteInteger(removedFriendId);
            }
        }

        if(message.UpdatedFriends != null)
        {
            foreach (var updatedFriend in message.UpdatedFriends)
            {
                packet.WriteInteger((int) FriendListUpdateActionEnum.Update);
                FriendDataSerializer.Serialize(packet, updatedFriend);
            }
        }

        if(message.AddedFriends != null)
        {
            foreach (var addedFriend in message.AddedFriends)
            {
                packet.WriteInteger((int) FriendListUpdateActionEnum.Add);
                FriendDataSerializer.Serialize(packet, addedFriend);
            }
        }
    }
}
