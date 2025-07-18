using System.Runtime.CompilerServices;
using Turbo.Core.Game.Messenger.Friends;
using Turbo.Core.Game.Players;
using Turbo.Core.Game.Players.Constants;
using Turbo.Core.Packets.Messages;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;
public static class FriendDataSerializer
{
    public static void Serialize(IServerPacket packet, IMessengerFriend messengerFriend)
    {
        packet.WriteInteger(messengerFriend.Friend.Id);
        packet.WriteString(messengerFriend.Friend.Name);
        packet.WriteInteger((int) messengerFriend.Friend.Gender);
        packet.WriteBoolean(messengerFriend.Friend.Status.Equals(PlayerStatusEnum.Online)); //Is Online?
        packet.WriteBoolean(true); //Can be followed?
        packet.WriteString(messengerFriend.Friend.Figure);
        packet.WriteInteger(0);
        packet.WriteString(messengerFriend.Friend.Motto);
        packet.WriteString(""); //RealName
        packet.WriteString(""); //Facebook ID
        packet.WriteBoolean(false); //Persisted Message User ?? What's this?
        packet.WriteBoolean(false); //Friend is VIP Member?
        packet.WriteBoolean(false); //Is Pocket Habbo User?
        packet.WriteShort((int) messengerFriend.RelationType); //Relationship Status
    }
}
