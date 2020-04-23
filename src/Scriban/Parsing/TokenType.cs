// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
namespace Scriban.Parsing
{
    /// <summary>
    /// An enumeration to categorize tokens.
    /// </summary>
    public enum TokenType
    {
        Invalid,

        FrontMatterMarker,

        [TokenText("{{")]
        CodeEnter,

        [TokenText("{%")]
        LiquidTagEnter,

        [TokenText("}}")]
        CodeExit,

        [TokenText("%}")]
        LiquidTagExit,

        Raw,
        Escape,

        EscapeEnter,
        EscapeExit,

        NewLine,

        Whitespace,

        WhitespaceFull,

        Comment,

        CommentMulti,

        /// <summary>
        /// An identifier starting by a $
        /// </summary>
        IdentifierSpecial,

        /// <summary>
        /// An identifier
        /// </summary>
        Identifier,

        /// <summary>
        /// An integer (int, long...)
        /// </summary>
        Integer,

        /// <summary>
        /// A Hexadecimal integer (int, long...)
        /// </summary>
        HexaInteger,

        /// <summary>
        /// A binary integer (int, long...)
        /// </summary>
        BinaryInteger,

        /// <summary>
        /// A floating point number
        /// </summary>
        Float,

        /// <summary>
        /// A string
        /// </summary>
        String,

        /// <summary>
        /// An implicit string with quotes
        /// </summary>
        ImplicitString,

        /// <summary>
        /// A verbatim string
        /// </summary>
        VerbatimString,

        [TokenText(";")]
        SemiColon,

        [TokenText("@")]
        Arroba,

        [TokenText("^")]
        Caret,

        [TokenText("^^")]
        DoubleCaret,

        [TokenText(":")]
        Colon,

        [TokenText("=")]
        Equal,

        [TokenText("|")]
        Pipe,  // |

        [TokenText("|>")]
        PipeGreater,  // |>

        [TokenText("!")]
        Exclamation, // !

        [TokenText("&&")]
        DoubleAmp, // &&

        [TokenText("||")]
        DoublePipe,  // ||

        [TokenText("&")]
        Amp, // &

        [TokenText("?")]
        Question,

        [TokenText("??")]
        DoubleQuestion,

        [TokenText("==")]
        CompareEqual,

        [TokenText("!=")]
        CompareNotEqual,

        [TokenText("<")]
        CompareLess,

        [TokenText(">")]
        CompareGreater,

        [TokenText("<=")]
        CompareLessOrEqual,

        [TokenText(">=")]
        CompareGreaterOrEqual,

        [TokenText("/")]
        Divide,

        [TokenText("//")]
        DoubleDivide,

        [TokenText("*")]
        Multiply,

        [TokenText("+")]
        Plus,

        [TokenText("-")]
        Minus,

        [TokenText("%")]
        Modulus,

        [TokenText("<<")]
        DoubleLess,

        [TokenText(">>")]
        DoubleGreater,

        [TokenText(",")]
        Comma,

        [TokenText(".")]
        Dot,

        [TokenText("..")]
        DoubleDot,

        [TokenText("..<")]
        DoubleDotLess,

        [TokenText("(")]
        OpenParent,
        [TokenText(")")]
        CloseParent,

        [TokenText("{")]
        OpenBrace,
        [TokenText("}")]
        CloseBrace,

        [TokenText("[")]
        OpenBracket,
        [TokenText("]")]
        CloseBracket,

        /// <summary>
        /// Custom token
        /// </summary>
        Custom,
        Custom1,
        Custom2,
        Custom3,
        Custom4,
        Custom5,
        Custom6,
        Custom7,
        Custom8,
        Custom9,

        Eof,
    }
}