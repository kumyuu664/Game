using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunshooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int HandGunshellDamage = 18;
    public float shootspeed;
    public int shootCount = 12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(shootCount > 0)
            {
                shootCount -= 1;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shootspeed);

                Destroy(bullet, 8.0f);
            }
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            Invoke("Reload", 2.4f);
        }
    }


    void Reload()
    {
        shootCount = 12;
    }
}
