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
    public class PKTTriggerStartNotify
    {
        public PKTTriggerStartNotify(BitReader reader)
        {
            TriggerId = reader.ReadUInt32();
            SourceId = reader.ReadUInt64();
            TriggerSignalType = reader.ReadUInt32();
            InvolvedPCs = new PCIds(reader);
        }

        public uint TriggerId { get; }
        public ulong SourceId { get; }
        public uint TriggerSignalType { get; }
        public PCIds InvolvedPCs { get; } = new PCIds();
    }
}