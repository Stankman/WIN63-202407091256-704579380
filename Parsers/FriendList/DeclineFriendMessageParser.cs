using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.FriendList;

public class DeclineFriendMessageParser : AbstractParser<DeclineFriendMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var declineAll = packet.PopBoolean();

        if (declineAll)
        {
            return new DeclineFriendMessage
            {
                DeclineAll = declineAll
            };
        }
        else
        {
            var friendsCount = packet.PopInt();

            var friends = new List<int>(friendsCount);

            for (var i = 0; i < friendsCount; i++)
            {
                var userId = packet.PopInt();

                friends.Add(userId);
            }

            return new DeclineFriendMessage
            {
                DeclineAll = declineAll,
                Friends = friends
            };
        }
    }
}
