using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Parsers.room;

public class YouAreSpectatorMessageSerializer() : AbstractSerializer<YouAreSpectatorMessage>(MessageComposer.YouAreSpectatorMessageComposer)
{
    protected override void Serialize(IServerPacket packet, YouAreSpectatorMessage message)
    {
        packet.WriteInteger(message.flatId);
    }
}