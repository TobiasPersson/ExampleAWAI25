using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;


public class Eliza : MonoBehaviour
{
    [SerializeField] TMP_Text chatlog;
    [SerializeField] TMP_InputField input;
    string content = "Hejsan KAWAI25";

    void Start()
    {
    }


    void Update()
    {
        chatlog.text = content;
    }

    public void Send()
    {
        content += "\nYou: " + input.text;
        Response(input.text);
        input.text = "";
    }
    void Response(string msg)
    {
        string response = "";
        Match match = Regex.Match(msg, "^I feel like");
        if (match.Success)
        {
           msg = msg.Remove(0, match.Length);
           /* match.Index; //Här börjar matchingen
            match.Length; //Hur många tecken lång matchningen är*/
            response = $"Why do you feel like {msg}";
        }
        match = Regex.Match(msg, "^I want");
        if (match.Success)
        {
            msg = msg.Remove(0, match.Length + 1);
            if (response.Length > 0)
            {
                response += $" And why do you want {msg}";
            }
            else
            {
                response = $"Why do you want {msg}";
            }
                
        }
        if (msg == "Lewis Hamilton")
        {
            string[] svar = { 
                "Wow han är så cool",
            "Han är rätt så häftig",
            "Han har vunnit många gånger",
            $"Han heter {msg}",
            "Max är bättre."
            };
            response = svar[Random.Range(0,svar.Length)]; //Tar ett slumpmässigt svar från arrayn
        }
        else if (msg.Contains("Max Verstappen"))
        {
            if (msg.Contains("Jag gillar") && msg == "hej" || msg == "hej igen")
            {
                if (!msg.Contains("inte"))
                {
                    string[] ord = msg.Split(' ');
                    if (true)
                    {

                    }
                }
            }
            else
            {
                response = "Usch vilket tråkigt ämne. Vill du prata om F1 istället?! Vad tycker du om Lewis Hamilton och Max Verstappen?";

            }
                response = "Wow han är så cool! Nästan coolare än Lucas";
        }
            content += "\nEliza: " + response;

    }
}
