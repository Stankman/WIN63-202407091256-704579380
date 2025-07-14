using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.MysteryBox;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.MysteryBox;
public class MysteryBoxKeysSerializer() : AbstractSerializer<MysteryBoxKeysMessage>(MessageComposer.MysteryBoxKeysMessageComposer)
{
    protected override void Serialize(IServerPacket packet, MysteryBoxKeysMessage message)
    {
        packet.WriteInteger(0);
    }
}
