﻿using System.Collections.Generic;

namespace TJAPlayer3.C曲リストノードComparers
{
    internal sealed class C曲リストノードComparerAC8_14 : IComparer<C曲リストノード>
    {
        public int Compare(C曲リストノード n1, C曲リストノード n2)
        {
<<<<<<< HEAD
            return CStrジャンルtoNum.ForAC8_14(n1.strジャンル).CompareTo(CStrジャンルtoNum.ForAC8_14(n2.strジャンル));
=======
            return CStrジャンルtoNum.ForAC8_14SortOrder(n1.strジャンル).CompareTo(CStrジャンルtoNum.ForAC8_14SortOrder(n2.strジャンル));
>>>>>>> twopointzero/develop
        }
    }
}