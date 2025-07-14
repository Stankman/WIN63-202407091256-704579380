using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Perk;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Perk;

public class PerkAllowancesMessageSerializer() : AbstractSerializer<PerkAllowancesMessage>(MessageComposer.PerkAllowancesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PerkAllowancesMessage message)
    {
        packet.WriteInteger(13);

        packet.WriteString("USE_GUIDE_TOOL");
        packet.WriteString("");
        packet.WriteBoolean(message.USE_GUIDE_TOOL);

        packet.WriteString("CALL_ON_HELPERS");
        packet.WriteString("");
        packet.WriteBoolean(message.CALL_ON_HELPERS);

        packet.WriteString("MOUSE_ZOOM");
        packet.WriteString("");
        packet.WriteBoolean(message.MOUSE_ZOOM);

        packet.WriteString("NAVIGATOR_PHASE_TWO_2014");
        packet.WriteString("");
        packet.WriteBoolean(message.NAVIGATOR_PHASE_TWO_2014);

        packet.WriteString("HABBO_CLUB_OFFER_BETA");
        packet.WriteString("");
        packet.WriteBoolean(message.HABBO_CLUB_OFFER_BETA);

        packet.WriteString("VOTE_IN_COMPETITIONS");
        packet.WriteString("");
        packet.WriteBoolean(message.VOTE_IN_COMPETITIONS);

        packet.WriteString("TRADE");
        packet.WriteString("requirement.unfulfilled.no_trade_lock");
        packet.WriteBoolean(message.TRADE);

        packet.WriteString("BUILDER_AT_WORK");
        packet.WriteString("requirement.unfulfilled.group_membership");
        packet.WriteBoolean(message.BUILDER_AT_WORK);

        packet.WriteString("NAVIGATOR_ROOM_THUMBNAIL_CAMERA");
        packet.WriteString("");
        packet.WriteBoolean(message.NAVIGATOR_ROOM_THUMBNAIL_CAMERA);

        packet.WriteString("CAMERA");
        packet.WriteString("");
        packet.WriteBoolean(message.CAMERA);

        packet.WriteString("UNITY_TRADE");
        packet.WriteString("requirement.unfulfilled.citizenship_level_3");
        packet.WriteBoolean(message.UNITY_TRADE);

        packet.WriteString("CITIZEN");
        packet.WriteString("");
        packet.WriteBoolean(message.CITIZEN);

        packet.WriteString("JUDGE_CHAT_REVIEWS");
        packet.WriteString("requirement.unfulfilled.helper_level_6");
        packet.WriteBoolean(message.JUDGE_CHAT_REVIEWS);
    }
}
