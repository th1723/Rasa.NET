﻿namespace Rasa.Packets.MapChannel.Server
{
    using Data;
    using Memory;

    public class PlayerFlagsPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.PlayerFlags;

        public int PlayerFlags { get; set; } 

        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
            pw.WriteTuple(1);
            pw.WriteInt(0xFFFFFFF); // actually should be a tuple or list or values?
        }
    }
}

