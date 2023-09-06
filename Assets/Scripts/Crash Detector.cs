using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    public float loadDelay = 0.5f;
    public ParticleSystem crashEffect;
    public AudioClip crashAudio;

    public bool isCrashed = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){

            if (!isCrashed)
            {
                FindObjectOfType<PlayerController>().DisableControls();
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashAudio);
                Invoke("ReloadScene", loadDelay);
                isCrashed= true;
            }
        }
    }

    void ReloadScene(){
         SceneManager.LoadScene(0);
    }
}
