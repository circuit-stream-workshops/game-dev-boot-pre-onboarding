using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CircuitStream
{
    public class PlayerLogic : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("treasure"))
            {
                //collect treasure
                Destroy(other.gameObject);
                GameManager.Instance.CollectTreasure();
            }
            else if (other.CompareTag("ghost"))
            {
                //game over
                GameManager.Instance.GameOver();
            }
        }
    }
}