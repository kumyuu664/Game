using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Ammo;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Gun, transform.position, Quaternion.Euler(0, 15, 90));
        Instantiate(Ammo, transform.position, Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
