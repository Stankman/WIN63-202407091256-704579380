using Turbo.Core.Game.Rooms;
using Turbo.Core.Packets.Messages;

namespace Turbo.WIN63202407091256704579380.Serializer.RoomSettings.Types;
public static class RoomChatSettingsSerializer
{
    public static void Serialize(IServerPacket packet, IRoomDetails roomDetails)
    {
        packet.WriteInteger((int)roomDetails.ChatModeType); //mode
        packet.WriteInteger((int)roomDetails.ChatWeightType); //bubbleWidth
        packet.WriteInteger((int)roomDetails.ChatSpeedType); //scrollSpeed
        packet.WriteInteger(roomDetails.ChatDistance); //fullHearRange
        packet.WriteInteger((int)roomDetails.ChatProtectionType); //floodSensitivity
    }
}