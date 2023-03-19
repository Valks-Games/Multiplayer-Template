﻿namespace Sandbox2;

public class SPacketPlayerJoin : APacketServer
{
    public uint Id { get; set; }

    public override void Write(PacketWriter writer)
    {
        writer.Write((uint)Id);
    }

    public override void Read(PacketReader reader)
    {
        Id = reader.ReadUInt();
    }

    public override void Handle()
    {
        GameMaster.AddPlayer(Id);
    }
}