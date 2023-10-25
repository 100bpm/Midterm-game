using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnimation : MonoBehaviour
{
    public Animator animator;
    public string enemyParameter;

    public void move()
    {
        animator.SetTrigger(enemyParameter);
    }
}
