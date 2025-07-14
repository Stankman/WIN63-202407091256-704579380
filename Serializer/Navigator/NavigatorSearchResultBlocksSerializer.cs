using Turbo.Core.Game.Navigator;
using Turbo.Core.Game.Rooms;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class NavigatorSearchResultBlocksSerializer() : AbstractSerializer<NavigatorSearchResultBlocksMessage>(MessageComposer.NavigatorSearchResultBlocksComposer)
{
    protected override void Serialize(IServerPacket packet, NavigatorSearchResultBlocksMessage message)
    {
        packet.WriteString(message.SearchCode); // var_503 equivalent
        packet.WriteString(message.Filtering);  // var_365 equivalent

        // Serialize the number of result blocks (equivalent to _loc3_)
        packet.WriteInteger(message.Results.Count);

        // Iterate through each result block and serialize it
        foreach (var resultBlock in message.Results)
        {
            SerializeResultBlock(packet, resultBlock);
        }
    }

    private void SerializeResultBlock(IServerPacket packet, ISearchResultData resultBlock)
    {
        packet.WriteString(resultBlock.SearchCode); // searchCodeOriginal equivalent
        packet.WriteString(resultBlock.Text);       // Text or other properties

        // Serialize additional properties such as action allowed, force closed, view mode, etc.
        packet.WriteInteger(resultBlock.ActionAllowed);
        packet.WriteBoolean(resultBlock.ForceClosed);
        packet.WriteInteger(resultBlock.ViewMode);

        // Serialize the number of rooms within this block
        packet.WriteInteger(resultBlock.Rooms.Count);

        // Serialize each room in the block
        foreach (var room in resultBlock.Rooms)
        {
            SerializeGuestRoom(packet, room);
        }
    }

    private void SerializeGuestRoom(IServerPacket packet, IRoom room)
    {
        packet.WriteInteger(room.Id);              // Room ID
        packet.WriteString(room.RoomDetails.Name);             // Room Name
        packet.WriteInteger(room.RoomDetails.PlayerId);         // Owner ID
        packet.WriteString(room.RoomDetails.PlayerName);        // Owner Name
        packet.WriteInteger((int)room.RoomDetails.State);
        packet.WriteInteger(room.RoomDetails.UsersNow);        // Current users in the room
        packet.WriteInteger(room.RoomDetails.UsersMax);        // Max users allowed in the room
        packet.WriteString(room.RoomDetails.Description);      // Room Description
        packet.WriteInteger((int)room.RoomDetails.TradeType);
        packet.WriteInteger(0);                    // Room Score
        packet.WriteInteger(0);                    // Room Ranking
        packet.WriteInteger(1);                    // Category ID
        packet.WriteInteger(0);                    // Number of tags
        packet.WriteInteger(0);
        // Add any additional room details as needed...
    }
}