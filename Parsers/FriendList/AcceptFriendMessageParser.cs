using Turbo.Core.Game.Players;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.FriendList;

public class AcceptFriendMessageParser : AbstractParser<AcceptFriendMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var friendsCount = packet.PopInt();

        var friends = new List<int>(friendsCount);

        for (var i = 0; i < friendsCount; i++)
        {
            var userId = packet.PopInt();

            friends.Add(userId);
        }

        return new AcceptFriendMessage
        {
            Friends = friends
        };
    }
}
