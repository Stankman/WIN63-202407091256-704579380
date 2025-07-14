using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Chat;

public class WhisperMessageParser : AbstractParser<WhisperMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var message = packet.PopString();
        var recipient = message.Split(" ")[0];
        var text = message[(recipient.Length + 1)..];

        return new WhisperMessage
        {
            Text = text,
            RecipientName = recipient,
            StyleId = packet.PopInt()
        };
    }
}