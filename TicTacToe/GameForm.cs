﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        static bool side;
        public static Logic logic = new Logic();
        public static Bot bot = new Bot();
        String[] sides = { "Hydra", "Shield" };
        static int[] score = new int[2];
        static bool winner;
        int rounds = 7;
        

        public GameForm()
        {
            InitializeComponent();
            score[0] = 0;
            score[1] = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logic.field[0, 0] == -5)
            {
                logic.field[0, 0] = Convert.ToInt32(side);
                bot.field[0, 0] = Convert.ToInt32(side);
                setPicture(side, button1);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if(checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (logic.field[0, 1] == -5)
            {
                logic.field[0, 1] = Convert.ToInt32(side);
                bot.field[0, 1] = Convert.ToInt32(side);
                setPicture(side, button2);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (logic.field[0, 2] == -5)
            {
                logic.field[0, 2] = Convert.ToInt32(side);
                bot.field[0, 2] = Convert.ToInt32(side);
                setPicture(side, button3);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (logic.field[1, 0] == -5)
            {
                logic.field[1, 0] = Convert.ToInt32(side);
                bot.field[1, 0] = Convert.ToInt32(side);
                setPicture(side, button4);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
                botMakeMove();
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (logic.field[1, 1] == -5)
            {
                logic.field[1, 1] = Convert.ToInt32(side);
                bot.field[1, 1] = Convert.ToInt32(side);
                setPicture(side, button5);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (logic.field[1, 2] == -5)
            {
                logic.field[1, 2] = Convert.ToInt32(side);
                bot.field[1, 2] = Convert.ToInt32(side);
                setPicture(side, button6);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (logic.field[2, 0] == -5)
            {
                logic.field[2, 0] = Convert.ToInt32(side);
                bot.field[2, 0] = Convert.ToInt32(side);
                setPicture(side, button7);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (logic.field[2, 1] == -5)
            {
                logic.field[2, 1] = Convert.ToInt32(side);
                bot.field[2, 1] = Convert.ToInt32(side);
                setPicture(side, button8);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (logic.field[2, 2] == -5)
            {
                logic.field[2, 2] = Convert.ToInt32(side);
                bot.field[2, 2] = Convert.ToInt32(side);
                setPicture(side, button9);
                if (checkfreeMove(logic.field) && logic.win(side) == false)
                {
                    bot.getMove(side);
                    if (bot.isDone == true)
                    {
                        botMakeMove();
                    }
                }
            }
            if (logic.win(side))
            {
                MessageBox.Show(sides[Convert.ToInt32(side)] + " is winner");
                score[Convert.ToInt32(side)]++;
                if (side == true)
                {
                    label3.Text = score[Convert.ToInt32(side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (logic.win(!side))
            {
                MessageBox.Show(sides[Convert.ToInt32(!side)] + " is winner");
                score[Convert.ToInt32(!side)]++;
                if (!side == true)
                {
                    label3.Text = score[Convert.ToInt32(!side)].ToString();
                }
                else
                {
                    label2.Text = score[Convert.ToInt32(!side)].ToString();
                }
                showWin();
                updateForm();
            }
            else if (checkfreeMove(logic.field) == false)
            {
                MessageBox.Show("Draw!");
                updateForm();
            }
        }

        public void showWin()
        {
            if(score[0] == rounds)
            {
                Result result = new Result(false);
                result.Show();
                this.Hide();
            } else if (score[1] == rounds)
            {
                Result result = new Result(true);
                result.Show();
                this.Hide();
            }
        }

        public static bool checkfreeMove(int[,] field)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (field[i, j] == -5) 
                        return true;
            return false;
        }

        private void updateForm()
        {
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    logic.field[i, j] = -5;
                    bot.field[i, j] = -5;
                }
            }
        }

        public static void playerSide(bool side1)
        {
            side = side1;
        }

        private void setPicture(bool side, Button button)
        {
            if (side)
            {
                button.BackgroundImage = Properties.Resources.shield;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.hydra;
            }
            button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void botMakeMove()
        {
            logic.field[bot.currentMove[0], bot.currentMove[1]] = Convert.ToInt32(!side);
            bot.field[bot.currentMove[0], bot.currentMove[1]] = Convert.ToInt32(!side);
            int[] coordinates = { bot.currentMove[0], bot.currentMove[1] };
            int a = bot.field[bot.currentMove[0], bot.currentMove[1]];
            int b = bot.currentMove[0];
            int c = bot.currentMove[1];
            int v = bot.currentMove[1];

            if (coordinates[0] == 0)
            {
                if (coordinates[1] == 0)
                {
                    setPicture(!side, button1);
                    logic.field[0,0] = Convert.ToInt32(!side);
                }
                else if (coordinates[1] == 1)
                {
                    setPicture(!side, button2);
                    logic.field[0, 1] = Convert.ToInt32(!side);
                }
                else if (coordinates[1] == 2)
                {
                    setPicture(!side, button3);
                    logic.field[0, 2] = Convert.ToInt32(!side);
                }
            }
            else if (coordinates[0] == 1)
            {
                if (coordinates[1] == 0)
                {
                    setPicture(!side, button4);
                    logic.field[1, 0] = Convert.ToInt32(!side);
                }
                else if (coordinates[1] == 1)
                {
                    setPicture(!side, button5);
                    logic.field[1, 1] = Convert.ToInt32(!side);
                }
                else if (coordinates[1] == 2)
                {
                    setPicture(!side, button6);
                    logic.field[1, 2] = Convert.ToInt32(!side);
                }
            }
            else if (coordinates[0] == 2)
            {
                if (coordinates[1] == 0)
                {
                    setPicture(!side, button7);
                    logic.field[2, 0] = Convert.ToInt32(!side);
                }
                else if (coordinates[1] == 1)
                {
                    setPicture(!side, button8);
                    logic.field[2, 1] = Convert.ToInt32(!side);
                }
                else if (coordinates[1] == 2)
                {
                    setPicture(!side, button9);
                    logic.field[2, 2] = Convert.ToInt32(!side);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form startForm = Application.OpenForms[0];
            startForm.Show();
            updateForm();
            score[0] = 0;
            score[1] = 0;
            label2.Text = "0";
            label3.Text = "0";
            this.Hide();
            bot.isDone = false;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
