using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //super basic singleton
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    //----------------------

    [SerializeField] private TMP_Text scoreText;

    // workshop - import audio source and audio clip

    // workshop - import game win and game lost text

    int totalTreasures;
    int collectedTreasures;

    void Start()
    {
        totalTreasures = GameObject.FindGameObjectsWithTag("treasure").Length;
        collectedTreasures = 0;
        scoreText.text = collectedTreasures + "/" + totalTreasures;
    }

    public void CollectTreasure()
    {
        //workshop - play audio
        

        collectedTreasures++;

        if(collectedTreasures>=totalTreasures)
        {
            GameWin();
        }

        scoreText.text = collectedTreasures + "/" + totalTreasures;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");

        // workshop - show game over text
    }

    public void GameWin()
    {
        Debug.Log("You Win!");

        // workshop - show game win text
    }
}

