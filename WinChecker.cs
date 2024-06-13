using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Practice
{
    internal class WinChecker
    {
        public static int WinChecks(int[,] iB)
        {
            int winner = CheckRowsAndCols(iB);
            if (winner != 0)
            {
                return winner;
            }
            winner = CheckDiagonals(iB);
            return winner;
        }//end of WinChecks
        public static int CheckRowsAndCols(int[,] iB)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowCheck = 0, colCheck = 0;

                for (int j = 0; j < 3; j++)
                {
                    rowCheck += iB[i, j];
                    colCheck += iB[j, i];
                }

                if (rowCheck == 3 || rowCheck == -3)
                {
                    return rowCheck;
                }

                if (colCheck == 3 || colCheck == -3)
                {
                    return colCheck;
                }
            }
            return 0;
        }//end of CheckRowsAndCols

        public static int CheckDiagonals(int[,] iB)
        {
            int topDiagCheck = 0, botDiagCheck = 0;

            for (int i = 0; i < 3; i++)
            {
                topDiagCheck += iB[i, i];
                botDiagCheck += iB[i, 2 - i];
            }

            if (topDiagCheck == 3 || topDiagCheck == -3)
            {
                return topDiagCheck;
            }

            if (botDiagCheck == 3 || botDiagCheck == -3)
            {
                return botDiagCheck;
            }

            return 0;
        }//end of CheckDiagonals
    }
}
