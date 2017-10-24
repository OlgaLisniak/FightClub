﻿using System;
using System.IO;
using System.Windows.Forms;

namespace FightClub
{
    public partial class Form1 : Form
    {
        Player player;

        Computer computer;

        Log log = new Log();

        public Form1(string name)
        {
            InitializeComponent();

            player = new Player(name, 100);
            computer = new Computer("Computer", 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayer1.Text = player.Name;
            lblPlayer2.Text = computer.Name;

            progressBarHPPlayer1.Value = 100;
            progressBarHPPlayer2.Value = 100;

            player.Block += log.BlockHandler;
            player.Wound += log.WoundHandler;
            player.Death += log.DeathHandler;

            computer.Block += log.BlockHandler;
            computer.Wound += log.WoundHandler;
            computer.Death += log.DeathHandler;
        }

        int i = 0;

        private void btnRound_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
            string battleLog;

            lblNumbRound.Text = (i+2).ToString();
            
            if (player.Hp != 0 && computer.Hp != 0)
            {
                if (i % 2 != 0)
                {
                    if (rbHead.Checked)
                    {
                        player.SetBlock(BodyPart.Head);
                    }
                    else if (rbBody.Checked)
                    {
                        player.SetBlock(BodyPart.Body);
                    }
                    else if (rbLegs.Checked)
                    {
                        player.SetBlock(BodyPart.Legs);
                    }

                    BodyPart compAttack = computer.AtackPlayer();
                    
                    player.GetHit(compAttack);

                    progressBarHPPlayer1.Value = player.Hp;
                    progressBarHPPlayer2.Value = computer.Hp;

                    lblHPPlayer1.Text = player.Hp.ToString();
                    lblHPPlayer2.Text = computer.Hp.ToString();

                    if (player.Hp == 0)
                    {
                        DialogResult result = MessageBox.Show("Game over! \nYou lose :( \nDo you want to play again?", "", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            player = new Player(player.Name, 100);
                            computer = new Computer("Computer", 100);

                            progressBarHPPlayer1.Value = 100;
                            progressBarHPPlayer2.Value = 100;

                            lblHPPlayer1.Text = player.Hp.ToString();
                            lblHPPlayer2.Text = computer.Hp.ToString();

                            i = 0;

                            lblNumbRound.Text = (i + 1).ToString();
                        }
                        else
                        {
                            Close();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        lblAction.Text = "Choose part of the body to attack";

                        i++;
                    }
                }
                else
                {
                    computer.BlockPart();

                    if (rbHead.Checked)
                    {
                        computer.GetHit(BodyPart.Head);
                    }
                    else if (rbBody.Checked)
                    {
                        computer.GetHit(BodyPart.Body);
                    }
                    else if (rbLegs.Checked)
                    {
                        computer.GetHit(BodyPart.Legs);
                    }

                    progressBarHPPlayer1.Value = player.Hp;
                    progressBarHPPlayer2.Value = computer.Hp;

                    if (computer.Hp == 0)
                    {
                        DialogResult result = MessageBox.Show("Game over! \n You win :) \n Do you want to play again?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            player = new Player(player.Name, 100);
                            computer = new Computer("Computer", 100);
                            progressBarHPPlayer1.Value = 100;
                            progressBarHPPlayer2.Value = 100;

                            lblHPPlayer1.Text = player.Hp.ToString();
                            lblHPPlayer2.Text = computer.Hp.ToString();
                            lbLog.Items.Clear();

                            i = 0;

                            lblNumbRound.Text = (i + 1).ToString();
                        }
                        else
                        {
                            Close();
                            Environment.Exit(0);
                        }

                    }
                    else
                    {
                        lblAction.Text = "Choose part of the body to protect";

                        i++;
                    }
                }
            }
            battleLog = log.ToString();
            UpdateLB(battleLog);
        }

        private void UpdateLB (string log)
        {
            StreamWriter writer = new StreamWriter("GameLog.txt");

            string[] arrstr = log.Split('\n');

            for (int m = 0; m < arrstr.Length; m++)
            {
                lbLog.Items.Add(arrstr[m]);
                writer.WriteLine(arrstr[m] + "\n");
            }

            writer.Close();
        }
    }
}
