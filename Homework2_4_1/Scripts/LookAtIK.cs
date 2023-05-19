using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class LookAtIK : MonoBehaviour
{
    protected Animator animator;

    public bool ikActive = false;
    public Transform lookObj = null;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK()
    {
        if (animator)
        {
            if (ikActive)
            {
                if (lookObj != null)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookObj.position);
                }
            }
            else
            {
                animator.SetLookAtWeight(0);
            }
        }
    }
}