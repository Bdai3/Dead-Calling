using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireAni : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void FiringFinished()
    {
        animator.SetBool("Firing", false);
        Debug.Log("Done");
        gameObject.GetComponent<SpriteRenderer>().enabled = false;


    }
}
