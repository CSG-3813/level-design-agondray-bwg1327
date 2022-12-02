using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTrig1 : MonoBehaviour
{
    [SerializeField] private string animHappen = "behind";
    Animator anim;
    AudioSource audioSource;
    AudioClip audioClip;
    bool first = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        Debug.Log(audioSource);
        audioClip = audioSource.clip;
        Debug.Log(audioClip);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animHappen, true);
            if (first == true)
            {
                playAudio();
                first = false;
            }
            
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animHappen, false);
        }
    }


    public void playAudio()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
