using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Parsers.room
{
    public class RoomQueueStatusMessageSerializer() : AbstractSerializer<RoomQueueStatusMessage>(MessageComposer.RoomQueueStatusMessageComposer)
    {
        protected override void Serialize(IServerPacket packet, RoomQueueStatusMessage message)
        {
            packet.WriteInteger(message.flatID);
            packet.WriteInteger(message.activeTarget);

            packet.WriteInteger(message.queueSetTargets.Count);
            foreach (var target in message.queueSetTargets)
            {
                packet.WriteInteger(target);
            }

            foreach (var queueType in message.queueTypes)
            {
                packet.WriteString(queueType);
            }
        }
    }
}