using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class ConsoleMessageHistorySerializer() : AbstractSerializer<ConsoleMessageHistoryMessage>(MessageComposer.ConsoleMessageHistoryComposer)
{
    protected override void Serialize(IServerPacket packet, ConsoleMessageHistoryMessage message)
    {
        packet.WriteInteger(0); //ChatId
        packet.WriteInteger(0); //History Fragment Length

        //Foreach History Fragment
        packet.WriteInteger(0); //Sender Id
        packet.WriteString(""); //Sender Name
        packet.WriteString(""); //Sender Figure
        packet.WriteString(""); //Message
        packet.WriteInteger(0); //Seconds since Sent
        packet.WriteString(""); //Message Id
    }
}
