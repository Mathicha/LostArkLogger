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
    public class Struct_544
    {
        public bool valid = false;
        internal Struct_544()
        {
            //Made for conditional structures
        }

        internal Struct_544(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 128)
            {
                Unk0_0 = reader.ReadBytes(2*Unk0);
            }
        }

        public short Unk0 { get; }
        public byte[] Unk0_0 { get; }
    }
}