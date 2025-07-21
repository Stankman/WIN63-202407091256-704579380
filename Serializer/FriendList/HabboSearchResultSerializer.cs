using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class HabboSearchResultSerializer() : AbstractSerializer<HabboSearchResultMessage>(MessageComposer.HabboSearchResultComposer)
{
    protected override void Serialize(IServerPacket packet, HabboSearchResultMessage message)
    {
        packet.WriteInteger(message.Friends.Count);
        
        foreach(var friend in message.Friends)
        {
            packet.WriteInteger(friend.Id);
            packet.WriteString(friend.Name);
            packet.WriteString(friend.Motto);
            packet.WriteInteger((int) friend.Status);
            packet.WriteBoolean(friend.PlayerPreferences.isAllowingFriendFollow);
            packet.WriteString(""); //Last Online
            packet.WriteInteger((int) friend.Gender);
            packet.WriteString(friend.Figure);
            packet.WriteString(""); //Real Name
        }

        packet.WriteInteger(message.Others.Count);

        foreach (var other in message.Others)
        {
            packet.WriteInteger(other.Id);
            packet.WriteString(other.Name);
            packet.WriteString(other.Motto);
            packet.WriteInteger((int)other.Status);
            packet.WriteBoolean(other.PlayerPreferences.isAllowingFriendFollow);
            packet.WriteString(""); //Last Online
            packet.WriteInteger((int)other.Gender);
            packet.WriteString(other.Figure);
            packet.WriteString(""); //Real Name
        }
    }
}
