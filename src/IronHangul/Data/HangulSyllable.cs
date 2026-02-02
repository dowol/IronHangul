using System;
using System.Collections.Generic;
using System.Text;

namespace IronHangul.Data
{
    /// <summary>
    /// 유니코드 한글 호환 자모(Hangul Compatibility Jamo) 영역으로 한글 음절 조합을 표현합니다.
    /// </summary>
    public partial class HangulSyllable
    {
        private char choseong;
        private char jungseong;
        private char jongseong;

        public char Choseong { get => choseong; set => choseong = value; }
        public char Jungseong { get => jungseong; set => jungseong = value; }
        public char Jongseong { get => jongseong; set => jongseong = value; }

        public char Syllable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ChoseongCombination
        {
            get
            {
                throw new NotImplementedException(); 
            }
        }

        public string JungseongCombination
        {
            get
            {
                throw new NotImplementedException(); 
            }
        }

        public string JongseongCombination
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public HangulSyllable(char c)
        {
            
        }

        public HangulSyllable(char choseong, char jungseong, char jongseong = '\0')
        {
            Choseong = choseong;
            Jungseong = jungseong;
            Jongseong = jongseong;
        }

        public HangulSyllable(string s)
        {

        }


        public bool HasJongseong()
        {
            return jungseong != '\0';
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
