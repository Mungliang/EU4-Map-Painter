using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EU4MapPainter
{
    class SharedContent
    {
        //path selection
        public static string originalPath, modPath;
        public static Image baseMap;
        public static string[,] definitionData;
        //public static string[,] provincesData; [WIP]
        public static string[] provinceFilesList, seaAndLakeStarts, wastelandIDs;
        public static Boolean canUsePoliticalMap = true, canCopyData = true;
        //settings
        public static Boolean originalCulture = false, originalReligion = false, originalHRE = false,
                              originalTradeGood = false, originalCapital = false, originalExtraCost = false,
                              originalCoT = false, usingOriginalFiles = false;
        public static int btChoice = 0, bpChoice = 0, bmChoice = 0,
                          btFromValue = 0, btToValue = 0, bpFromValue = 0,
                          bpToValue = 0, bmFromValue = 0, bmToValue = 0;
    }
}
