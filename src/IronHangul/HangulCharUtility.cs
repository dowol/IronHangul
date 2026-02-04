using System;
using System.Collections.Generic;
using System.Text;

namespace IronHangul
{
    /// <summary>
    /// 현대 한글 관련 유틸리티 메소드를 제공합니다.
    /// </summary>
    public static partial class HangulCharUtility
    {
        /// <summary>
        /// 해당 문자가 한글인지 확인합니다.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangul(this char c)
        {
            return IsHangulSyllable(c) || IsHangulCompatibilityJamo(c) || IsHangulConjoiningJamo(c);
        }

        /// <summary>
        /// 해당 문자가 한글 자음인지 확인합니다. (유니코드 한글 호환성 자모(Hangul Compatibility Jamo) 영역에서만 적용)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulConsonant(this char c)
        {
            return c >= 0x3131 && c <= 0x314e;
        }

        /// <summary>
        /// 해당 문자가 한글 모음인지 확인합니다. (유니코드 한글 호환성 자모(Hangul Compatibility Jamo) 영역에서만 적용)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulVowel(this char c)
        {
            return c >= 0x314f && c <= 0x3163;
        }

        /// <summary>
        /// 해당 문자가 한글 조합형 초성인지 확인합니다. (유니코드 한글 자모(Hangul Jamo) 영역에서만 적용)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulChoseong(this char c)
        {
            return c >= 0x1100 && c <= 0x1112;
        }

        /// <summary>
        /// 해당 문자가 한글 조합형 중성인지 확인합니다. (유니코드 한글 자모(Hangul Jamo) 영역에서만 적용)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulJungseong(this char c)
        {
            return c >= 0x1161 && c <= 0x1175;
        }

        /// <summary>
        /// 해당 문자가 한글 조합형 종성(받침)인지 확인합니다. (유니코드 한글 자모(Hangul Jamo) 영역에서만 적용)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulJongseong(this char c)
        {
            return c >= 0x11a8 && c <= 0x11c2;
        }

        /// <summary>
        /// 해당 문자가 한글 자모(낱자)인지 확인합니다.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulJamo(this char c)
        {
            return IsHangulConjoiningJamo(c) || IsHangulCompatibilityJamo(c);
        }

        /// <summary>
        /// 해당 문자가 한글 조합형 자모(낱자)인지 확인합니다. (유니코드 한글 자모(Hangul Jamo) 영역인지 확인)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulConjoiningJamo(this char c)
        {
            return IsHangulChoseong(c) || IsHangulJungseong(c) || IsHangulJongseong(c);
        }

        /// <summary>
        /// 해당 문자가 한글 일반 자모(낱자)인지 확인합니다. (유니코드 한글 호환 자모(Hangul Compatibility Jamo) 영역인지 확인)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulCompatibilityJamo(this char c)
        {
            return IsHangulConsonant(c) || IsHangulVowel(c);
        }

        /// <summary>
        /// 해당 문자가 한글 음절 조합인지 확인합니다. (유니코드 한글 음절(Hangul Syllable) 영역인지 확인)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHangulSyllable(this char c)
        {
            return c >= 0xac00 && c <= 0xd7af;
        }

        /// <summary>
        /// 한글 조합형 자모를 한글 호환 자모(낱자)로 변환합니다
        /// </summary>
        /// <param name="c">한글 조합형 자모</param>
        /// <returns>한글 호환 자모(낱자)</returns>
        /// <exception cref="ArgumentException"><paramref name="c"/>가 한글 조합형 자모가 아닌 경우</exception>
        public static char ToCompatibilityJamo(this char c)
        {
            if (c.IsHangulCompatibilityJamo()) return c;
            else if (c.IsHangulChoseong()) return choseongTable[c - CHOSEONG_BEGIN];
            else if (c.IsHangulJungseong()) return (char)(c + 0x1fee); // = 낱자 ㅏ(U+314f) - 조합형 ㅏ(U+1161)
            else if (c.IsHangulJongseong()) return jongseongTable[c - JONGSEONG_BEGIN];
            else
            {
                ArgumentException e = new ArgumentException($"'{c}'(U+{c:X4})는 한글 조합형 자모가 아닙니다." , nameof(c));
                e.Data.Add("Value" , c);
                throw e;
            }
        }
    }
}
