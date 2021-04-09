using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The actions taken, when a field position button is pressed
        /// </summary>
        /// <param name="sender">The object from whom this method is called</param>
        /// <param name="e">E</param>
        private void position_click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// The actions taken when starting the game
        /// </summary>
        /// <param name="sender">The object from whom this method is called</param>
        /// <param name="e">E</param>
        private void start_game(object sender, RoutedEventArgs e)
        {

        }
    }

    /// <summary>
    /// Represents a Game object
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The player object that holds player one
        /// </summary>
        public Player Player_One { get; set; }
        /// <summary>
        /// The player object that holds player two
        /// </summary>
        public Player Player_Two { get; set; }
        /// <summary>
        /// The Grid object that holds the grid with all fields
        /// </summary>
        public Grid Game_Grid { get; set; }

        /// <summary>
        /// Constructs a Game object
        /// </summary>
        /// <param name="p1">The username for player one</param>
        /// <param name="p2">The username for player two</param>
        public Game(string p1, string p2)
        {
            Player_One = new Player(p1);
            Player_Two = new Player(p2);
            Game_Grid = new Grid();
        }
    }

    /// <summary>
    /// Represents a Player object
    /// </summary>
    public class Player
    {
        /// <summary>
        /// This is the player's username. It can only be defined through the constructor.
        /// </summary>
        public string Username { get; private set; }
        /// <summary>
        /// Constructs a Player object
        /// </summary>
        /// <param name="username">The username for the player to be constructed</param>
        public Player(string username)
        {
            Username = username;
        }
    }

    /// <summary>
    /// Represents a Grid object
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// The grid which stores the values of each position
        /// </summary>
        public int[,] Grid_Matrix { get; set; }

        /// <summary>
        /// Constructs a Grid
        /// </summary>
        /// <param name="grid_size">This defines how big the grid is. Grid size is in square.</param>
        public Grid(int grid_size = 3)
        {
            // Initializing matrix for grid, a usual tic tac toe grid has 3 by 3 pieces
            Grid_Matrix = new int[grid_size, grid_size];
        }
    }
}
