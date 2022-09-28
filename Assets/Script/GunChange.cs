using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChange : MonoBehaviour
{
    public ItemGet Itemget;
    [SerializeField] private HandGunSetActive HandGunSetactive;
    [SerializeField] private GunSetActive GunSetactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(Itemget.HaveGun1 != "none" && Itemget.HaveGun2 != "none")
            {
                Itemget.HideTakeGun1();

                switch (Itemget.HaveGun1)
                {
                    case "gun":
                            GunSetactive.DisplayGun();
                            break;
                    case "handGun":
                            HandGunSetactive.DisplayHandGun();
                            break;    
                    default:
                            Debug.Log("default");
                            break;   
                }
            }
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(Itemget.HaveGun1 != "none" && Itemget.HaveGun2 != "none")
            {
                Itemget.HideTakeGun0();

                switch (Itemget.HaveGun2)
                {
                    case "gun":
                            GunSetactive.DisplayGun();
                            break;
                    case "handGun":
                            HandGunSetactive.DisplayHandGun();
                            break;
                    default:
                            Debug.Log("default");
                            break;   
                }
            }
        }
    }
}
