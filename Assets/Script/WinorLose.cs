using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinorLose : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Victory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel.activeSelf == true)
        {
            GetComponent<FPSController>().enabled = false;
            GetComponent<Playerjump>().enabled = false;
            Victory.SetActive(false);
        }

        if (Victory.activeSelf == true)
        {
            GetComponent<FPSController>().enabled = false;
            GetComponent<Playerjump>().enabled = false;
            Panel.SetActive(false);
        }
    }
}
