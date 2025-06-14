﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDIModificationFramework.MIDI_Events
{
    public class CustomEvent : MIDIEvent
    {
        byte[] data;
        public CustomEvent(uint delta, byte[] data) : base(delta)
        {
            this.data = data;
        }

        public override MIDIEvent Clone()
        {
            return new CustomEvent(DeltaTime, (byte[])data.Clone());
        }

        public override byte[] GetData()
        {
            return data;
        }
    }
}
