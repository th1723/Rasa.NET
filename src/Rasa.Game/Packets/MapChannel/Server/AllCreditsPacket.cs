﻿namespace Rasa.Packets.MapChannel.Server
{
    using Data;
    using Memory;

    public class AllCreditsPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.AllCredits;

        public int Credits { get; set; }
        public int Prestige { get; set; }

        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
            pw.WriteTuple(1);
            pw.WriteList(2);
            pw.WriteTuple(2);
            pw.WriteInt(1);         // Credits type id 1 = credits
            pw.WriteInt(Credits);   // value
            pw.WriteTuple(2);
            pw.WriteInt(2);         // Credits type id 2 = prestige
            pw.WriteInt(Prestige);  // value
        }
    }
}
