using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    private const string key_isRun = "isRun";
    private const string key_isWalk = "isWalk";
    private const string key_isJump = "isJump";

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            this.animator.SetBool(key_isWalk, true);
        }
        else
        {
            this.animator.SetBool(key_isWalk, false);
        }


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            this.animator.SetBool(key_isRun, true);
        }
        else
        {
            this.animator.SetBool(key_isRun, false);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            this.animator.SetBool(key_isJump, true);
        }
        else
        {
            this.animator.SetBool(key_isJump, false);
        }
    }
}
