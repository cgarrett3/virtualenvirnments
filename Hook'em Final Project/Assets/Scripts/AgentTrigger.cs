using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentTrigger : MonoBehaviour
{
    [SerializeField] private Animator AgentAnimation;
    AudioSource audioSource;



    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AgentAnimation.SetBool("greetPlayer", true);
            //audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AgentAnimation.SetBool("greetPlayer", false);
        }
    }

}
