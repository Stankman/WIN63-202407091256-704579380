using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.FriendList;
public class GetMessengerHistoryParser : AbstractParser<GetMessengerHistoryMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetMessengerHistoryMessage
    {
        ChatId = packet.PopInt(),
        Message = packet.PopString()
    };
}
