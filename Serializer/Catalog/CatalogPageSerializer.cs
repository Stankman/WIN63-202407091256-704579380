using Turbo.Core.Game.Catalog.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;
using Turbo.WIN63202407091256704579380.Serializer.Catalog.Types;

namespace Turbo.WIN63202407091256704579380.Serializer.Catalog;
public class CatalogPageSerializer() : AbstractSerializer<CatalogPageMessage>(MessageComposer.CatalogPageMessageComposer)
{
    protected override void Serialize(IServerPacket packet, CatalogPageMessage message)
    {
        packet.WriteInteger(message.PageId);
        packet.WriteString(message.CatalogType);
        packet.WriteString(message.LayoutCode);

        packet.WriteInteger(3);

        packet.WriteString("catalog_tag_general_2");
        packet.WriteString("catalog_teaser_xm10_skate");
        packet.WriteString("catalog_special_txtbg2");

        packet.WriteInteger(3);

        packet.WriteString("The fun is ON with our new game! Skate on ice and play Tag with your friends using the new Tag Pole and Ice Skating Patch! Not sure how to put on your skates? Step on an Ice Patch and you're good to go.");
        packet.WriteString("");
        packet.WriteString("Freeze! You're it");

        packet.WriteInteger(message.Offers.Count);

        foreach (var offer in message.Offers) OfferSerializer.Serialize(packet, offer, true, true);

        packet.WriteInteger(message.OfferId);

        packet.WriteBoolean(message.AcceptSeasonCurrencyAsCredits);

        packet.WriteInteger(message.FrontPageItems.Count);

        foreach (var item in message.FrontPageItems)
        {
            packet.WriteInteger(item.Position);
            packet.WriteString(item.Name);
            packet.WriteString(item.PromoImage);
            packet.WriteInteger((int)item.Type);

            switch (item.Type)
            {
                case FrontPageItemType.CatalogPage:
                    packet.WriteString(""); // page location
                    break;
                case FrontPageItemType.Iap:
                    packet.WriteString(""); // product code
                    break;
                case FrontPageItemType.ProductOffer:
                    packet.WriteInteger(-1); // offer id
                    break;
            }

            packet.WriteInteger(item.Expiration.Second);
        }
    }
}
