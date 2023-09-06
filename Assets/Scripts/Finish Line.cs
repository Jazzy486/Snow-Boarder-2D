using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
       public float loadDelay = 1f;
       public ParticleSystem finishEffect;

   void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Player")
            {
                finishEffect.Play();
                GetComponent<AudioSource>().Play();
                Invoke("ReloadScene", loadDelay);
            }
        }
     void ReloadScene(){
         SceneManager.LoadScene(0);
    }

    
}
