using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAnimation1 : MonoBehaviour
{
    private Animator animator;

    private const string key_isdemoRun = "isdemoRun";
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            this.animator.SetBool(key_isdemoRun, true);
        }
        else
        {
            this.animator.SetBool(key_isdemoRun, false);
        }
    }
}
