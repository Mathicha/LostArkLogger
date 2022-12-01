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
    public class PKTNewNpcSummon
    {
        public PKTNewNpcSummon(BitReader reader)
        {
            reader.Skip(31);
            OwnerId = reader.ReadUInt64();
            PublishReason = reader.ReadByte();
            NpcData = new NpcData(reader);
        }

        public ulong OwnerId { get; }
        public byte PublishReason { get; }
        public NpcData NpcData { get; } = new NpcData();
    }
}