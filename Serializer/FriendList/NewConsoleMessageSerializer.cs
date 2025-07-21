using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class NewConsoleMessageSerializer() : AbstractSerializer<NewConsoleMessageMessage>(MessageComposer.NewConsoleMessageComposer)
{
    protected override void Serialize(IServerPacket packet, NewConsoleMessageMessage message)
    {
        packet.WriteInteger(0); //ChatId
        packet.WriteString(""); //Message Text
        packet.WriteInteger(0); //Seconds Since
        packet.WriteString(""); //Message Id
        packet.WriteInteger(0); //Confirmation Id
        packet.WriteInteger(0); //Sender Id
        packet.WriteString(""); //Sender Name
        packet.WriteString(""); //Sender Figure
    }
}
