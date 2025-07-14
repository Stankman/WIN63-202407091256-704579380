using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Purse;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Inventory.Purse;
public class CreditBalanceSerializer() : AbstractSerializer<CreditBalanceMessage>(MessageComposer.CreditBalanceComposer)
{
    protected override void Serialize(IServerPacket packet, CreditBalanceMessage message)
    {
        packet.WriteString(message.credits + ".0");
    }
}
