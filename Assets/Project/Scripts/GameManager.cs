using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CircuitStream { 
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
        [SerializeField] private AudioSource sfxAudio;
        [SerializeField] private AudioClip pickupAudioClip;

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
            //play audio
            sfxAudio.PlayOneShot(pickupAudioClip);

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
        }

        public void GameWin()
        {
            Debug.Log("You Win!");
        }
    }
}
