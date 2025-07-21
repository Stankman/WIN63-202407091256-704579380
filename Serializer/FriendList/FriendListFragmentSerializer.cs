using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;
public class FriendListFragmentSerializer() : AbstractSerializer<FriendListFragmentMessage>(MessageComposer.FriendListFragmentMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FriendListFragmentMessage message)
    {
        packet.WriteInteger(0); //Total Fragments
        packet.WriteInteger(0); //Fragment Number
        packet.WriteInteger(0); //Friends Count

        //FriendDataSerializer.Serialize(packet, message.Friends);
    }
}