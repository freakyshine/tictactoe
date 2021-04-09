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

        private void button_click(object sender, RoutedEventArgs e)
        {

        }

        private void start_game(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Game
    {
        public Player Player_One { get; set; }
        public Player Player_Two { get; set; }
        public Grid Game_Grid { get; set; }
    }
    public class Player
    {

    }
    public class Grid
    {
        /// <summary>
        /// The grid which stores the values of each position
        /// </summary>
        public int[,] Grid_Matrix { get; set; }

        /// <summary>
        /// This constructs a Grid
        /// </summary>
        /// <param name="grid_size">This defines how big the grid is. Grid size is in square.</param>
        public Grid(int grid_size = 3)
        {
            // Initializing matrix for grid, a usual tic tac toe grid has 3 by 3 pieces
            Grid_Matrix = new int[grid_size, grid_size];
        }
    }
}
