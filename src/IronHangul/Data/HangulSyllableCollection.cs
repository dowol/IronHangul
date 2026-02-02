using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IronHangul.Data
{
    internal class HangulSyllableCollection : ICollection<HangulSyllable>, IReadOnlyCollection<HangulSyllable>
    {
        private readonly List<HangulSyllable> list = new List<HangulSyllable>();
        public HangulSyllableCollection()
        {
         
            
        }

        public int Count => list.Count;

        bool ICollection<HangulSyllable>.IsReadOnly => ((ICollection<HangulSyllable>)list).IsReadOnly;

        public void Add(HangulSyllable item)
        {
            ((ICollection<HangulSyllable>)list).Add(item);
        }

        public void Clear()
        {
            ((ICollection<HangulSyllable>)list).Clear();
        }

        public bool Contains(HangulSyllable item)
        {
            return ((ICollection<HangulSyllable>)list).Contains(item);
        }

        public void CopyTo(HangulSyllable[] array , int arrayIndex)
        {
            ((ICollection<HangulSyllable>)list).CopyTo(array , arrayIndex);
        }

        public IEnumerator<HangulSyllable> GetEnumerator()
        {
            return ((IEnumerable<HangulSyllable>)list).GetEnumerator();
        }

        public bool Remove(HangulSyllable item)
        {
            return ((ICollection<HangulSyllable>)list).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
