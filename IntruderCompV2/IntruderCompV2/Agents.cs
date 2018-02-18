using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bloon.IntruderDB
{
    public class Agents
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string avatarURL { get; set; }
        public string XP { get; set; }
        public string timePlayed { get; set; }
        public string matchesPlayed { get; set; }
        public string matchesWon { get; set; }
        public string matchesLost { get; set; }
        public string matchesTied { get; set; }
        public string matchesSurvived { get; set; }
        public string Arrests { get; set; }
        public string Captures { get; set; }
        public string winRate { get; set; }
        public string survivalRate { get; set; }
        public string timePerMatch { get; set; }
        public string arrestsPerMatch { get; set; }
        public string capturesPerMatch { get; set; }
        public string status { get; set; }
        public string[] reputation = { "General" };

        WebClient client = new WebClient();

        public bool IsRealPlayer(string userName)
        {
            try
            {
                string json = client.DownloadString("http://api.intruder-db.info/agents?name=" + $"{userName}");
                JObject jObject = JObject.Parse(json);
                JToken source = jObject["data"];

                if (source.HasValues == true && source.HasValues != false) //just in case
                {
                    setAgentInfo(json);//If true, download all player data.
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Net.WebException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error occured while downloading agent information json from Intruder-DB. Exception: {e.InnerException.ToString()}");
                Task.Delay(3500);
            }
            return false;
        }

        public void getAgentReputation()
        {
            string json = client.DownloadString("http://api.intruder-db.info/agents/" + $"{ID}" + "/ratings"); //Downloads reputation json
            JObject jObject = JObject.Parse(json);
            JToken source = jObject;

            reputation[0] = source["positive"].ToString() + "," + source["negative"].ToString(); //General Reputation
        }


        private void setAgentInfo(string json) //Set all new data to the corresponding vars.
        {
            JObject jObject = JObject.Parse(json);
            JToken source = jObject["data"][0];

            var playerData = 0;

            ID = source["id"].ToString();
            Name = source["name"].ToString();
            Role = source["role"].ToString();
            avatarURL = source["avatarURL"].ToString();

            playerData = int.Parse(source["xp"].ToString());
            XP = playerData.ToString("#,##0");

            timePlayed = source["timePlayed"].ToString();
            Console.WriteLine(timePlayed);
            TimeSpan convertTime = TimeSpan.FromSeconds(int.Parse(timePlayed));
            timePlayed = convertTime.TotalHours.ToString("0.0");

            playerData = int.Parse(source["matchesPlayed"].ToString());
            matchesPlayed = playerData.ToString("#,##0");

            playerData = int.Parse(source["matchesWon"].ToString());
            matchesWon = playerData.ToString("#,##0");

            playerData = int.Parse(source["matchesLost"].ToString());
            matchesLost = playerData.ToString("#,##0");

            playerData = int.Parse(source["matchesTied"].ToString());
            matchesTied = playerData.ToString("#,##0");

            playerData = int.Parse(source["matchesSurvived"].ToString());
            matchesSurvived = playerData.ToString("#,##0");


            playerData = int.Parse(source["arrests"].ToString());
            Arrests = playerData.ToString("#,##0");

            playerData = int.Parse(source["captures"].ToString());
            Captures = playerData.ToString("#,##0");

            winRate = source["winRate"].ToString();
            survivalRate = source["survivalRate"].ToString();
            timePerMatch = source["timePerMatch"].ToString();
            arrestsPerMatch = source["arrestsPerMatch"].ToString();
            capturesPerMatch = source["capturesPerMatch"].ToString();
            status = source["status"].ToString();
        }


    }
}
