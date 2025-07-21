using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.FriendList;
public class SendRoomInviteMessageParser : AbstractParser<SendRoomInviteMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var friendIds = new List<int>();

        var totalInvites = packet.PopInt();

        for (var i = 0; i < totalInvites; i++)
        {
            friendIds.Add(packet.PopInt());
        }

        var message = packet.PopString();

        return new SendRoomInviteMessage
        {
            FriendIds = friendIds,
            Message = message
        };
    }
}
