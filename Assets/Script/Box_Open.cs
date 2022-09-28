using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Open : MonoBehaviour
{
    private Animator animator;
    bool open_animation;

    private const string key_isOpen = "isOpen";
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        open_animation = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Box_Open_Animation()
    {
        if(!open_animation)
        {
            this.animator.SetBool(key_isOpen, true);
            open_animation = true;
        }

        if(open_animation)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                this.animator.SetBool(key_isOpen, false);
                open_animation = false;
            }
        }  
    }
}
