using Turbo.Core.Game.Rooms.Object.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.Rooms.Object.Logic.Avatar;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class UsersMessageSerializer() : AbstractSerializer<UsersMessage>(MessageComposer.UsersMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UsersMessage message)
    {
        packet.WriteInteger(message.RoomObjects.Count);

        foreach (var avatarObject in message.RoomObjects)
        {
            packet.WriteInteger(avatarObject.RoomObjectHolder.Id);
            packet.WriteString(avatarObject.RoomObjectHolder.Name);
            packet.WriteString(avatarObject.RoomObjectHolder.Motto);
            packet.WriteString(avatarObject.RoomObjectHolder.Figure);

            packet.WriteInteger(avatarObject.Id);
            packet.WriteInteger(avatarObject.Location.X);
            packet.WriteInteger(avatarObject.Location.Y);
            packet.WriteString(avatarObject.Location.Z.ToString());
            packet.WriteInteger((int)avatarObject.Location.Rotation);

            switch (avatarObject.Logic)
            {
                case RentableBotLogic:
                    packet.WriteInteger(4);
                    // do the composer for type 4
                    break;
                case BotLogic:
                    packet.WriteInteger(3);
                    // do the composer for type 3
                    break;
                case PetLogic:
                    packet.WriteInteger(2);
                    packet.WriteInteger(0); // todo : subtype
                                            // do the composer for type 2
                    break;
                case AvatarLogic:
                    packet.WriteInteger(1);
                    packet.WriteString(Enum.GetName(typeof(AvatarGender), avatarObject.RoomObjectHolder.Gender));
                    packet.WriteInteger(0);// todo: group id
                    packet.WriteInteger(0); // todo: group status
                    packet.WriteString("");// todo: group name
                    packet.WriteString(""); // swim figure
                    packet.WriteInteger(0);// todo : activity points
                    packet.WriteBoolean(false);// todo : is moderator
                    break;
            }
        }
    }
}