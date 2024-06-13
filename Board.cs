using System;
using Tic_Tac_Toe_Practice;

public class Board
{
    //---------Field,Construcotr, Default -------//
    public string[,] VisualBoard { get; set; } //Fields
    public int[,] InternalBoard { get; set; } //Fields

    public Board() //Constructor
    {
        VisualBoard = new string[3, 3];
        InternalBoard = new int[3, 3];
    }
    public void Reset() //Default
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                VisualBoard[i, j] = " ";
                InternalBoard[i, j] = 0;
            }
        }
    }
    //--------------------------------------------//
    public void PrintBoard()
    {
        Console.WriteLine("------TIC TAC TOE BOARD ---------");
        Console.WriteLine();
        Console.WriteLine("          |       |       ");
        Console.WriteLine($"      {VisualBoard[0, 0]}   |   {VisualBoard[0, 1]}   |   {VisualBoard[0, 2]}    ");
        Console.WriteLine("          |       |       ");
        Console.WriteLine("   -------------------------");
        Console.WriteLine("          |       |       ");
        Console.WriteLine($"      {VisualBoard[1, 0]}   |   {VisualBoard[1, 1]}   |   {VisualBoard[1, 2]}    ");
        Console.WriteLine("          |       |       ");
        Console.WriteLine("   -------------------------");
        Console.WriteLine("          |       |       ");
        Console.WriteLine($"      {VisualBoard[2, 0]}   |   {VisualBoard[2, 1]}   |   {VisualBoard[2, 2]}    ");
        Console.WriteLine("          |       |       ");
    }
    public void UpdateVisualBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (InternalBoard[i, j] == 1)
                {
                    VisualBoard[i, j] = "X";
                }
                else if (InternalBoard[i, j] == -1)
                {
                    VisualBoard[i, j] = "O";
                }
            }
        }
    }
    public void PrintChoices()
    {
        int emptyCount = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (InternalBoard[i, j] == 0)
                {
                    Console.WriteLine($"{emptyCount}. {GetRowName(i)} {GetColName(j)}");
                    emptyCount++;
                }
            }
        }
    }

    public string GetRowName(int row)
    {
        return row switch
        {
            0 => "Top",
            1 => "Middle",
            2 => "Bottom",
            _ => ""
        };
    }

    public string GetColName(int col)
    {
        return col switch
        {
            0 => "Left",
            1 => "Center",
            2 => "Right",
            _ => ""
        };
    }

}
