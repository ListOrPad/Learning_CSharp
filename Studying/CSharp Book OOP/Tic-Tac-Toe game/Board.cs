public class Board
{
    //knows the status of every tile
    //tells if the tile is already filled
    //updates the status(data) and displays itself to the players every move(draws the board)
    public void UpdateBoard()
    {
        char x1 = ' ';           //symbol variable
        char x2 = ' ';
        char x3 = ' ';
        char x4 = ' ';
        char x5 = ' ';
        char x6 = ' ';
        char x7 = ' ';
        char x8 = ' ';
        char x9 = ' ';
        Console.WriteLine
          ($" {x7} | {x8} | {x9} \n" +
           $"---+---+---\n" +
           $" {x4} | {x5} | {x6} \n" +
           $"---+---+---\n" +
           $" {x1} | {x2} | {x3} ");
        while (true)
        {

            Player playerX = new Player();     //we need a good constructor!
            switch (playerX.Input)
            {
                case '1':
                    x1 = 'X';
                    break;
                case '2':
                    x2 = 'X';
                    break;
                case 3:
                    x3 = 'X';
                    break;
                case 4:
                    x4 = 'X';
                    break;
                case 5:
                    x5 = 'X';
                    break;
                case 6:
                    x6 = 'X';
                    break;
                case 7:
                    x7 = 'X';
                    break;
                case 8:
                    x8 = 'X';
                    break;
                case 9:
                    x9 = 'X';
                    break;
            } 
        }
    }

}