using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Achievements;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Achievements;
public class GetAchievementsParser : AbstractParser<GetAchievementsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetAchievementsMessage();
}
