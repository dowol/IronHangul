using System;
using System.Collections.Generic;
using System.Text;

namespace IronHangul
{
    public static partial class HangulCharUtility
    {
        private static readonly ushort CHOSEONG_BEGIN = 0x1100;
        private static readonly ushort JUNGSEONG_BEGIN = 0x1161;
        private static readonly ushort JONGSEONG_BEGIN = 0x11A8;

        private static readonly char[] choseongTable =
        {
            '\u3131', // ㄱ
            '\u3132', // ㄲ
            '\u3134', // ㄴ
            '\u3137', // ㄷ
            '\u3138', // ㄸ
            '\u3139', // ㄹ
            '\u3141', // ㅁ
            '\u3142', // ㅂ
            '\u3143', // ㅃ
            '\u3145', // ㅅ
            '\u3146', // ㅆ
            '\u3147', // ㅇ
            '\u3148', // ㅈ
            '\u3149', // ㅉ
            '\u314A', // ㅊ
            '\u314B', // ㅋ
            '\u314C', // ㅌ
            '\u314D', // ㅍ
            '\u314E'  // ㅎ
        };

        private static readonly char[] jongseongTable =
        {
            '\u3131', // ㄱ
            '\u3132', // ㄲ
            '\u3133', // ㄳ
            '\u3134', // ㄴ
            '\u3135', // ㄵ
            '\u3136', // ㄶ
            '\u3137', // ㄷ
            '\u3139', // ㄹ
            '\u313A', // ㄺ
            '\u313B', // ㄻ
            '\u313C', // ㄼ
            '\u313D', // ㄽ
            '\u313E', // ㄾ
            '\u313F', // ㄿ
            '\u3140', // ㅀ
            '\u3141', // ㅁ
            '\u3142', // ㅂ
            '\u3144', // ㅄ
            '\u3145', // ㅅ
            '\u3146', // ㅆ
            '\u3147', // ㅇ
            '\u3148', // ㅈ
            '\u314A', // ㅊ
            '\u314B', // ㅋ
            '\u314C', // ㅌ
            '\u314D', // ㅍ
            '\u314E'  // ㅎ
        };
    }
}
