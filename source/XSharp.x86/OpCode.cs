﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XSharp.x86
{
    // http://ref.x86asm.net/coder32-abc.html
    // http://ref.x86asm.net/coder32.html
    // http://www.sandpile.org/
    // https://en.wikipedia.org/wiki/X86_instruction_listings
    //
    // Mulitbyte NOPs
    // https://software.intel.com/en-us/forums/watercooler-catchall/topic/307174
    // https://reverseengineering.stackexchange.com/questions/11971/nop-with-argument-in-x86-64
    // http://www.felixcloutier.com/x86/NOP.html
    // https://stackoverflow.com/questions/4798356/amd64-nopw-assembly-instruction
    // http://john.freml.in/amd64-nopl - Jump targets aligned on 16 byte boundaries
    // https://sites.google.com/site/paulclaytonplace/andy-glew-s-comparch-wiki/hint-instructions - Generic, Intel doesnt appear to have hints


    // Please add ops in alphabetical order
    public enum OpCode
    {
        Mov,
        NOP,
        PopAD,
        PushAD,
        Ret
    }
}
