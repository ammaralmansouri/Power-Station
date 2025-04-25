using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PowerStationDisktop.BusinessLayer.Settings
{
    class ClsAppFontSize
    {
        public static double DefaultCellStyle = 8.5;
        public static double AlternatingRowsDefaultCellStyle = 8.5;
        public static double ColumnHeaderDefaulyCellStyle = 8.5;

        public static Font GetDefaultCellStyleFont(Font currentFont)
        {
            return new Font(currentFont.FontFamily, (float)DefaultCellStyle);
        }

        public static Font GetAlternatingRowsDefaultCellStyleFont(Font currentFont)
        {
            return new Font(currentFont.FontFamily, (float)AlternatingRowsDefaultCellStyle);
        }

        public static Font GetColumnHeaderDefaultCellStyleFont(Font currentFont)
        {
            return new Font(currentFont.FontFamily, (float)ColumnHeaderDefaulyCellStyle);
        }

    }
}