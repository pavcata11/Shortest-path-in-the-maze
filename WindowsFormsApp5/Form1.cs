using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public static int map_width = 20;
        public static int map_height = 20;
        public static int Width_rectangle = 20;
        public static int Height_rectangle = 20;
        public static Point start_position;
        public static Point end_position;
        public static Rectangle[][] rect;
        public static List<int[]> allCordinate_step_by_step = new List<int[]>();
        public static List<Cell> path = new List<Cell>();
        public static int flag = 0;
        public static bool paint_with_movingMouse_rectangles = false;
        public static int speed_visualisation = 23;

        public Form1()
        {
            //optimilization doublebuffer
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            set_max_min_value();
            lnlInformation.Visible = false;
            Create_Aray_Rectang();
        }
        public static void Create_Aray_Rectang()
        {
            int space = 0, space_height = 0;
            int space_between_widthRectandle = 2, space_between_heightRectangle = 4;
            rect = new Rectangle[map_height][];
            for (int i = 0; i < map_width; i++)
            {
                Rectangle[] r = new Rectangle[map_height];
                for (int j = 0; j < map_height; j++)
                {
                    var re = new Rectangle();
                    re.Width = Width_rectangle;
                    re.Height = Height_rectangle;
                    re.Location = new Point(space, space_height);
                    re.color = Color.DimGray;
                    space += space_between_widthRectandle + Width_rectangle;
                    r[j] = re;
                }
                space = 0;
                space_height += Height_rectangle + space_between_heightRectangle;
                rect[i] = r;
            }

            ////check is work/////////////////////////////////////////////////////////////////
            /*  for (int k=0; k<20; k++)
              {
                  for (int l = 0; l < 20; l++)
                  {
                      Console.WriteLine(rect[k][l].Width);
                      Console.WriteLine(rect[k][l].Height);
                      Console.WriteLine(rect[k][l].Location);
                      Console.WriteLine(rect[k][l].color);
                  }
              }*/
            ///////////////////////////////////////////////////////////////////////////////
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < rect.Length; i++)
                {
                    for (int j = 0; j < rect[i].Length; j++)
                    {
                        if (rect[i][j].Conteins(e.Location) && rect[i][j].color == Color.DimGray)
                        {
                            rect[i][j].color = Color.Black;
                            paint_with_movingMouse_rectangles = true;
                        }
                        Invalidate();
                    }
                }
            }
        }
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < map_width; i++)
            {
                for (int j = 0; j < map_height; j++)
                {
                    rect[i][j].Paint(e.Graphics);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)///when click some rectangle paint  back gray
        {
            if (paint_with_movingMouse_rectangles==false)
            {
                for (int i = 0; i < rect.Length; i++)
                {
                    for (int j = 0; j < rect[i].Length; j++)
                    {
                        if (rect[i][j].Conteins(e.Location) && rect[i][j].color == Color.Black)
                        {
                            rect[i][j].color = Color.DimGray;
                            Invalidate();
                        }
                       
                    }
                }
            }
            paint_with_movingMouse_rectangles = false;
        }

        public static int shortestPath(Rectangle[][] map, Cell start, Cell end)
        {

            // initialize distances array filled with infinity   // the start node should get distance 0
            int[][] distances = new int[map.Length][];
            for (int i = 0; i < map.Length; i++)
            {
                distances[i] = new int[map[i].Length];
                for (int j = 0; j < map[i].Length; j++)
                {
                    distances[i][j] = int.MaxValue;
                }
            }


            int distance = 0;
            List<Cell> currentCells = new List<Cell> { start };
            while (distances[end.row][end.col] == int.MaxValue && currentCells.Count > 0)
            {
                List<Cell> nextCells = new List<Cell>();

                // loop over all cells added in previous round// set their distance //    and add their neighbors to the list for next round
                foreach (Cell cell in currentCells)
                {
                    if (distances[cell.row][cell.col] == int.MaxValue && !(map[cell.row][cell.col].color == Color.Black))
                    {
                        distances[cell.row][cell.col] = distance;
                        addNeighbors(cell, nextCells, map.Length, map[0].Length);
                    }
                }
                currentCells = nextCells;
                distance++;
            }
            // find the path
            if (distances[end.row][end.col] < int.MaxValue)
            {
                Cell cell = end;
                path.Add(end);
                for (int i = distances[end.row][end.col] - 1; i >= 0; i--)
                {
                    cell = getNeighbor(cell, i, distances);
                    path.Add(cell);
                }
            }
            return distances[end.row][end.col];
        }
        /* static int[] Path_Row = { 0, 0, 1, -1 };
         static int[] Path_Col = { 1, -1, 0, 0 };*/
        private static void addNeighbors(Cell cell, List<Cell> list, int maxRow, int maxCol)
        {
            int[][] directionArray = new int[][]
            {
        new int[] {-1, 0},
        new int[] {1, 0},
        new int[] {0, -1},
        new int[] {0, 1}
            };
            /*for (int index = 0; index < Path_Row.Length; index++)
            {
                int row = cell.row + Path_Row[index];
                int col = cell.col + Path_Col[index];
                if (isValid_and_add_cordinate_in_list(row, col, maxRow, maxCol))
                {
                    list.Add(new Cell(row, col));
                }
            }*/
            foreach (int[] direction in directionArray)
            {
                int row = cell.row + direction[0];
                int col = cell.col + direction[1];
                if (isValid_and_add_cordinate_in_list(row, col, maxRow, maxCol))
                {
                    list.Add(new Cell(row, col));
                }
            }
        }

        // find the neighbor of a cell having a certain distance from the start// working also with two array  
        /*static int[] Path_Row = { 0, 0, 1, -1 };
        static int[] Path_Col = { 1, -1, 0, 0 };*/
        private static Cell getNeighbor(Cell cell, int distance, int[][] distances)
        {
            int[][] directionArray = new int[][]
            {
        new int[] {-1, 0},
        new int[] {1, 0},
        new int[] {0, -1},
        new int[] {0, 1}
            };
            /* for (int index = 0; index < Path_Row.Length; index++)
             {
                 int row = cell.row + Path_Row[index];
                 int col = cell.col + Path_Col[index];
                 if (isValid_and_add_cordinate_in_list(row, col, distances.Length, distances[0].Length) && distances[row][col] == distance)
                 {
                     return new Cell(row, col);
                 }
             }*/
            foreach (int[] d in directionArray)
            {
                int row = cell.row + d[0];
                int col = cell.col + d[1];
                if (isValid_and_add_cordinate_in_list(row, col, distances.Length, distances[0].Length) && distances[row][col] == distance)
                {
                    return new Cell(row, col);
                }
            }
            return null;
        }

        // check if coordinates are inside the maze
        public static bool isValid_and_add_cordinate_in_list(int row, int col, int maxRow, int maxCol)
        {

            if (row >= 0 && row < maxRow && col >= 0 && col < maxCol)
            {
                if (rect[row][col].color != Color.Black)
                {

                    int[] cordinate = new int[2];
                    cordinate[0] = row;
                    cordinate[1] = col;
                    allCordinate_step_by_step.Add(cordinate);
                }
                return true;
            }
            return false;
        }
        public void set_start_and_end_position()
        {
            start_position.X = int.Parse(numericUpDown1.Value.ToString());
            start_position.Y = int.Parse(numericUpDown2.Value.ToString());
            end_position.X = int.Parse(numericUpDown3.Value.ToString());
            end_position.Y = int.Parse(numericUpDown4.Value.ToString());

        }
        public bool check_input_cordinate_is_corect()
        {
            if (start_position.X == end_position.X && start_position.Y == end_position.Y)
            {
                return false;
            }
            if ((rect[start_position.X][start_position.Y].color == Color.Black) || rect[end_position.X][end_position.Y].color == Color.Black)
            {
                return false;
            }

            return true;
        }
        public void set_max_min_value()
        {
            numericUpDown1.Maximum = map_width - 1;
            numericUpDown2.Maximum = map_height - 1;
            numericUpDown3.Maximum = map_width - 1;
            numericUpDown4.Maximum = map_height - 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            set_start_and_end_position();

            if (radioButton1.Checked && flag == 0)
            {
                if (check_input_cordinate_is_corect() == true)
                {
                    Invalidate();
                    lnlInformation.Visible = true;
                    lnlInformation.Text = "Algoritum ready for use";
                    rect[start_position.X][start_position.Y].color = Color.Blue;
                    rect[end_position.X][end_position.Y].color = Color.Red;
                    flag = 1;
                    Console.WriteLine(shortestPath(rect, new Cell(start_position.X, start_position.Y), new Cell(end_position.X, end_position.Y)));
                }
                else
                {
                    lnlInformation.Visible = true;
                    lnlInformation.Text = "Invalide cordinate";
                }
            }
        }

        private void btnStepByStep_Click(object sender, EventArgs e)
        {
            Graphics graphics;
            foreach (var cordinate in allCordinate_step_by_step)
            {
                if (rect[cordinate[0]][cordinate[1]].color != Color.Red && rect[cordinate[0]][cordinate[1]].color != Color.Blue)
                {
                    graphics = CreateGraphics();
                    rect[cordinate[0]][cordinate[1]].color = Color.Green;
                    rect[cordinate[0]][cordinate[1]].Paint(graphics);
                    // await Task.Delay(60); // working also with async method?  
                    Thread.Sleep(speed_visualisation);
                }
            }
        }
        private void btnShowDistance_Click(object sender, EventArgs e)
        {
            int shortDistance = shortestPath(rect, new Cell(start_position.X, start_position.Y), new Cell(end_position.X, end_position.Y));
            if (shortDistance == int.MaxValue)
            {
                lblShowDistance.Text = "No find path";
            }
            else
            {
                lblShowDistance.Text = shortDistance.ToString();
            }
        }

        private void btnShowShortestPath_Click(object sender, EventArgs e)
        {
            path.Reverse();
            Graphics graph;
            foreach (var g in path)
            {
                if (rect[g.row][g.col].color != Color.Red && rect[g.row][g.col].color != Color.Blue)
                {
                    graph = CreateGraphics();
                    Console.WriteLine(g.row + " " + g.col);
                    rect[g.row][g.col].color = Color.Orange;
                    rect[g.row][g.col].Paint(graph);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblShowDistance.Text = null;
            lnlInformation.Visible = false;
            allCordinate_step_by_step.Clear();
            path.Clear();
            for (int i = 0; i < rect.Length; i++)
            {
                for (int j = 0; j < rect[i].Length; j++)
                {
                    if (rect[i][j].color != Color.DimGray)
                    {
                        rect[i][j].color = Color.DimGray;
                    }
                    Invalidate();
                }
            }
            flag = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
