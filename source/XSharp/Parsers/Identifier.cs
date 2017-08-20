﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XSharp.Parsers {
  public class Identifier : Parser {
    protected static readonly string FirstChars;
    protected static readonly string Chars;

    static Identifier() {
      FirstChars = Parser.CharSets.Alpha + "_";
      Chars = FirstChars + Parser.CharSets.Number;
    }

    public override object Parse(string aText, ref int rStart) {
      if (FirstChars.IndexOf(aText[rStart]) == -1) {
        return null;
      }

      int i;
      for (i = rStart + 1; i < aText.Length; i++) {
        if (Chars.IndexOf(aText[i]) == -1) {
          break;
        }
      }

      string xText = aText.Substring(rStart, i - rStart);
      rStart = i;
      return xText;
    }
  }
}
