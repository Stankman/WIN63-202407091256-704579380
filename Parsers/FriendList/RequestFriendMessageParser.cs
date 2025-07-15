using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.FriendList;
public class RequestFriendMessageParser : AbstractParser<RequestFriendMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RequestFriendMessage 
    {
        PlayerName = packet.PopString()
    };
}
