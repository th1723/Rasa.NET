﻿using System.Collections.Generic;

namespace Rasa.Packets.MapChannel.Server
{
    using Data;
    using Memory;

    public class DisplayClientMessagePacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.DisplayClientMessage;

        public int MsgId { get; set; }                          // from playermessagelanguage.pyo
        public Dictionary<string, string> Args { get; set; }     
        public int Filterid { get; set; }                       // from clientmessagefilterlanguage

        public DisplayClientMessagePacket(int msgId, Dictionary<string, string> args, int filterId)
        {
            MsgId = msgId;
            Args = args;
            Filterid = filterId;
        }

        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
            pw.WriteTuple(3);
            pw.WriteInt(MsgId);
            pw.WriteDictionary(Args.Count);
            foreach (var arg in Args)
            {
                pw.WriteString(arg.Key);
                pw.WriteString(arg.Value);
            }
            pw.WriteInt(Filterid);
        }
    }
}