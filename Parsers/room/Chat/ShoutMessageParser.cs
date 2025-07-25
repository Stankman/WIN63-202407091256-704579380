using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Chat;

public class ShoutMessageParser : AbstractParser<ShoutMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var text = packet.PopString();
        var styleId = packet.PopInt();

        return new ShoutMessage()
        {
            Text = text,
            StyleId = styleId
        };
    }
}