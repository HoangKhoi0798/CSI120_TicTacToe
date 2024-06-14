namespace CSI120_TicTacToe
{
    internal class Program
    {
        // Hoang Khoi Gia Nguyen
        // CSI 120 - Computer Programming 120
        // Check for Winner - Tic Tac Toe
        static void Main(string[] args)
        {
            // Setting up the board you want to check
            char[,] board = {
       {'O', ' ', 'X'},
       {'O', 'X', 'O'},
       {'O', ' ', 'X'},
   };
            // Set the condition for a winning player
            char winner = WinCondition(board);
            // Print out the result
            if (winner != ' ')
            {
                Console.WriteLine("There is a winner!");
                Console.WriteLine($"{winner} won!");

            }
            else
            {
                Console.WriteLine("There is no winner");
            }


        }// Main

        
        public static char WinCondition(char[,] board) 
            // If we use bool, we can return the condition and print out the winner
            // Change it to char, and we can also return the character on the board after checking and print it out
        {
            {
                
                for (int x = 0; x < 3; x++)
                {
                    // Check row winner
                    if (board[x, 0] != ' ' && board[x, 0] == board[x, 1] && board[x, 1] == board[x, 2])
                    {
                        return board[x, 0];
                    }
                }

                    // Check columns winner
                for (int y = 0; y < 3; y++)
                {
                    if (board[0, y] != ' ' && board[0, y] == board[1, y] && board[1, y] == board[2, y])
                    {
                        return board[0, y];

                    }
                }

                    // Check diagonals winner
                if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    return board[0, 0];
                    // (Top-left to bottom-right)
                }
                if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    return board[0, 2];
                    // (Top-right to bottom-left)
                }

                return ' '; // No winner
            }
        }

        public static void BoardSample()
        {
            // Copy the content of the board to main
            // 


            // Diagonal Win
            char[,] board1 = {
       {'X', 'O', ' '},
       {' ', 'X', 'O'},
       {'O', ' ', 'X'},
   };
            // Horizontal Win
            char[,] board2 = {
       {'X', 'X', 'X'},
       {'O', ' ', 'O'},
       {' ', ' ', ' '},
   };
            // Vertical Win
            char[,] board3 = {
       {'O', ' ', 'X'},
       {'O', 'X', 'O'},
       {'O', ' ', 'X'},
   };
            // Mixed Board with Diagonal Win
            char[,] board4 = {
       {'X', 'O', 'X'},
       {' ', 'X', 'O'},
       {'X', ' ', 'X'},
   };
            // Horizontal Win with 'O'
            char[,] board5 = {
       {'O', 'O', 'O'},
       {'X', 'X', ' '},
       {' ', ' ', ' '},
   };

        }

    }// Class

}// Name
