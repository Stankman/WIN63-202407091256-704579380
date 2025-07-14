using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.AvatarEffect;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Inventory.AvatarEffect;
public class AvatarEffectsSerializer() : AbstractSerializer<AvatarEffectsMessage>(MessageComposer.AvatarEffectsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, AvatarEffectsMessage message)
    {
        packet.WriteInteger(0);
    }
}
