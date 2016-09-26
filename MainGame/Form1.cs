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
        Cells[,] universe = new Cells[25, 25];
        //bool[,] universe = new bool[25, 25];
        Cells[,] hell = new Cells[25, 25];
        //bool[,] hell = new bool[25, 25];

        Color gridColor = Color.AliceBlue;
        Brush gridBrush = new SolidBrush(Color.YellowGreen);
        

        Timer timer = new Timer();

        //Keeps track of how many generations there have been
        int Generations = 0;

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
        private void NextGeneration()
        {
            //Calculate the next generation of life

            //Write the number of generations to the toolbox
            tssGenerationsNum.Text = "Generations: " + Generations.ToString();
        }


        //What happens when you click the exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Render the grid to the window
        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            //Use floats
            int width = gridPanel.ClientSize.Width / universe.GetLength(0);
            int height = gridPanel.ClientSize.Height / universe.GetLength(1);


            //Creating a new pen and setting the color to the variable gridColor
            Pen gridPen = new Pen(gridColor, 1);
            Point gridPoint = new Point();

            //not very efficiant. Try drawing lines later on instead of drawing rectangles
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    Rectangle rect = Rectangle.Empty;
                    rect.X = x * width;
                    rect.Y = y * height;
                    rect.Width = width;
                    rect.Height = height;
                    gridPoint = new Point(rect.X, rect.Y);
                    //living cells
                    if (universe[x, y].getAlive() == true)
                        e.Graphics.FillRectangle(gridBrush, rect.X, rect.Y, rect.Width, rect.Height);

                    //e.Graphics.DrawRectangle(gridPen,rect);
                    e.Graphics.DrawRectangle(gridPen, rect.X, rect.Y, rect.Width, rect.Height);

                    if (universe[x,y].getNeighbors() > 0)
                    {
                        e.Graphics.DrawString(universe[x, y].getNeighbors().ToString(), SystemFonts.DefaultFont, 
                            gridBrush, gridPoint);
                    }
                }
            }
            checkNeighbors();
            gridPen.Dispose();
        }

        //Clicking a cell will change it
        private void GridPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //Getting the width and height to find which cell the mouse clicks in
            int width = gridPanel.ClientSize.Width / universe.GetLength(0);
            int height = gridPanel.ClientSize.Height / universe.GetLength(1);

            if (e.Button == MouseButtons.Left)
            {
                int x = e.X / width;
                int y = e.Y / height;
                universe[x, y].toggleAlive();

                gridPanel.Invalidate();
            }
        }

        //Pressing either new button will run the new function resetting everything but the generations text
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PressNewButton();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
            gridPanel.Invalidate();
            stsMain.Text = "Generations:";
        }
        //End of new button code


        //Clicking play
        private void tsbPlay_Click(object sender, EventArgs e)
        {
            //clears the box for some reason
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private bool global = true;

        //Making it so you can drago to turn cells on
        private void gridPanel_MouseMove(object sender, MouseEventArgs e)
        {
            int width = gridPanel.ClientSize.Width / universe.GetLength(0);
            int height = gridPanel.ClientSize.Height / universe.GetLength(1);

            if (e.Button == MouseButtons.Left)
            {
                int x = e.X / width;
                int y = e.Y / height;
                try
                {
                    if (global)
                        universe[x, y].setAliveTrue();
                    else
                        universe[x, y].setAliveFalse();
                }
                catch
                {
                }
                gridPanel.Invalidate();
            }
        }

        //Helping with the mouse dragging section
        private void gridPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int width = gridPanel.ClientSize.Width / universe.GetLength(0);
            int height = gridPanel.ClientSize.Height / universe.GetLength(1);

            if (e.Button == MouseButtons.Left)
            {
                int x = e.X / width;
                int y = e.Y / height;

                global = !universe[x, y].getAlive();
                checkNeighbors();
            }
        }

        private void checkNeighbors()
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y].setNeighbor(-universe[x, y].getNeighbors());
                }
            }


                    for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    
                    if (universe[x, y].getAlive() == true)
                    {
                        try
                        {
                            universe[x - 1, y - 1].setNeighbor(1);
                        }
                        catch
                        { }
                        try
                        {
                            universe[x - 1, y].setNeighbor(1);
                        }
                        catch
                        { }
                        try
                        {
                            universe[x - 1, y + 1].setNeighbor(1);
                        }
                        catch
                        { }
                        try
                        {
                            universe[x, y - 1].setNeighbor(1);
                        }
                        catch
                        { }
                        try
                        {
                            universe[x + 1, y - 1].setNeighbor(1);
                        }
                        catch
                        { }
                        try
                        {
                            universe[x + 1, y].setNeighbor(1);
                        }
                        catch
                        { }
                        try
                        {
                            universe[x + 1, y + 1].setNeighbor(1);
                        }
                        catch { }
                    }
                }
            }
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    if (universe[x,y].getNeighbors() > 0)
                    {
                        
                    }
                }
            }
        }
    }
}