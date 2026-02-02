using System;

namespace IronHangul
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum HangulType 
    {
        None = 0,

        Consonant = 1,
        Vowel = 2,

        Choseong = 4,
        Jungseong = 8,
        Jongseong = 16,

        ConjoiningJamo = 32,
        CompatibilityJamo = 64,
        Jamo = ConjoiningJamo | CompatibilityJamo,

        Syllable = 128,
    }

    public enum HangulExtractionMode
    {
        ConjoiningJamo = 32,
        CompatibilityJamo = 64
    }
}
