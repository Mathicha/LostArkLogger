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
    public class PCStruct
    {
        public bool valid = false;
        internal PCStruct()
        {
            //Made for conditional structures
        }

        internal PCStruct(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadByte();
            Unk1 = reader.ReadByte();
            Unk2 = reader.ReadByte();
            Unk3 = reader.ReadInt32();
            Unk4 = reader.ReadInt32();
            Unk5 = reader.ReadByte();
            statusEffectDatas = new StatusEffectDatas(reader);
            PlayerId = reader.ReadUInt64();
            Level = reader.ReadUInt16();
            Unk9 = reader.ReadInt32();
            Unk10 = reader.ReadByte();
            ClassId = reader.ReadUInt16();
            Unk12 = reader.ReadByte();
            Unk13 = reader.ReadInt16();
            Unk14 = reader.ReadBytes(5);
            statPair = new StatPair(reader);
            Unk16 = reader.ReadInt32();
            Unk17 = new Struct_297(reader);
            Unk18 = new Struct_2(reader);
            Unk19 = new Struct_87(reader);
            Unk20 = reader.ReadByte();
            Unk21 = reader.ReadInt32();
            Unk22 = reader.ReadByte();
            Unk23 = new Struct_296(reader);
            Unk5_m = reader.ReadUInt32();
            Unk25 = reader.ReadBytes(25);
            Unk26 = new Struct_119(reader);
            Unk27 = reader.ReadInt32();
            Unk28 = reader.ReadInt16();
            CharacterId = reader.ReadUInt64();
            Unk30 = reader.ReadInt16();
            GearLevel = reader.ReadUInt32();
            Heading = reader.ReadAngle();
            Name = new LostArkString(reader);
            Unk34 = reader.ReadByte();
            if(Unk34 == 1)
            {
                Unk34_0 = reader.ReadBytes(12);
            }
            Unk35 = reader.ReadByte();
            Unk36 = new LostArkString(reader);
            Unk37 = reader.ReadInt32();
            Unk38 = reader.ReadInt32();
            Unk39 = reader.ReadByte();
            Unk40 = new Struct_370(reader);
            Unk41 = reader.ReadInt64();
            Unk42 = reader.ReadByte();
            Unk43 = reader.ReadByte();
        }

        public byte Unk0 { get; }
        public byte Unk1 { get; }
        public byte Unk2 { get; }
        public int Unk3 { get; }
        public int Unk4 { get; }
        public byte Unk5 { get; }
        public StatusEffectDatas statusEffectDatas { get; } = new StatusEffectDatas();
        public ulong PlayerId { get; }
        public uint Level { get; }
        public int Unk9 { get; }
        public byte Unk10 { get; }
        public ushort ClassId { get; }
        public byte Unk12 { get; }
        public short Unk13 { get; }
        public byte[] Unk14 { get; }
        public StatPair statPair { get; } = new StatPair();
        public int Unk16 { get; }
        public Struct_297 Unk17 { get; } = new Struct_297();
        public Struct_2 Unk18 { get; } = new Struct_2();
        public Struct_87 Unk19 { get; } = new Struct_87();
        public byte Unk20 { get; }
        public int Unk21 { get; }
        public byte Unk22 { get; }
        public Struct_296 Unk23 { get; } = new Struct_296();
        public uint Unk5_m { get; }
        public byte[] Unk25 { get; }
        public Struct_119 Unk26 { get; } = new Struct_119();
        public int Unk27 { get; }
        public short Unk28 { get; }
        public ulong CharacterId { get; }
        public short Unk30 { get; }
        public uint GearLevel { get; }
        public Angle Heading { get; }
        public LostArkString Name { get; } = new LostArkString();
        public byte Unk34 { get; }
        public byte[] Unk34_0 { get; }
        public byte Unk35 { get; }
        public LostArkString Unk36 { get; } = new LostArkString();
        public int Unk37 { get; }
        public int Unk38 { get; }
        public byte Unk39 { get; }
        public Struct_370 Unk40 { get; } = new Struct_370();
        public long Unk41 { get; }
        public byte Unk42 { get; }
        public byte Unk43 { get; }
    }
}