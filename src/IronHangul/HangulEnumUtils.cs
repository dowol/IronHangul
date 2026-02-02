using System;

namespace IronHangul
{
    /// <summary>
    /// 한글 문자의 유형을 나타냅니다.
    /// </summary>
    [Flags]
    public enum HangulType 
    {
        /// <summary>
        /// 한글이 아닌 문자
        /// </summary>
        None = 0,

        /// <summary>
        /// 한글 낱자 자음 (Unicode Hangul Compatibility Jamo)
        /// </summary>
        Consonant = 1,

        /// <summary>
        /// 한글 낱자 모음 (Unicode Hangul Compatibility Jamo)
        /// </summary>
        Vowel = 2,

        /// <summary>
        /// 한글 조합형 자모의 초성(Unicode Hangul Jamo)
        /// </summary>
        Choseong = 4,

        /// <summary>
        /// 한글 조합형 자모의 중성(Unicode Hangul Jamo)
        /// </summary>
        Jungseong = 8,

        /// <summary>
        /// 한글 조합형 자모의 종성(받침)(Unicode Hangul Jamo)
        /// </summary>
        Jongseong = 16,

        /// <summary>
        /// 한글 조합형 자모
        /// </summary>
        ConjoiningJamo = 32,

        /// <summary>
        /// 한글 낱자
        /// </summary>
        CompatibilityJamo = 64,

        /// <summary>
        /// 한글 자모
        /// </summary>
        Jamo = ConjoiningJamo | CompatibilityJamo,

        /// <summary>
        /// 한글 음절
        /// </summary>
        Syllable = 128,
    }

    /// <summary>
    /// 한글의 낱자를 추출할 때 사용할 유니코드 영역을 나타냅니다.
    /// </summary>
    public enum HangulExtractionMode
    {
        /// <summary>
        /// 한글 조합형 자모 (Unicode Hangul Jamo)
        /// </summary>
        ConjoiningJamo = 32,

        /// <summary>
        /// 한글 낱자 (Unicode Hangul Compatibility Jamo)
        /// </summary>
        CompatibilityJamo = 64
    }
}
