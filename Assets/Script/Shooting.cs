using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;
    public int shellDamage = 11;
    public ParticleSystem muzzleFlash;
    private int Reload_ammo;
    [SerializeField] private Item_Bag Item_bag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            shotInterval += 1;

            if (shotInterval % 18 == 0 && shotCount > 0)
            {
                //射撃エフェクト
                muzzleFlash.Play();
                shotCount -= 1;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから5秒後に銃弾のオブジェクトを破壊する

                Destroy(bullet, 8.0f);
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Invoke("Reload", 3.0f);
        }
    }

    //リロードする
    void Reload()
    {
        Reload_ammo = 30 - shotCount;

        if(Reload_ammo < Item_bag.Have_Gun_ammo)
        {
            shotCount += Reload_ammo;
            Item_bag.Have_Gun_ammo -= Reload_ammo;
        }
        else if(Reload_ammo >= Item_bag.Have_Gun_ammo)
        {
            shotCount += Item_bag.Have_Gun_ammo;
            Item_bag.Have_Gun_ammo = 0;
        }
    }
}
