using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU4MapPainter
{
    class SharedContent
    {
        //path selection
        public static string originalPath, modPath, mapURL;
        public static string[,] definitionData = new string[0,5];
        public static string[,] provincesData = new string[0, 4];
        public static string[] provinceFilesList = new string[0];
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
