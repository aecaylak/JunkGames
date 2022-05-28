using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storyteller : MonoBehaviour
{
    int storyNumber = 0;
    [SerializeField] GameObject[] storyteller;
    [SerializeField] GameObject storyPanel;


    // Start is called before the first frame update
    void Start()
    { 
        storyteller[storyNumber].SetActive(true);
    }

  public void NextStoryPanel()
    {
        storyNumber += 1;
        storyteller[storyNumber-1].SetActive(false);
        storyteller[storyNumber].SetActive(true);
        if (storyteller[storyNumber] == null)
        {
            Destroy(storyPanel);
        }
        storyteller[storyNumber].SetActive(true);

    }
}
