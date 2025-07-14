using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Tracking;

public class LatencyPingRequestMessageParser : AbstractParser<LatencyPingRequestMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new LatencyPingRequestMessage()
    {
        ID = packet.PopInt()
    };
}