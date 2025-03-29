using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Reload");
        }
        
    }
}
