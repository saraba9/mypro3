using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            cell[,] arr = new cell[8, 8];
            create(arr);
            int a = 0;
            while (a == 0)
            {
                Console.WriteLine("Enter line:");
                int line = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter column:");
                int column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("if you want mark  press 1 if you want open press 2: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (line < 0 || line > 7 || column < 0 || column > 7 || (num != 1 && num != 2))
                    Console.WriteLine("Invalid input");
                if (num == 1)

                    mark(line, column, arr);
                else
                if (num == 2)
                { 
                    a= open(line, column, arr);
                    print(arr);
                    
                }
            }
        }

        private static void create(cell[,] arr)
        {

            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = new cell(0, false);
                }
                
            }
            int mis=0,l,c;
            while (mis !=10)
            {
               l  = rnd.Next(8);
                c = rnd.Next(8);
                if (arr[l,c].GetValue() != -1)
                {
                    arr[l, c].SetValue(-1);
                    if (l - 1 > -1 && l - 1 < 8 && c - 1 > -1 && c - 1 < 8 && arr[l - 1, c - 1].GetValue() != -1)
                        arr[l - 1, c - 1].SetValue( 1,'+');
                    if (l - 1 > -1 && l - 1 < 8 && c > -1 && c < 8 && arr[l - 1, c ].GetValue() != -1)
                        arr[l - 1, c].SetValue(1, '+');
                    if (l - 1 > -1 && l - 1 < 8 && c + 1 > -1 && c + 1 < 8 && arr[l - 1, c + 1].GetValue() != -1)
                        arr[l - 1, c + 1].SetValue(1, '+');
                    if (l > -1 && l < 8 && c - 1 > -1 && c - 1 < 8 && arr[l , c - 1].GetValue() != -1)
                        arr[l, c - 1].SetValue(1, '+');
                    if (l > -1 && l < 8 && c + 1 > -1 && c + 1 < 8 && arr[l , c + 1].GetValue() != -1)
                        arr[l, c + 1].SetValue(1, '+');
                    if (l + 1 > -1 && l + 1 < 8 && c - 1 > -1 && c - 1 < 8 && arr[l + 1, c - 1].GetValue() != -1)
                        arr[l + 1, c - 1].SetValue(1, '+');
                    if (l + 1 > -1 && l + 1 < 8 && c > -1 && c < 8 && arr[l + 1, c ].GetValue() != -1)
                        arr[l + 1, c].SetValue(1, '+');
                    if (l + 1 > -1 && l + 1 < 8 && c + 1 > -1 && c + 1 < 8 && arr[l + 1, c + 1].GetValue() != -1)
                        arr[l + 1, c + 1].SetValue(1, '+');
                
                    mis++;
                }

            }


            //arr[0, 0] = new cell(0, false);
            //arr[0, 1] = new cell(1, false);
            //arr[0, 2] = new cell(1, false);
            //arr[0, 3] = new cell(2, false);
            //arr[0, 4] = new cell(1, false);
            //arr[0, 5] = new cell(2, false);
            //arr[0, 6] = new cell(2, false);
            //arr[0, 7] = new cell(-1, false);

            //arr[1, 0] = new cell(0, false);
            //arr[1, 1] = new cell(2, false);
            //arr[1, 2] = new cell(-1, false);
            //arr[1, 3] = new cell(4, false);
            //arr[1, 4] = new cell(-1, false);
            //arr[1, 5] = new cell(2, false);
            //arr[1, 6] = new cell(-1, false);
            //arr[1, 7] = new cell(2, false);

            //arr[2, 0] = new cell(0, false);
            //arr[2, 1] = new cell(2, false);
            //arr[2, 2] = new cell(-1, false);
            //arr[2, 3] = new cell(-1, false);
            //arr[2, 4] = new cell(2, false);
            //arr[2, 5] = new cell(3, false);
            //arr[2, 6] = new cell(2, false);
            //arr[2, 7] = new cell(2, false);

            //arr[3, 0] = new cell(0, false);
            //arr[3, 1] = new cell(1, false);
            //arr[3, 2] = new cell(2, false);
            //arr[3, 3] = new cell(2, false);
            //arr[3, 4] = new cell(1, false);
            //arr[3, 5] = new cell(1, false);
            //arr[3, 6] = new cell(-1, false);
            //arr[3, 7] = new cell(1, false);

            //arr[4, 0] = new cell(0, false);
            //arr[4, 1] = new cell(0, false);
            //arr[4, 2] = new cell(0, false);
            //arr[4, 3] = new cell(0, false);
            //arr[4, 4] = new cell(0, false);
            //arr[4, 5] = new cell(1, false);
            //arr[4, 6] = new cell(2, false);
            //arr[4, 7] = new cell(2, false);

            //arr[5, 0] = new cell(2, false);
            //arr[5, 1] = new cell(2, false);
            //arr[5, 2] = new cell(1, false);
            //arr[5, 3] = new cell(0, false);
            //arr[5, 4] = new cell(0, false);
            //arr[5, 5] = new cell(0, false);
            //arr[5, 6] = new cell(1, false);
            //arr[5, 7] = new cell(-1, false);

            //arr[6, 0] = new cell(-1, false);
            //arr[6, 1] = new cell(-1, false);
            //arr[6, 2] = new cell(1, false);
            //arr[6, 3] = new cell(0, false);
            //arr[6, 4] = new cell(0, false);
            //arr[6, 5] = new cell(0, false);
            //arr[6, 6] = new cell(1, false);
            //arr[6, 7] = new cell(1, false);

            //arr[7, 0] = new cell(2, false);
            //arr[7, 1] = new cell(2, false);
            //arr[7, 2] = new cell(1, false);
            //arr[7, 3] = new cell(0, false);
            //arr[7, 4] = new cell(0, false);
            //arr[7, 5] = new cell(0, false);
            //arr[7, 6] = new cell(0, false);
            //arr[7, 7] = new cell(0, false);
        }

        private static void mark(int line, int column, cell[,] arr)
        {
            if (line < 0 || line > 7 || column < 0 || column > 7)
                return;
            arr[line, column].SetMarked(true);
            Console.WriteLine("line: " + line + " column: " + column + "  marked");

        }

        private static int open(int line, int column, cell[,] arr)
        {
            if (line < 0 || line > 7 || column < 0 || column > 7)
                return 0;
            if (arr[line, column].GetMarked() == true)
            { 
                Console.WriteLine("line: " + line + " column: " + column + "  marked");
                return 0;
            }
            if (arr[line, column].GetOpened() == true)
            {
                return 0;
            }
            if (arr[line, column].GetValue() == -1)
            {
                Console.WriteLine("game over");
                return 1;
            }
            if (arr[line, column].GetValue() != 0)
            { 
                Console.WriteLine("line: " + line + " column: " + column + " = " + arr[line, column].GetValue());
                arr[line, column].SetOpened(true);
                return 0;
            }
            if (arr[line, column].GetValue() == 0)
            {
                Console.WriteLine("line: " + line + " column: " + column + "= " + arr[line, column].GetValue());
                arr[line, column].SetOpened(true);

                if (line - 1 > -1 && line - 1 < 8 && column - 1 > -1 && column - 1 < 8 && arr[line - 1, column - 1].GetOpened() == false)
                    open(line - 1, column - 1, arr);
                if (line - 1 > -1 && line - 1 < 8 && column  > -1 && column  < 8 && arr[line - 1, column ].GetOpened() == false)
                    open(line - 1, column , arr);
                if (line - 1 > -1 && line - 1 < 8 && column + 1 > -1 && column + 1 < 8 && arr[line - 1, column + 1].GetOpened() == false)
                    open(line - 1, column +1, arr);
                if (line  > -1 && line  < 8 && column - 1 > -1 && column - 1 < 8 && arr[line , column - 1].GetOpened() == false)
                    open(line , column - 1, arr);
                if (line  > -1 && line  < 8 && column + 1 > -1 && column + 1 < 8 && arr[line , column + 1].GetOpened() == false)
                    open(line , column + 1, arr);
                if (line + 1 > -1 && line + 1 < 8 && column - 1 > -1 && column - 1 < 8 && arr[line + 1, column - 1].GetOpened() == false)
                    open(line + 1, column - 1, arr);
                if (line + 1 > -1 && line + 1 < 8 && column  > -1 && column  < 8 && arr[line + 1, column ].GetOpened() == false)
                    open(line + 1, column , arr);
                if (line + 1 > -1 && line+ 1 < 8 && column + 1 > -1 && column + 1 < 8 && arr[line + 1, column + 1].GetOpened() == false)
                    open(line + 1, column + 1, arr);

            }
            return 0;
        }


        private static void print( cell[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j].GetOpened() == false)
                        Console.Write("?" + "\t");
                    else
                        Console.Write(arr[i, j].GetValue() + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}

