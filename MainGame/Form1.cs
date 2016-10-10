using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGame
{
    //Choosing color
    /*
      Need to initilize the dialog box to show the current color
      ColorDialog dlg = new ColorDialog();

        dlg.Color = panel1.BackColor;

        //Clicking close on the top right is the same as hitting cancel
        //Doesn't do anything if cancel is hit, saves the changes if ok is hit
        if(DialogResult.OK == dlg.showdialog();
        {
            panel1.BackColor = dlg.Color;
        }
        */

    public partial class Form1 : Form
    {
        Color gridColor = Color.PaleGoldenrod;
        Color cellColor = Color.Blue;


        Random RNG = new Random();
        Timer timer = new Timer();
        Seed seed = new Seed();
        Random RNGSeed;
        int currentSeed;

        Options opt;

        //Keeps track of how many generations there have been
        int Generations = 0;
        int cellCount = 0;

        int xSize = 30;
        int ySize = 30;

        bool universeFinite = true;
        Cells[,] universe;


        //initializing code and setting timer
        public Form1()
        {
            InitializeComponent();

            CreateUniverse();

            //Set Timer
            timer.Tick += Timer_Tick;
            timer.Interval = 50;
        }
        public void CreateUniverse()
        {
            universe = new Cells[xSize, ySize];

            //Only paint in wm.paint
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = new Cells(x, y);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Create
            NextGeneration();
            Generations++;

            //Repainting the window every timer interval
            gridPanel.Invalidate();
        }
        //end timer code


        //creat life simulation
        private void NextGeneration()
        {
            //Any live cell with fewer than two live neighbours dies, as if caused by under-population.
            //Any live cell with two or three live neighbours lives on to the next generation.
            //Any live cell with more than three live neighbours dies, as if by over - population.
            //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.


            //Calculate the next generation of life
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (universe[x, y].getAlive())
                    {
                        if (universe[x, y].getNeighbors() < 2 || universe[x, y].getNeighbors() > 3)
                            universe[x, y].toggleAlive();
                    }
                    else
                    {
                        if (universe[x, y].getNeighbors() == 3)
                            universe[x, y].toggleAlive();
                    }
                }
            }
            Generations++;
            gridPanel.Invalidate();

            //Write the number of generations to the toolbox
            tssGenerationsNum.Text = "Generations: " + Generations.ToString();
        }
        //end Next generation code


        /*
         * Paint Section
         */

        //Render the grid to the window
        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {

            Brush gridBrush = new SolidBrush(cellColor);
            Brush aliveBrush = new SolidBrush(Color.ForestGreen);
            Brush deadBrush = new SolidBrush(Color.Red);

            currentSeed = seed.worldSeed;
            RNGSeed = new Random(currentSeed);


            cellCount = 0;
            //Use floats
            float width = (float)gridPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)gridPanel.ClientSize.Height / universe.GetLength(1);


            //Creating a new pen and setting the color to the variable gridColor
            Pen gridPen = new Pen(gridColor, 1);
            Point gridPoint = new Point();

            resetNeighbors();
            if (viewGrid.Checked)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    Point p1 = new Point((int)(x * width), 0);
                    Point p2 = new Point((int)(x * width), gridPanel.ClientSize.Height);
                    e.Graphics.DrawLine(gridPen, p1, p2);
                }
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    Point p1 = new Point(0, (int)(y * height));
                    Point p2 = new Point(gridPanel.ClientSize.Width, (int)(y * height));
                    e.Graphics.DrawLine(gridPen, p1, p2);
                }
            }
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    Rectangle rect = Rectangle.Empty;
                    rect.X = (int)(x * width);
                    rect.Y = (int)(y * height);
                    rect.Width = (int)width;
                    rect.Height = (int)height;

                    //living cells
                    if (universe[x, y].getAlive() == true)
                    {
                        cellCount++;
                        e.Graphics.FillRectangle(gridBrush, rect.X, rect.Y, rect.Width, rect.Height);
                        checkNeighbors(x, y);
                    }

                }
            }
            if (viewNeighbor.Checked)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        if (universe[x, y].getNeighbors() > 0)
                        {
                            gridPoint = new Point((int)(x * width), (int)(y * height));

                            if (universe[x, y].getAlive())
                            {
                                if (universe[x, y].getNeighbors() < 2 || universe[x, y].getNeighbors() > 3)
                                {
                                    e.Graphics.DrawString(universe[x, y].getNeighbors().ToString(), SystemFonts.DefaultFont,
                                        deadBrush, gridPoint);
                                }
                                else
                                {
                                    e.Graphics.DrawString(universe[x, y].getNeighbors().ToString(), SystemFonts.DefaultFont,
                                          aliveBrush, gridPoint);
                                }
                            }
                            else
                            {
                                if (universe[x, y].getNeighbors() == 3)
                                {
                                    e.Graphics.DrawString(universe[x, y].getNeighbors().ToString(), SystemFonts.DefaultFont,
                                aliveBrush, gridPoint);
                                }
                                else
                                {
                                    e.Graphics.DrawString(universe[x, y].getNeighbors().ToString(), SystemFonts.DefaultFont,
                                deadBrush, gridPoint);
                                }
                            }
                        }
                    }
                }
            }
            tssCells.Text = "Cells: " + cellCount;

            gridPen.Dispose();
        }
        //End drawing function



        //Pressing either new button will run the new function resetting everything but the generations text
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PressNewButton();
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
            PressNewButton();
        }
        private void tsmiClear_Click(object sender, EventArgs e)
        {
            PressNewButton();
        }
        private void PressNewButton()
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = new Cells();
                }
            }
            Generations = 0;
            timer.Stop();
            tssGenerationsNum.Text = "Generations: " + Generations;
            gridPanel.Invalidate();
        }
        //End of new button code


        //Clicking play
        private void tsbPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void tsmiStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private bool global = true;


        //Mouse clicking code
        //Making it so you can drago to turn cells on
        //Clicking a cell will change it
        private void GridPanel_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void gridPanel_MouseMove(object sender, MouseEventArgs e)
        {
            float width = (float)gridPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)gridPanel.ClientSize.Height / universe.GetLength(1);

            if (e.Button == MouseButtons.Left)
            {
                int x = (int)(e.X / width);
                int y = (int)(e.Y / height);
                if (x >= 0 && x < universe.GetLength(0) && y >= 0 && y < universe.GetLength(1))
                {
                    if (global)
                        universe[x, y].setAliveTrue();
                    else
                        universe[x, y].setAliveFalse();
                }
                gridPanel.Invalidate();
            }
        }
        //Helping with the mouse dragging section
        private void gridPanel_MouseDown(object sender, MouseEventArgs e)
        {
            float width = (float)gridPanel.ClientSize.Width / universe.GetLength(0);
            float height = (float)gridPanel.ClientSize.Height / universe.GetLength(1);

            if (e.Button == MouseButtons.Left)
            {
                int x = (int)(e.X / width);
                int y = (int)(e.Y / height);

                if (x >= 0 && x < universe.GetLength(0) && y >= 0 && y < universe.GetLength(1))
                {
                    global = !universe[x, y].getAlive();
                    universe[x, y].toggleAlive();
                }
                gridPanel.Invalidate();
            }
        }


        //End of mouse clicking and dragging code


        //Setting neighbors surrounding alive cell
        private void checkNeighbors(int X, int Y)
        {
            if (universe[X, Y].getAlive() == true)
            {
                if (universeFinite)
                {

                    if (X > 0 && Y > 0 && X < universe.GetLength(0) - 1 && Y < universe.GetLength(1) - 1)
                    {
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                    }
                    else if (X == 0 && Y > 0 && Y < universe.GetLength(1) - 1)
                    {
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                    }
                    else if (X == 0 && Y == 0)
                    {
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                    }
                    else if (Y == 0 && X < universe.GetLength(0) - 1)
                    {
                        universe[X + 1, Y + 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                    }
                    else if (X == 0 & Y == universe.GetLength(1) - 1)
                    {
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y == 0)
                    {
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y < universe.GetLength(1) - 1)
                    {
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y == universe.GetLength(1) - 1)
                    {
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y < universe.GetLength(1) - 1 && Y > 0)
                    {
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                    }
                    else if (Y == universe.GetLength(1) - 1 && X < universe.GetLength(0) - 1 && X > 0)
                    {
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                    }
                }

                else
                {
                    if (X == 0 && Y == 0)
                    {
                        universe[universe.GetLength(0) - 1, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[0, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[1, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[universe.GetLength(0) - 1, 0].setNeighbor(1);
                        universe[1, 0].setNeighbor(1);
                        universe[universe.GetLength(0) - 1, 1].setNeighbor(1);
                        universe[0, 1].setNeighbor(1);
                        universe[1, 1].setNeighbor(1);
                    }
                    else if (X < universe.GetLength(0) - 1 && Y == 0)
                    {
                        universe[X - 1, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[X, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[X + 1, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y == 0)
                    {
                        universe[X - 1, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[X, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[0, universe.GetLength(1) - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[0, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[0, Y + 1].setNeighbor(1);
                    }
                    //End of top lines
                    else if (X == 0 && Y < universe.GetLength(1) - 1)
                    {
                        universe[universe.GetLength(0) - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                        universe[universe.GetLength(0) - 1, Y].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[universe.GetLength(0) - 1, Y - 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                    }
                    else if (X > 0 && X < universe.GetLength(0) - 1 && Y > 0 && Y < universe.GetLength(1) - 1)
                    {
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X + 1, Y + 1].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y > 0 && Y < universe.GetLength(1) - 1)
                    {
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[0, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[0, Y].setNeighbor(1);
                        universe[X - 1, Y + 1].setNeighbor(1);
                        universe[X, Y + 1].setNeighbor(1);
                        universe[0, Y + 1].setNeighbor(1);
                    }
                    //End of middle
                    else if (X == 0 && Y == universe.GetLength(1) - 1)
                    {
                        universe[universe.GetLength(0) - 1, Y - 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[universe.GetLength(0) - 1, Y].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[universe.GetLength(0) - 1, 0].setNeighbor(1);
                        universe[X, 0].setNeighbor(1);
                        universe[X + 1, 0].setNeighbor(1);
                    }
                    else if (X < universe.GetLength(0) - 1 && Y == universe.GetLength(1) - 1)
                    {
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[X + 1, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[X + 1, Y].setNeighbor(1);
                        universe[X - 1, 0].setNeighbor(1);
                        universe[X, 0].setNeighbor(1);
                        universe[X + 1, 0].setNeighbor(1);
                    }
                    else if (X == universe.GetLength(0) - 1 && Y == universe.GetLength(1) - 1)
                    {
                        universe[X - 1, Y - 1].setNeighbor(1);
                        universe[X, Y - 1].setNeighbor(1);
                        universe[0, Y - 1].setNeighbor(1);
                        universe[X - 1, Y].setNeighbor(1);
                        universe[0, Y].setNeighbor(1);
                        universe[X - 1, 0].setNeighbor(1);
                        universe[X, 0].setNeighbor(1);
                        universe[0, 0].setNeighbor(1);
                    }
                }
            }
        }



        //Resets the neighbors so they don't keep counting everytime a new cell is made
        public void resetNeighbors()
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y].setNeighbor(-universe[x, y].getNeighbors());
                }
            }
        }

        private void tsbPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }


        private void tsmExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }
        private void tsmiNext_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void viewGrid_Click(object sender, EventArgs e)
        {
            toggleGrid();
        }
        private void gridVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleGrid();
        }
        private void toggleGrid()
        {
            if (viewGrid.Checked)
            {
                viewGrid.Checked = false;
                gridVisibleToolStripMenuItem.Checked = false;
            }
            else
            {
                viewGrid.Checked = true;
                gridVisibleToolStripMenuItem.Checked = true;
            }
            gridPanel.Invalidate();
        }

        private void viewNeighbor_Click(object sender, EventArgs e)
        {
            toggleNeighborCount();
        }
        private void neighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleNeighborCount();
        }
        private void toggleNeighborCount()
        {
            if (viewNeighbor.Checked)
            {
                viewNeighbor.Checked = false;
                neighborCountToolStripMenuItem.Checked = false;
            }
            else
            {
                viewNeighbor.Checked = true;
                neighborCountToolStripMenuItem.Checked = true;
            }

            gridPanel.Invalidate();
        }

        private void viewHUD_Click(object sender, EventArgs e)
        {
            if (viewHUD.Checked)
                viewHUD.Checked = false;
            else
                viewHUD.Checked = true;

            gridPanel.Invalidate();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opt = new Options();
            opt.xAxis = xSize;
            opt.yAxis = ySize;
            opt.milTimer = timer.Interval;
            opt.gridColors = gridColor;
            opt.cellColors = cellColor;
            opt.backgroundColors = gridPanel.BackColor;
            opt.universeType = universeFinite;

            if (DialogResult.OK == opt.ShowDialog())
            {
                xSize = opt.xAxis;
                ySize = opt.yAxis;
                timer.Interval = opt.milTimer;
                gridColor = opt.gridColors;
                cellColor = opt.cellColors;
                gridPanel.BackColor = opt.backgroundColors;
                universeFinite = opt.universeType;
                CreateUniverse();
            }
            gridPanel.Invalidate();
        }

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PressNewButton();
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (RNG.Next() % 3 == 0)
                        universe[x, y].setAliveTrue();
                }
            }
            gridPanel.Invalidate();
        }
        private void fromNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seed.worldSeed = currentSeed;
            if (DialogResult.OK == seed.ShowDialog())
            {
                currentSeed = seed.worldSeed;
                PressNewButton();
                RNGSeed = new Random(currentSeed);
                randomizeWorld();
            }
        }
        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PressNewButton();
            randomizeWorld();
        }

        private void randomizeWorld()
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (RNGSeed.Next() % 3 == 0)
                        universe[x, y].setAliveTrue();
                }
            }
            gridPanel.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void openFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                int fileWidth = 0;
                int fileHeight = 0;

                //Getting the size of the universe
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();

                    if (row[0] != '!')
                    {
                        fileHeight++;
                        fileWidth = row.Length;
                    }
                }

                universe = new Cells[fileWidth, fileHeight];
                for (int y = 0; y < fileHeight; y++)
                {
                    for (int x = 0; x < fileWidth; x++)
                    {
                        universe[x, y] = new Cells();
                    }
                }

                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Reading cells
                int rowNum = 0;
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();

                    if (row[0] != '!')
                    {
                        for (int xPos = 0; xPos < row.Length; xPos++)
                        {
                            if (row[xPos] == '0')
                                universe[xPos, rowNum].setAliveTrue();
                            else if (row[xPos] == '.')
                                universe[xPos, rowNum].setAliveFalse();
                        }
                        rowNum++;
                    }

                }
                reader.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }
        private void saveFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";


            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    String currentRow = string.Empty;

                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y].getAlive() == true)
                            currentRow += ('0');
                        else
                            currentRow += ('.');
                    }
                    writer.WriteLine(currentRow);
                }
                writer.Close();
            }
        }

        private void nextToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunTo run = new RunTo();
            run.runNumber = Generations - 1;

            if (DialogResult.OK == run.ShowDialog())
            {
                for (int i = Generations; i < run.runNumber; i++)
                    NextGeneration();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.TimeGap = opt.milTimer;
            Properties.Settings.Default.xAxisSize = opt.xAxis;
            Properties.Settings.Default.yAxisSize = opt.yAxis;
            Properties.Settings.Default.GridLinesColor = opt.gridColors;
            Properties.Settings.Default.GridBackground = opt.backgroundColors;
            Properties.Settings.Default.AliveCellColor = opt.cellColors;
            Properties.Settings.Default.universeType = universeFinite;
        }
    }
}