using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using TMPro;

public class LeaderBoard : MonoBehaviour
{
    int leaderboardID = 3284;
    public TextMeshProUGUI playerNames;
    public TextMeshProUGUI playerScores;

    void Start()
    {
        
    }

    public IEnumerator SubmitScoreRoutine(int scoreToUpload)
    {
        bool done = false;
        string playerID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(playerID, scoreToUpload, leaderboardID, (response) =>
           {
               if (response.success)
               {
                   Debug.Log("Successfully uploaded score");
                   done = true;
               }
               else
               {
                   Debug.Log("Failed" + response.Error);
                   done = true;
               }
           });
        yield return new WaitWhile(() => done == false);
    }

    public IEnumerator FetchTopHighScoresRoutine()
    {
        bool done = false;
        LootLockerSDKManager.GetScoreListMain(leaderboardID, 10, 0 ,(response)=>
        {
            if (response.success)
            {
                string tempPlayerNames = "Ýsim\n";
                string tempPlayerScores = "Skor\n";

                LootLockerLeaderboardMember[] members = response.items;
                for (int i = 0; i < members.Length; i++)
                {
                    tempPlayerNames += members[i].rank + ". ";
                    if (members[i].player.name != "")
                    {
                        tempPlayerNames += members[i].player.name;
                    }
                    else
                    {
                        tempPlayerNames += members[i].player.id;
                    }
                    tempPlayerScores += members[i].score + "\n";
                    tempPlayerNames += "\n";
                }
                done = true;
                playerNames.text = tempPlayerNames;
                playerScores.text = tempPlayerScores;
                           
            }
            else
            {
                Debug.Log("Failed" + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }
}
