/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArkLogger.Types;

namespace LostArkLogger
{
    public class SkillDamageAbnormalMoveEvent
    {
        public bool valid = false;
        internal SkillDamageAbnormalMoveEvent()
        {
            //Made for conditional structures
        }

        internal SkillDamageAbnormalMoveEvent(BitReader reader)
        {
            valid = true;
            Position = reader.ReadVector3F();
            Unk3_m = reader.ReadUInt16();
            Destination = reader.ReadVector3F();
            Unk4_m = reader.ReadUInt16();
            DamageEvent = new SkillDamageEvent(reader);
            Unk2_m = reader.ReadUInt64();
            Unk1_m = reader.ReadByte();
            Unk8_m = reader.ReadUInt16();
            Unk0_m = new ReadFlagBytes2(reader);
        }

        public Vector3F Position { get; }
        public ushort Unk3_m { get; }
        public Vector3F Destination { get; }
        public ushort Unk4_m { get; }
        public SkillDamageEvent DamageEvent { get; } = new SkillDamageEvent();
        public ulong Unk2_m { get; }
        public byte Unk1_m { get; }
        public ushort Unk8_m { get; }
        public ReadFlagBytes2 Unk0_m { get; } = new ReadFlagBytes2();
    }
}