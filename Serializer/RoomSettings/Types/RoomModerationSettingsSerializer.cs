using Turbo.Core.Game.Rooms;
using Turbo.Core.Packets.Messages;

namespace Turbo.WIN63202407091256704579380.Serializer.RoomSettings.Types;
public static class RoomModerationSettingsSerializer
{
    public static void Serialize(IServerPacket packet, IRoomDetails roomDetails)
    {
        packet.WriteInteger((int)roomDetails.MuteType); //whoCanMute
        packet.WriteInteger((int)roomDetails.KickType); //whoCanKick
        packet.WriteInteger((int)roomDetails.BanType); //whoCanBan
    }
}
