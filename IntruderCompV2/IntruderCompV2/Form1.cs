using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Bloon.IntruderDB;

namespace IntruderComp
{
    public partial class Form1 : Form
    {
        Agents newAgent = new Agents();
        public Form1()
        {
            //github
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Interaction.InputBox("Who is playing against each other?", "Clan Matches", "Clan VS Clan", -1, -1);
            if (label1.Text == "")
            {
                label1.Text = "Clan VS Clan";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent2Name.Text = newAgent.Name.ToString();
                agent2Ava.Load($"{newAgent.avatarURL}");
                agent2WinRate.Text = newAgent.winRate.ToString() + "%";
                agent2SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent2Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent3Name.Text = newAgent.Name.ToString();
                agent3Ava.Load($"{newAgent.avatarURL}");
                agent3WinRate.Text = newAgent.winRate.ToString() + "%";
                agent3SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent3Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent4Name.Text = newAgent.Name.ToString();
                agent4Ava.Load($"{newAgent.avatarURL}");
                agent4WinRate.Text = newAgent.winRate.ToString() + "%";
                agent4SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent4Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent8Name.Text = newAgent.Name.ToString();
                agent8Ava.Load($"{newAgent.avatarURL}");
                agent8WinRate.Text = newAgent.winRate.ToString() + "%";
                agent8SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent8Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent7Name.Text = newAgent.Name.ToString();
                agent7Ava.Load($"{newAgent.avatarURL}");
                agent7WinRate.Text = newAgent.winRate.ToString() + "%";
                agent7SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent7Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent1Name.Text = newAgent.Name.ToString();
                agent1Ava.Load($"{newAgent.avatarURL}");
                agent1WinRate.Text = newAgent.winRate.ToString() + "%";
                agent1SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent1Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }

        private void agent6Ava_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent6Name.Text = newAgent.Name.ToString();
                agent6Ava.Load($"{newAgent.avatarURL}");
                agent6WinRate.Text = newAgent.winRate.ToString() + "%";
                agent6SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent6Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }

        private void agent5Ava_Click(object sender, EventArgs e)
        {
            if (newAgent.IsRealPlayer(Interaction.InputBox("Please enter a valid intruder username", "Agent Lookup", "robstorm", -1, -1)) == true)
            {
                agent5Name.Text = newAgent.Name.ToString();
                agent5Ava.Load($"{newAgent.avatarURL}");
                agent5WinRate.Text = newAgent.winRate.ToString() + "%";
                agent5SurvRate.Text = newAgent.survivalRate.ToString() + "%";
                agent5Time.Text = newAgent.timePlayed.ToString();
            }
            else
            {
                return;
            }

        }
    }
}
