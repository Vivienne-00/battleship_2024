using System.Runtime.InteropServices;

namespace Battleship
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AllocConsole();

            ApplicationConfiguration.Initialize();
            //SplashScreen splashScreen = new SplashScreen();
            //Application.Run(splashScreen);
            Console.WriteLine("Splashscreen geht weiter");

            SplashScreen gameScreen = new SplashScreen();
            gameScreen.ShowDialog();

            /*

                        var game = new BattleshipGame();
                        var controller = new BattleshipGameController(game);

                        Form form = new GameScreen();
                        form.Size = new Size(800, 400);

                        // Grösse des Boardes schon ausgewählt.
                        int fieldSize = 10;
                        game.Player1Board = new GameBoard(fieldSize, "EMC");
                        game.Player2Board = new GameBoard(fieldSize, "MV");

                        var player1GameBoardView = new GameBoardView(game.Player1Board, 30, 30, 350, form);
                        player1GameBoardView.SetController(controller);
                        var player2GameBoardView = new GameBoardView(game.Player2Board, 410, 30, 350, form);
                        player2GameBoardView.SetController(controller);
                        var gameStatusView = new GameStatusView(controller);

                        controller.RegisterView(player1GameBoardView);
                        controller.RegisterView(player2GameBoardView);
                        controller.RegisterView(gameStatusView);

                        controller.InitializeGame();

                        // To customize application configuration such as set high DPI settings or default font,
                        // see https://aka.ms/applicationconfiguration.
                        Application.Run(form);


                        do
                        {

                            Console.Write("X-Koordinate: ");
                            var x = int.Parse(Console.ReadLine());

                            Console.Write("Y-Koordinate: ");
                            var y = int.Parse(Console.ReadLine());

                            controller.HandlePlayerInput(new Coordinate { X = x, Y = y });
                        } while (true);*/

        }
    }
}