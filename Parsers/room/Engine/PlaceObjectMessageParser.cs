using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Engine;
public class PlaceObjectMessageParser : AbstractParser<PlaceObjectMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        string data = packet.PopString();
        string[] parts = data.Split(" ");
        if (int.TryParse(parts[0], out int id) && parts.Length > 1)
        {
            if (parts[1].StartsWith(":"))
            {
                return new PlaceObjectMessage
                {
                    ObjectId = id,
                    WallLocation = data[(parts[0].Length + 1)..]
                };
            }
            else
            {
                return new PlaceObjectMessage
                {
                    ObjectId = id,
                    X = int.Parse(parts[1]),
                    Y = int.Parse(parts[2]),
                    Direction = int.Parse(parts[3])
                };
            }
        }

        return null;
    }
}
