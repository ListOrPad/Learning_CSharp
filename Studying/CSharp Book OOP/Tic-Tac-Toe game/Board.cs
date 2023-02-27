public class Board
{
    //knows the status of every tile
    //tells if the tile is already filled
    //updates the status(data) and displays itself to the players every move(draws the board)
    private void UpdateBoard(char s1, char s2, char s3, char s4, char s5, char s6, char s7, char s8, char s9)
    {
        //Draw updated board
        Console.WriteLine
      ($" {s7} | {s8} | {s9} \n" +
       $"---+---+---\n" +
       $" {s4} | {s5} | {s6} \n" +
       $"---+---+---\n" +
       $" {s1} | {s2} | {s3} ");
    }
    public void Play()
    {
        //'s' stays for "symbol" variable
        char s1 = ' ';          
        char s2 = ' ';
        char s3 = ' ';
        char s4 = ' ';
        char s5 = ' ';
        char s6 = ' ';
        char s7 = ' ';
        char s8 = ' ';
        char s9 = ' ';

        //Draw the board
        UpdateBoard(s1, s2, s3, s4, s5, s6, s7, s8, s9);

        //Continue the flow of the game after the board was drawn
        while (true)
        {

            Player playerX = new Player();
            playerX.Input = Convert.ToChar(Console.ReadLine());
            switch (playerX.Input)
            {
                case '1':
                    s1 = 'X';               //XO variable add?    s1 = $'{XO}';
                    break;
                case '2':
                    s2 = 'X';
                    break;
                case '3':
                    s3 = 'X';
                    break;
                case '4':
                    s4 = 'X';
                    break;
                case '5':
                    s5 = 'X';
                    break;
                case '6':
                    s6 = 'X';
                    break;
                case '7':
                    s7 = 'X';
                    break;
                case '8':
                    s8 = 'X';
                    break;
                case '9':
                    s9 = 'X';
                    break;

            }


            //Draw updated board
            UpdateBoard(s1, s2, s3, s4, s5, s6, s7, s8, s9);


            Player playerO = new Player();
            switch (playerO.Input)
            {
                case '1':
                    s1 = 'O';
                    break;
                case '2':
                    s2 = 'O';
                    break;
                case '3':
                    s3 = 'O';
                    break;
                case '4':
                    s4 = 'O';
                    break;
                case '5':
                    s5 = 'O';
                    break;
                case '6':
                    s6 = 'O';
                    break;
                case '7':
                    s7 = 'O';
                    break;
                case '8':
                    s8 = 'O';
                    break;
                case '9':
                    s9 = 'O';
                    break;

            }

            UpdateBoard(s1, s2, s3, s4, s5, s6, s7, s8, s9);
        }
    }

}