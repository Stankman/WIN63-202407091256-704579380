using System.Runtime.CompilerServices;
using Turbo.Core.Game.Messenger.Friends;
using Turbo.Core.Game.Players;
using Turbo.Core.Game.Players.Constants;
using Turbo.Core.Packets.Messages;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;
public static class FriendDataSerializer
{
    public static void Serialize(IServerPacket packet, IMessengerFriendUpdate friend)
    {
        packet.WriteInteger(friend.FriendId);
        packet.WriteString(friend.FriendData!.Friend.Name);
        packet.WriteInteger((int) friend.FriendData!.Friend.Gender);
        packet.WriteBoolean(friend.FriendData!.Friend.Status.Equals(PlayerStatusEnum.Online)); //Is Online?
        packet.WriteBoolean(true); //Can be followed?
        packet.WriteString(friend.FriendData!.Friend.Figure);
        packet.WriteInteger(0);
        packet.WriteString(friend.FriendData!.Friend.Motto);
        packet.WriteString(""); //RealName
        packet.WriteString(""); //Facebook ID
        packet.WriteBoolean(false); //Persisted Message User ?? What's this?
        packet.WriteBoolean(false); //Friend is VIP Member?
        packet.WriteBoolean(false); //Is Pocket Habbo User?
        packet.WriteShort((int) friend.FriendData!.RelationType); //Relationship Status
    }
}
