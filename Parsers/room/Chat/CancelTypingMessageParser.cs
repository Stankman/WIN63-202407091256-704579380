using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Chat;

public class CancelTypingMessageParser : AbstractParser<CancelTypingMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        return new CancelTypingMessage();
    }
}