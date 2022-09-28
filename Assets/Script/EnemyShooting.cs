using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private float shotSpeed;
    public int ShotCount = 7;
    private float shotInterval;
    public int Count;
    private bool attack = false;
    private float dis;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(transform.position, player.transform.position);

        if (dis < 30f)
        {
            attack = true;
        }
        else
        {
            attack = false;
        }

        Count += 1;

        if (Count % 50 == 0 && attack && ShotCount > 0)
        {
            ShotCount -= 1;
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);
            Destroy(bullet, 3.0f);
        }

        if (ShotCount == 0)
        {
            shotInterval += 1;
            if (shotInterval % 180 == 0)
            {
                ShotCount = 7;
            }
        }
    }
}
