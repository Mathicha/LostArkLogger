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
    public class PKTSkillStageNotify
    {
        public PKTSkillStageNotify(BitReader reader)
        {
            reader.Skip(8);
            Stage = reader.ReadByte();
            reader.Skip(28);
            SourceId = reader.ReadUInt64();
            reader.Skip(4);
            SkillId = reader.ReadUInt32();
        }

        public byte Stage { get; }
        public ulong SourceId { get; }
        public uint SkillId { get; }
    }
}