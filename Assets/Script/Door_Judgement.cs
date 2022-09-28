using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Judgement : MonoBehaviour
{
    public bool open_judgement;
    // Start is called before the first frame update
    void Start()
    {
        open_judgement = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            open_judgement = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            open_judgement = false;
        }
    }
}
