using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class RoomInviteErrorSerializer() : AbstractSerializer<RoomInviteErrorMessage>(MessageComposer.RoomInviteErrorComposer)
{
    protected override void Serialize(IServerPacket packet, RoomInviteErrorMessage message)
    {
        packet.WriteInteger(message.ErrorCode);

        if (message.ErrorCode == 1)
        {
            if (message.FailedRecipients == null) 
                packet.WriteInteger(0);
            else
            {
                packet.WriteInteger(message.FailedRecipients.Count);

                foreach (var recipient in message.FailedRecipients)
                {
                    packet.WriteInteger(recipient);
                }
            }
        }
    }
}
