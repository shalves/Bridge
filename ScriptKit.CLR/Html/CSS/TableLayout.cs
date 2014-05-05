﻿namespace ScriptKit.CLR.Html
{
    /// <summary>
    /// The table-layout CSS property defines the algorithm to be used to layout the table cells, rows, and columns.
    /// </summary>
    [ScriptKit.CLR.Ignore]
    [ScriptKit.CLR.EnumEmit(EnumEmit.StringNameLowerCase)]
    [ScriptKit.CLR.Name("String")]
    public enum TableLayout
    {
        /// <summary>
        /// 
        /// </summary>
        Inherit,

        /// <summary>
        /// An automatic table layout algorithm is commonly used by most browsers for table layout. The width of the table and its cells depends on the content thereof.
        /// </summary>
        Auto, 
        
        /// <summary>
        /// Table and column widths are set by the widths of table and col elements or by the width of the first row of cells. Cells in subsequent rows do not affect column widths.
        /// </summary>
        Fixed
    }
}