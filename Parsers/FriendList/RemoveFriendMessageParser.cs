using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.FriendList;
public class RemoveFriendMessageParser : AbstractParser<RemoveFriendMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var friendIds = new List<int>();

        var totalFriends = packet.PopInt();

        for (var i = 0; i < totalFriends; i++)
        {
            friendIds.Add(packet.PopInt());
        }

        return new RemoveFriendMessage
        {
            FriendIds = friendIds
        };
    }
}
