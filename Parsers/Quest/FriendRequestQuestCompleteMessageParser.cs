using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Quest;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Quest;

public class FriendRequestQuestCompleteMessageParser : AbstractParser<FriendRequestQuestCompleteMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new FriendRequestQuestCompleteMessage();
}
