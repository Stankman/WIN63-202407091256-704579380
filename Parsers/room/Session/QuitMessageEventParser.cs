﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Session;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.room;

public class QuitMessageEventParser : AbstractParser<QuitMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new QuitMessage();
}