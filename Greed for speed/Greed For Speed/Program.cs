using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Greed_For_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            StartGame();
            PlayIt();
            EndGame();
            Console.ReadKey();
        }
        static bool win = true;

        static int lvType()
        {
            Random rnd = new Random();

            int LvType = rnd.Next(0, 10);

            return LvType;
        }

        static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("press enter to start game");
            Console.ReadLine();
            Console.Clear();

        }


        static void PlayIt()
        {
            int cnt = 0;
            int coinum = 12;


            MTP mtp1 = new MTP(1, 1, '♦', ConsoleColor.DarkMagenta, ConsoleColor.Gray, 1);
            MTP mtp2 = new MTP(78, 1, '♦', ConsoleColor.Yellow, ConsoleColor.Red, 1);
            MTP mtp3 = new MTP(78, 23, '♦', ConsoleColor.Green, ConsoleColor.Magenta, 1);
            MTP mtp4 = new MTP(1, 23, '♦', ConsoleColor.Yellow, ConsoleColor.Cyan, 1);
            MTP player = new MTP(39, 12, 'U', ConsoleColor.DarkBlue, ConsoleColor.Cyan, 1);

            #region lv type

            int type = lvType();

            int time = int.MaxValue;

            int maxPts = coinum / 2;

            

            if (type == 8 || type == 9)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("you got............");
                Thread.Sleep(1000);
                Console.WriteLine("greed for speed!!!");
                Thread.Sleep(1000);
                Console.WriteLine("in this level, you won't have much time");
                Thread.Sleep(1000);
                Console.WriteLine("but don't worry, you will need to collect half the coins you will need in a normal level");
                Console.WriteLine("Press enter to start");
                time = 50;
                maxPts = coinum / 4;    
                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            else
            {
                time = int.MaxValue;
            }

            if (type == 6 || type == 7)
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("you got............");
                Thread.Sleep(1000);
                Console.WriteLine("Greed on ice!!!!");
                Thread.Sleep(1000);
                Console.WriteLine("in this level your enemies will move twice as fast as a normal level");
                Thread.Sleep(1000);
                Console.WriteLine("but don't worry, you will need to collect half the coins you will need in a normal level");
                mtp1.SetSpeed(3);
                mtp2.SetSpeed(3);
                player.SetSpeed(1);
                mtp3.SetSpeed(3);
                mtp4.SetSpeed(3);
                maxPts = coinum / 4;
                Console.WriteLine("Press enter to start");
                Console.ReadLine() ;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            #endregion

            #region border
            for (int i = 0; i < 81; i++)
            {
                Console.ForegroundColor = (ConsoleColor)(i % 16);
                if (i % 16 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.SetCursorPosition(i, 25);
                Console.WriteLine("¯");
            }
            for (int i = 0; i < 25; i++)
            {

                Console.ForegroundColor = (ConsoleColor)(i % 16);
                if (i % 16 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.SetCursorPosition(81, i);
                Console.WriteLine("¦");
            }
            #endregion


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("points:" + 0);
            TRect rect = new TRect(0, 26, 10, 3, ConsoleColor.White);
            rect.Draw();


            


            #region MTP.coins
            Random rnd = new Random();

            MTP coin1 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin1.Draw();
            int x1 = coin1.GetX();
            int y1 = coin1.GetY();

            MTP coin2 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin2.Draw();
            int x2 = coin2.GetX();
            int y2 = coin2.GetY();

            MTP coin3 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin3.Draw();
            int x3 = coin3.GetX();
            int y3 = coin3.GetY();

            MTP coin4 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin4.Draw();
            int x4 = coin4.GetX();
            int y4 = coin4.GetY();

            MTP coin5 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin5.Draw();
            int x5 = coin5.GetX();
            int y5 = coin5.GetY();

            MTP coin6 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin6.Draw();
            int x6 = coin6.GetX();
            int y6 = coin6.GetY();

            MTP coin7 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin7.Draw();
            int x7 = coin7.GetX();
            int y7 = coin7.GetY();

            MTP coin8 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin8.Draw();
            int x8 = coin8.GetX();
            int y8 = coin8.GetY();

            MTP coin9 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin9.Draw();
            int x9 = coin9.GetX();
            int y9 = coin9.GetY();

            MTP coin10 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin10.Draw();
            int x10 = coin10.GetX();
            int y10 = coin10.GetY();

            MTP coin11 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin11.Draw();
            int x11 = coin11.GetX();
            int y11 = coin11.GetY();

            MTP coin12 = new MTP(rnd.Next(79), rnd.Next(24), '$', ConsoleColor.DarkYellow, ConsoleColor.Yellow, 0);
            coin12.Draw();
            int x12 = coin12.GetX();
            int y12 = coin12.GetY();
            #endregion

            mtp1.Draw();
            mtp2.Draw();
            player.Draw();
            mtp3.Draw();
            mtp4.Draw();


           

            for (int i = 0; i <= time ; i++)
            {
                if (i == time)
                {

                    win = false;
                    break;

                }

                mtp1.Undraw();
                mtp1.RndMove(30);
                mtp1.Draw();

                mtp2.Undraw();
                mtp2.RndMove(30);
                mtp2.Draw();

                mtp3.Undraw();
                mtp3.RndMove(35);
                mtp3.Draw();


                mtp4.Undraw();
                mtp4.RndMove(40);
                mtp4.Draw();

                if (Console.KeyAvailable)  // check if keyboard hitted
                {
                    player.Undraw();
                    ConsoleKeyInfo k = Console.ReadKey();
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }

                    if (k.Key == ConsoleKey.UpArrow)
                        player.MoveUp();
                    else if (k.Key == ConsoleKey.DownArrow)
                        player.MoveDown();
                    else if (k.Key == ConsoleKey.LeftArrow)
                        player.MoveLeft();
                    else if (k.Key == ConsoleKey.RightArrow)
                        player.MoveRight();
                    player.Draw();

                    #region Coin.Undraw

                    #region exist

                    bool exist1 = true;

                    if (coin1.GetFcolor() == ConsoleColor.Black && coin1.GetBcolor() == ConsoleColor.Black)
                    {
                        exist1 = false;
                    }

                    bool exist2 = true;

                    if (coin2.GetFcolor() == ConsoleColor.Black && coin2.GetBcolor() == ConsoleColor.Black)
                    {
                        exist2 = false;
                    }

                    bool exist3 = true;

                    if (coin3.GetFcolor() == ConsoleColor.Black && coin3.GetBcolor() == ConsoleColor.Black)
                    {
                        exist3 = false;
                    }

                    bool exist4 = true;

                    if (coin4.GetFcolor() == ConsoleColor.Black && coin4.GetBcolor() == ConsoleColor.Black)
                    {
                        exist4 = false;
                    }

                    bool exist5 = true;

                    if (coin5.GetFcolor() == ConsoleColor.Black && coin5.GetBcolor() == ConsoleColor.Black)
                    {
                        exist5 = false;
                    }

                    bool exist6 = true;

                    if (coin6.GetFcolor() == ConsoleColor.Black && coin6.GetBcolor() == ConsoleColor.Black)
                    {
                        exist6 = false;
                    }

                    bool exist7 = true;

                    if (coin7.GetFcolor() == ConsoleColor.Black && coin7.GetBcolor() == ConsoleColor.Black)
                    {
                        exist7 = false;
                    }

                    bool exist8 = true;

                    if (coin8.GetFcolor() == ConsoleColor.Black && coin8.GetBcolor() == ConsoleColor.Black)
                    {
                        exist8 = false;
                    }

                    bool exist9 = true;

                    if (coin9.GetFcolor() == ConsoleColor.Black && coin9.GetBcolor() == ConsoleColor.Black)
                    {
                        exist9 = false;
                    }

                    bool exist10 = true;

                    if (coin10.GetFcolor() == ConsoleColor.Black && coin10.GetBcolor() == ConsoleColor.Black)
                    {
                        exist10 = false;
                    }

                    bool exist11 = true;

                    if (coin11.GetFcolor() == ConsoleColor.Black && coin11.GetBcolor() == ConsoleColor.Black)
                    {
                        exist11 = false;
                    }

                    bool exist12 = true;

                    if (coin12.GetFcolor() == ConsoleColor.Black && coin12.GetBcolor() == ConsoleColor.Black)
                    {
                        exist12 = false;
                    }

                    #endregion

                    #region if xy match

                    if (mtp1.GetX() == x1 && mtp1.GetY() == y1 || mtp2.GetX() == x1 && mtp2.GetY() == y1 || mtp3.GetX() == x1 && mtp3.GetY() == y1 || mtp4.GetX() == x1 && mtp4.GetY() == y1)
                    {
                        coin1.Undraw();
                    }

                    if (mtp1.GetX() == x2 && mtp1.GetY() == y2 || mtp2.GetX() == x2 && mtp2.GetY() == y2 || mtp3.GetX() == x2 && mtp3.GetY() == y2 || mtp4.GetX() == x2 && mtp4.GetY() == y2)
                    {
                        coin2.Undraw();
                    }

                    if (mtp1.GetX() == x3 && mtp1.GetY() == y3 || mtp2.GetX() == x3 && mtp2.GetY() == y3 || mtp3.GetX() == x3 && mtp3.GetY() == y3 || mtp4.GetX() == x3 && mtp4.GetY() == y3)
                    {
                        coin3.Undraw();
                    }

                    if (mtp1.GetX() == x4 && mtp1.GetY() == y4 || mtp2.GetX() == x4 && mtp2.GetY() == y4 || mtp3.GetX() == x4 && mtp3.GetY() == y4 || mtp4.GetX() == x4 && mtp4.GetY() == y4)
                    {
                        coin4.Undraw();
                    }

                    if (mtp1.GetX() == x5 && mtp1.GetY() == y5 || mtp2.GetX() == x5 && mtp2.GetY() == y5 || mtp3.GetX() == x5 && mtp3.GetY() == y5 || mtp4.GetX() == x5 && mtp4.GetY() == y5)
                    {
                        coin5.Undraw();
                    }

                    if (player.GetX() == x6 && mtp1.GetY() == y6 || mtp2.GetX() == x6 && mtp2.GetY() == y6 || mtp3.GetX() == x6 && mtp3.GetY() == y6 || mtp4.GetX() == x6 && mtp4.GetY() == y6)
                    {
                        coin6.Undraw();
                    }

                    if (mtp1.GetX() == x7 && mtp1.GetY() == y7 || mtp2.GetX() == x7 && mtp2.GetY() == y7 || mtp3.GetX() == x7 && mtp3.GetY() == y7 || mtp4.GetX() == x7 && mtp4.GetY() == y7)
                    {
                        coin7.Undraw();
                    }

                    if (mtp1.GetX() == x8 && mtp1.GetY() == y8 || mtp2.GetX() == x8 && mtp2.GetY() == y8 || mtp3.GetX() == x8 && mtp3.GetY() == y8 || mtp4.GetX() == x8 && mtp4.GetY() == y8)
                    {
                        coin8.Undraw();
                    }

                    if (mtp1.GetX() == x9 && mtp1.GetY() == y9 || mtp2.GetX() == x9 && mtp2.GetY() == y9 || mtp3.GetX() == x9 && mtp3.GetY() == y9 || mtp4.GetX() == x9 && mtp4.GetY() == y9)
                    {
                        coin9.Undraw();
                    }

                    if (mtp1.GetX() == x10 && mtp1.GetY() == y10 || mtp2.GetX() == x10 && mtp2.GetY() == y10 || mtp3.GetX() == x10 && mtp3.GetY() == y10 || mtp4.GetX() == x10 && mtp4.GetY() == y10)
                    {
                        coin10.Undraw();
                    }

                    if (mtp1.GetX() == x11 && mtp1.GetY() == y11 || mtp2.GetX() == x11 && mtp2.GetY() == y11 || mtp3.GetX() == x11 && mtp3.GetY() == y11 || mtp4.GetX() == x11 && mtp4.GetY() == y11)
                    {
                        coin11.Undraw();
                    }

                    if (mtp1.GetX() == x12 && mtp1.GetY() == y12 || mtp2.GetX() == x12 && mtp2.GetY() == y12 || mtp3.GetX() == x12 && mtp3.GetY() == y12 || mtp4.GetX() == x12 && mtp4.GetY() == y12)
                    {
                        coin12.Undraw();
                    }

                    

                   


                    #endregion

                    #region add point

                    if (player.GetX() == x1 && player.GetY() == y1 && exist1 == true)
                    {
                        coin1.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x2 && player.GetY() == y2 && exist2 == true)
                    {
                        coin2.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x3 && player.GetY() == y3 && exist3 == true)
                    {
                        coin3.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x4 && player.GetY() == y4 && exist4 == true)
                    {
                        coin4.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x5 && player.GetY() == y5 && exist5 == true)
                    {
                        coin5.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x6 && player.GetY() == y6 && exist6 == true)
                    {
                        coin6.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x7 && player.GetY() == y7 && exist7 == true)
                    {
                        coin7.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x8 && player.GetY() == y8 && exist8 == true)
                    {
                        coin8.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x9 && player.GetY() == y9 && exist9 == true)
                    {
                        coin9.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x10 && player.GetY() == y10 && exist10 == true )
                    {
                        coin10.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x11 && player.GetY() == y11 && exist11 == true)
                    {
                        coin11.Undraw();
                        cnt++;
                    }

                    if (player.GetX() == x12 && player.GetY() == y12 && exist12 == true)
                    {
                        coin12.Undraw();
                        cnt++;
                    }

                    #endregion //add point

                    #endregion

                    Console.ForegroundColor = (ConsoleColor)(i % 16);
                    if (i % 16 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(1, 27);
                    Console.WriteLine("points:" + cnt);

                    if (cnt >= maxPts)
                    {
                        Thread.Sleep(1000);
                        break;
                    }
                }
                Thread.Sleep(100);

                
            }

            



        }

        static void EndGame()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.BackgroundColor= ConsoleColor.Black;
            Console.Clear();
            if (win)
            {
                Console.Clear();
                for (int i = 0; i > 10000000; i++)
                {
                    Console.ForegroundColor = (ConsoleColor)(i % 16);
                    if (i % 16 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You won             *****************\r\n               ******               ******\r\n           ****                           ****\r\n        ****                                 ***\r\n      ***                                       ***\r\n     **           ***               ***           **\r\n   **           *******           *******          ***\r\n  **            *******           *******            **\r\n **             *******           *******             **\r\n **               ***               ***               **\r\n**                                                     **\r\n**       *                                     *       **\r\n**      **                                     **      **\r\n **   ****                                     ****   **\r\n **      **                                   **      **\r\n  **       ***                             ***       **\r\n   ***       ****                       ****       ***\r\n     **         ******             ******         **\r\n      ***            ***************            ***\r\n        ****                                 ****\r\n           ****                           ****\r\n               ******               ******\r\n                    *****************");

                ConsoleKeyInfo f = Console.ReadKey();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }
                if (f.Key == ConsoleKey.Escape)
                {
                    DVD();
                    
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("You have faild..... * sad 8 bit music *");
                Thread.Sleep(5000);
                Console.WriteLine(" \nSomehow.....");
                Thread.Sleep(5000);
                Console.WriteLine(" \nWell, better luck next time.....");
                Thread.Sleep(5000);
                Console.WriteLine(" \nBut always remamber.....");
                Thread.Sleep(5000);
                Console.WriteLine(" \nShmual Shmualson is by your side, and he will never give you up, Or ever let you down");
                Thread.Sleep(7000);
                Console.WriteLine(" \nOh, and one more thing");
                Thread.Sleep(5000);
                DVD();
            }
           
        }

        static void DVD()
        {
            TRect t0 = new TRect(0, 0, 50, 22, ConsoleColor.White);
            Console.Clear();
            t0.Draw();
            ConsoleColor color = (ConsoleColor)1;
            int j = 0;
            int ij = j;
            int i = 0;
            int ii = i;
            int x = 1;
            int y = 1;
            bool downy = true;
            bool downx = true;
            bool escape2 = false;
            while (!escape2)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = (ConsoleColor)0;
                Console.Write("cccc");
                if (i > 19)
                {
                    downy = false;
                    if (i == 36)
                    {
                        downy = true;
                        i *= 0;
                    }
                }

                if (downy)
                {
                    i++;
                    y = i;
                    ii = i;
                }
                else
                {
                    ii--;
                    y = ii;
                    i++;
                }

                if (j > 44)
                {
                    downx = false;
                    if (j == 88)
                    {
                        downx = true;
                        j *= 0;
                    }
                }

                if (downx)
                {
                    j++;
                    x = j;
                    ij = j;
                }
                else
                {
                    ij--;
                    x = ij;
                    j++;
                }

                if ((ij == 1) || (ii == 1) || (i == 16) || (j == 40))
                {
                    color++;
                    if (color == ConsoleColor.White)
                    {
                        color = (ConsoleColor)1;
                    }
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Escape)
                        escape2 = true;
                }
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = color;
                Console.Write("DVD");
                Thread.Sleep(40);
            }
        }
    }
}
