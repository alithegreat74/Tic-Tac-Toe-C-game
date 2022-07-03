using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] enrery = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Console.Write("Player number 1 you are: X\nPlayer number two you are: O\nThis is the table:\n");
            int winner=0;
            bool win = false;
            for (int i = 1; i<10; i++)
            {
                for (int j = 0; j<9; j++)
                {
                    if (nums[j]==10)
                    {
                        enrery[j]="X";
                    }
                    else if (nums[j]==11)
                    {
                        enrery[j]="O";
                    }
                }
                int playernum = i%2;
                if (playernum==0)
                    playernum=2;
                Console.Write("     |     |     \n");
                Console.Write("  "+enrery[0]+"  |  "+enrery[1]+"  |  "+enrery[2]+"  \n");
                Console.Write("     |     |     \n");
                Console.Write("-----------------\n");
                Console.Write("     |     |     \n");
                Console.Write("  "+enrery[3]+"  |  "+enrery[4]+"  |  "+enrery[5]+"  \n");
                Console.Write("     |     |     \n");
                Console.Write("-----------------\n");
                Console.Write("     |     |     \n");
                Console.Write("  "+enrery[6]+"  |  "+enrery[7]+"  |  "+enrery[8]+"  \n");
                Console.Write("     |     |     \n");
                Console.Write("Player number "+playernum+" what is your move? ");
                int answer = Convert.ToInt32(Console.ReadLine());
                while (answer<1 || answer>9)
                {
                    Console.Write("Answer is not initiated\ntry again: ");
                    answer=Convert.ToInt32(Console.ReadLine());
                }
                if (i%2==1)
                    nums[answer-1]=10;
                else
                    nums[answer-1]=11;
                if (nums[0]==nums[1] && nums[1]==nums[2])
                {
                    win=true;
                    winner=nums[0];
                }
                else if (nums[3]==nums[4] && nums[4]==nums[5])
                {
                    win=true;
                    winner=nums[3];
                }
                else if (nums[6]==nums[7] && nums[7]==nums[8])
                {
                    win=true;
                    winner=nums[6];
                }
                else if (nums[0]==nums[3] && nums[3]==nums[6])
                {
                    win=true;
                    winner=nums[0];
                }
                else if (nums[1]==nums[4] && nums[4]==nums[7])
                {
                    win=true;
                    winner=nums[1];
                }
                else if (nums[2]==nums[5] && nums[5]==nums[8])
                {
                    win=true;
                    winner=nums[2];
                }
                else if (nums[0]==nums[4] && nums[4]==nums[8])
                {
                    win=true;
                    winner=nums[0];
                }
                else if(nums[2]==nums[4] && nums[4]==nums[6])
                {
                    win=true;
                    winner=nums[2];
                }
                Console.Write("You made your move\nEnter 1 to continue: ");
                int order = Convert.ToInt32(Console.ReadLine());
                while (order!=1)
                {
                    Console.Write("Answer is not initiated\ntry again: ");
                    order=Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                if (win==true)
                    break;
            }
            if (win==false)
            {
                Console.Write("This game ended in a tie\nEnter 1 to exit: ");
                int order=Convert.ToInt32(Console.ReadLine());
                while (order!=1)
                {
                    Console.Write("Answer is not initiated\ntry again: ");
                    order=Convert.ToInt32(Console.ReadLine());
                }
                System.Environment.Exit(1);
            }
            else
            {
                int winnernum = winner%2;
                if (winnernum==0)
                    winnernum=1;
                else if (winnernum==1)
                    winnernum=2;
                Console.Write("Player number "+ winnernum + " won the game\nEnter 1 to exit: ");
                int order = Convert.ToInt32(Console.ReadLine());
                while (order!=1)
                {
                    Console.Write("Answer is not initiated\ntry again: ");
                    order=Convert.ToInt32(Console.ReadLine());
                }
                System.Environment.Exit(1);
            }
        }

    }
}

