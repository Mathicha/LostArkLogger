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
    public class SkillDamageEvents
    {
        public bool valid = false;
        internal SkillDamageEvents()
        {
            //Made for conditional structures
        }

        internal SkillDamageEvents(BitReader reader)
        {
            valid = true;
            Count = reader.ReadUInt16();
            if(Count <= 50)
            {
                for(var i = 0; i < Count; i++)
                {
                    Events.Add(new SkillDamageEvent(reader));
                }
            }
        }

        public ushort Count { get; }
        public List<SkillDamageEvent> Events { get; } = new List<SkillDamageEvent>();
    }
}