using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : Interactinator
{
    Animator animator;
    AudioSource audio;

    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    protected override void Action(PlayerController player)
    {
        bool isOpen = animator.GetBool("Open");
        animator.SetBool("Open", !isOpen);
        audio.Stop();
        audio.pitch = isOpen ? -1f: 1f;
        audio.timeSamples = isOpen ? audio.clip.samples - 1 : 0;
        audio.Play();
    }
}
