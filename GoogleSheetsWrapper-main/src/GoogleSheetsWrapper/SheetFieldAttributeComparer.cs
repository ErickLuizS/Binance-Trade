using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GoogleSheetsWrapper
{
    public class SheetFieldAttributeComparer : IComparer<SheetFieldAttribute>
    {
        public int Compare([AllowNull] SheetFieldAttribute x, [AllowNull] SheetFieldAttribute y)
        {
            if ((x != null) && (y != null))
            {
                return x.ColumnID.CompareTo(y.ColumnID);
            }

            return 0;
        }
    }
}
