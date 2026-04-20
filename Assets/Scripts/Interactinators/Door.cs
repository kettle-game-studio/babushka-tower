using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : Interactinator
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    protected override void Action(PlayerController player)
    {
        bool isOpen = animator.GetBool("Open");
        animator.SetBool("Open", !isOpen);
    }
}
