﻿namespace Rasa.Packets.MapChannel.Server
{
    using Data;
    using Memory;

    public class ItemInfoPacket : PythonPacket
    {
        public override GameOpcode Opcode { get; } = GameOpcode.ItemInfo;

        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public string CrafterName { get; set; }
        public int ItemTemplateId { get; set; }
        public bool HasSellableFlag { get; set; }
        public bool HasCharacterUniqueFlag { get; set; }
        public bool HasAccountUniqueFlag { get; set; }
        public bool HasBoEFlag { get; set; }
        public int[] ClassModuleIds { get; set; }
        public int[] LootModuleIds { get; set; }
        public int QualityId { get; set; }
        public bool BoundToCharacter { get; set; }
        public bool NotTradable { get; set; }
        public bool NotPlaceableInLockbox { get; set; }
        public int InventoryCategory { get; set; }

        public override void Read(PythonReader pr)
        {
        }

        public override void Write(PythonWriter pw)
        {
            pw.WriteTuple(15);
            pw.WriteInt(CurrentHitPoints);      // 'currentHitPoints' --> Displayed as "Armor: x" in case of armor
            pw.WriteInt(MaxHitPoints);
            if (CrafterName != null)
                pw.WriteString(CrafterName);
            else
                pw.WriteNoneStruct();
            pw.WriteInt((int)ItemTemplateId);
            pw.WriteBool(HasSellableFlag);
            pw.WriteBool(HasCharacterUniqueFlag);
            pw.WriteBool(HasAccountUniqueFlag);
            pw.WriteBool(HasBoEFlag);
            pw.WriteList(0);                    // 'classModuleIds'         // ToDo
            pw.WriteList(0);                    // 'lootModuleIds'          // ToDo
            pw.WriteInt(QualityId);
            pw.WriteBool(BoundToCharacter);
            pw.WriteBool(NotTradable);
            pw.WriteBool(NotPlaceableInLockbox);
            pw.WriteInt(InventoryCategory);
        }
    }
}
