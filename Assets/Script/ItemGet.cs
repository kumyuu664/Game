using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    public GameObject Gun;
    public GameObject HandGun;
    public GameObject[] TakeGun;

    public string HaveGun1;
    public string HaveGun2;
    
    [SerializeField] private Shooting shooting;
    [SerializeField] private Item_Bag Item_bag;
    [SerializeField] private Box_Open Box_open;
    [SerializeField] private Door_Animation Door_animation;

    // Start is called before the first frame update
    void Start()
    {
        TakeGun = new GameObject[2];
        
        HaveGun1 = "none";
        HaveGun2 = "none";
    }

    // Update is called once per frame
    void Update()
    {
        //アイテムや銃を拾う
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.CompareTag("Gun"))
                {
                    //拾ったオブジェクトを破壊する
                    Destroy(hit.collider.gameObject);

                    if(HaveGun1 == "none" && HaveGun2 == "none")
                    {
                        Gun.SetActive(true);
                        TakeGun[0] = GameObject.Find("Gun");
                        HaveGun1 = "gun";
                    }

                    else if(HaveGun1 == "none" && HaveGun2 != "none")
                    {
                        HaveGun1 = "gun";
                        TakeGun[0] = transform.Find("Main Camera/Gun").gameObject;
                    }

                    else if(HaveGun1 != "none" && HaveGun2 == "none")
                    {
                        HaveGun2 = "gun";
                        TakeGun[1] = transform.Find("Main Camera/Gun").gameObject;
                    }
                }

                else if(hit.collider.CompareTag("HandGun"))
                {
                    Destroy(hit.collider.gameObject);

                    if(HaveGun1 == "none" && HaveGun2 == "none")
                    {
                        HandGun.SetActive(true);
                        TakeGun[0] = GameObject.Find("HandGun");
                        HaveGun1 = "handGun";
                    }

                    else if(HaveGun1 == "none" && HaveGun2 != "none")
                    {
                        HaveGun1 = "handGun";
                        TakeGun[0] = transform.Find("Main Camera/HandGun").gameObject;
                    }

                    else if(HaveGun1 != "none" && HaveGun2 == "none")
                    {
                        HaveGun2 = "handGun";
                        TakeGun[1] = transform.Find("Main Camera/HandGun").gameObject;
                    }
                    
                }

                if(hit.collider.CompareTag("Ammo"))
                {
                    string ammo_Name = hit.collider.gameObject.name;

                    Destroy(hit.collider.gameObject);
                    
                    if(ammo_Name == "Ammo(Clone)")
                    {
                        Item_bag.Have_Gun_ammo += 30;
                    }
                    
                }

                if(hit.collider.CompareTag("Box"))
                {
                    Box_open.Box_Open_Animation();
                }

                if(hit.collider.CompareTag("Door"))
                {
                    Door_animation.isDoor_Animation();
                }

            }
        }
    }

    public void HideTakeGun1()
    {
        TakeGun[1].SetActive(false);
    }


    public void HideTakeGun0()
    {
        TakeGun[0].SetActive(false);
    }
}
