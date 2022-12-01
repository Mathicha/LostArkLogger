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
    public class PKTNewPC
    {
        public PKTNewPC(BitReader reader)
        {
            Unk0 = reader.ReadByte();
            if(Unk0 == 1)
            {
                Unk4_0_m = reader.ReadBytes(12);
            }
            Unk1 = reader.ReadByte();
            if(Unk1 == 1)
            {
                TrackMoveInfo = new TrackMoveInfo(reader);
            }
            PCStruct = new PCStruct(reader);
            Unk0_m = reader.ReadByte();
            Unk2_m = reader.ReadByte();
            Unk5 = reader.ReadByte();
            if(Unk5 == 1)
            {
                Unk5_0_m = reader.ReadBytes(20);
            }
            Unk6 = reader.ReadByte();
            if(Unk6 == 1)
            {
                Unk3_0_m = reader.ReadUInt32();
            }
        }

        public byte Unk0 { get; }
        public byte[] Unk4_0_m { get; }
        public byte Unk1 { get; }
        public TrackMoveInfo TrackMoveInfo { get; } = new TrackMoveInfo();
        public PCStruct PCStruct { get; } = new PCStruct();
        public byte Unk0_m { get; }
        public byte Unk2_m { get; }
        public byte Unk5 { get; }
        public byte[] Unk5_0_m { get; }
        public byte Unk6 { get; }
        public uint Unk3_0_m { get; }
    }
}