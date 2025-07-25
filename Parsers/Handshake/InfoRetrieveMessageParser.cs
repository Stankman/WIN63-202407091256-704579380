﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Handshake;

public class InfoRetrieveMessageParser : AbstractParser<InfoRetrieveMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new InfoRetrieveMessage();
}