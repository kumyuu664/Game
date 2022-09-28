using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Animation : MonoBehaviour
{
    [SerializeField] private Door_Judgement Door_judgement;
    private Animator animator;

    bool open_animation;

    private const string key_isDoorOpen = "isDoorOpen";
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

    public void isDoor_Animation()
    {
        if(!open_animation && Door_judgement.open_judgement)
        {
            this.animator.SetBool(key_isDoorOpen, true);
            open_animation = true;
        }
    }
}
