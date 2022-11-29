using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTrigger : MonoBehaviour
{

    public string animtionParamater;
    Animator anim;
    AudioSource audioSource;
    AudioClip audioClip;



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
            anim.SetBool(animtionParamater, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animtionParamater, false);
        }
    }
}
