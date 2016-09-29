using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGame
{
    public partial class Form1 : Form
    {
        Cells[,] universe = new Cells[35, 35];
        //Cells[,] hell = new Cells[25, 25];

        Color gridColor = Color.AliceBlue;
        Brush gridBrush = new SolidBrush(Color.Blue);
        Brush aliveBrush = new SolidBrush(Color.ForestGreen);
        Brush deadBrush = new SolidBrush(Color.Red);

        Random RNG = new Random();


        Timer timer = new Timer();

        //Keeps track of how many generations there have been
        int Generations = 0;

        int cellCount = 0;

        //initializing code and setting timer
        public Form1()
        {
            InitializeComponent();
            //Only paint in wm.paint
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = new Cells(x, y);
                }
            }

            //Set Timer
            timer.Tick += Timer_Tick;
            timer.Interval = 50;

            
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
                        {
                            universe[x, y].toggleAlive();
                        }
                    }
                    else
                    {
                        if (universe[x, y].getNeighbors() == 3)
                        {
                            universe[x, y].toggleAlive();
                        }
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
            //clears the box for some reason
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
                if (x > 0 && x < universe.GetLength(0) && y > 0 && y < universe.GetLength(1))
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

                if (x > 0 && x < universe.GetLength(0) && y > 0 && y < universe.GetLength(1))
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

        private void tsmExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void toolsRandomize_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (RNG.Next() % 3 == 0)
                        universe[x, y].toggleAlive();
                }
                gridPanel.Invalidate();
            }
        }

        private void viewGrid_Click(object sender, EventArgs e)
        {
            if (viewGrid.Checked)
                viewGrid.Checked = false;
            else
                viewGrid.Checked = true;
            gridPanel.Invalidate();
        }

        private void viewNeighbor_Click(object sender, EventArgs e)
        {
            if (viewNeighbor.Checked)
                viewNeighbor.Checked = false;
            else
                viewNeighbor.Checked = true;

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
        
    }
}