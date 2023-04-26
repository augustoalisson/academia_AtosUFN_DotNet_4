namespace _6_desafioJogodaVelhaAVALIATIVO
{
    /*
    Desenvolva um jogo da velha utilizando matrizes em C#. Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
    Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. Após cada jogada, apresente o tabuleiro com as 
    jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
    Caso seja empate, apresente o resultado na tela. Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo. 


    Desafio extra, pode valer por alguma atividade futura: Faça a implementação de um jogo contra o computador. Faça o possível para evitar que o jogador vença do computador. 
    Para facilitar, faça com que o computador inicie jogando.

    Prazo de entrega: 24/04
    Forma e envio: Enviar pelo chat o link do github
    */
    internal class Program
    {
        public static void StartGame()
        {
            Console.WriteLine("Tic-Tac-Toe");
            Console.WriteLine("1 - Jogar Player vs Player");
            Console.WriteLine("2 - Jogar Player vs Computador");
            Console.WriteLine("0 - Sair");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Console.WriteLine("Jogo Encerrado!");
                    break;
                case 1:
                    Console.Clear();
                    PlayerVsPlayer();
                    break;
                case 2:
                    Console.Clear();
                    PlayerVsCPUEasyMode();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Digite uma opção válida!");
                    StartGame();
                    break;
            }
        }

        public static bool VerifyWinner(char[,] board, char playing, int turns)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == playing && board[i, 1] == playing && board[i, 2] == playing)
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == playing && board[1, i] == playing && board[2, i] == playing)
                {
                    return true;
                }
            }

            if (board[0, 0] == playing && board[1, 1] == playing && board[2, 2] == playing)
            {
                return true;
            }
            if (board[0, 2] == playing && board[1, 1] == playing && board[2, 0] == playing)
            {
                return true;
            }

            if (turns == 9)
            {
                return true;
            }

            return false;
        }

        public static void WriteBoard(char[,] board)
        {
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
        }

        public static void PlayerVsPlayer()
        {
            char playing = 'X';
            bool endTurn;
            bool endGame = false;
            String nameX, nameO;
            int l, c;
            char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

            Console.WriteLine("Digite o nome do jogador X:");
            nameX = Console.ReadLine();
            if (nameX == null || nameX == "")
            {
                nameX = "X";
            }

            Console.WriteLine("Digite o nome do jogador O:");
            nameO = Console.ReadLine();
            if (nameO == null || nameO == "")
            {
                nameO = "O";
            }

            Console.Clear();

            int turns = 0;

            do
            {
                do
                {
                    endTurn = false;

                    Console.WriteLine("\n" + (playing == 'X' ? nameX : nameO) + " digite linha que deseja jogar: ");
                    l = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n" + (playing == 'X' ? nameX : nameO) + " digite coluna que deseja jogar: ");
                    c = int.Parse(Console.ReadLine());

                    Console.Clear();

                    if (board[l, c] == ' ')
                    {
                        board[l, c] = playing;

                        endTurn = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Local preenchida, escolha outro!");
                    }

                    WriteBoard(board);

                    if (VerifyWinner(board, playing, turns) == true)
                    {
                        if (turns == 8)
                        {
                            Console.Clear();
                            WriteBoard(board);
                            Console.WriteLine("Empatou!");
                            endGame = true;
                        }
                        else
                        {
                            Console.Clear();
                            WriteBoard(board);
                            Console.WriteLine("O player " + (playing == 'X' ? nameX : nameO) + " Venceu!");
                            endGame = true;
                        }
                    }

                    if (endTurn == true)
                    {
                        if (playing == 'X')
                        {
                            playing = 'O';
                        }
                        else
                        {
                            playing = 'X';
                        }

                        turns++;
                    }

                } while (endTurn == false);

            } while (endGame != true);

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            char newGame = char.Parse(Console.ReadLine().ToUpper());

            if (newGame == 'S')
            {
                Console.Clear();
                StartGame();
            }
            else
            {
                Console.WriteLine("Jogo Encerrado!");
            }
        }

        public static void PlayerVsCPUEasyMode()
        {
            char playing = 'X';
            bool endTurn;
            bool endGame = false;
            String nameX;
            int l, c;
            char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            Random rnd = new Random();

            Console.WriteLine("CPU jogará como O.");
            Console.WriteLine("Digite o nome do jogador X:");
            nameX = Console.ReadLine();
            if (nameX == null || nameX == "")
            {
                nameX = "X";
            }

            Console.Clear();

            int turns = 0;

            do
            {
                do
                {
                    endTurn = false;

                    if (playing == 'X')
                    {
                        Console.WriteLine("\n" + nameX + " digite linha que deseja jogar: ");
                        l = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n" + nameX + " digite coluna que deseja jogar: ");
                        c = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        l = rnd.Next(3);
                        c = rnd.Next(3);
                    }

                    Console.Clear();

                    if (board[l, c] == ' ')
                    {
                        board[l, c] = playing;

                        endTurn = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Local preenchida, escolha outro!");
                    }

                    WriteBoard(board);

                    if (VerifyWinner(board, playing, turns) == true)
                    {
                        if (turns == 8)
                        {
                            Console.Clear();
                            WriteBoard(board);
                            Console.WriteLine("Empatou!");
                            endGame = true;
                        }
                        else
                        {
                            Console.Clear();
                            WriteBoard(board);
                            if (playing == 'X')
                            {
                                Console.WriteLine("O player " + nameX + " Venceu!");
                            }
                            else
                            {
                                Console.WriteLine("O CPU Venceu!");
                            }
                            endGame = true;
                        }
                    }

                    if (endTurn == true)
                    {
                        if (playing == 'X')
                        {
                            playing = 'O';
                        }
                        else
                        {
                            playing = 'X';
                        }

                        turns++;
                    }

                } while (endTurn == false);

            } while (endGame != true);

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            char newGame = char.Parse(Console.ReadLine().ToUpper());

            if (newGame == 'S')
            {
                Console.Clear();
                StartGame();
            }
            else
            {
                Console.WriteLine("Jogo Encerrado!");
            }
        }

        static void Main(string[] args)
        {
            StartGame();
        }
    }
}
