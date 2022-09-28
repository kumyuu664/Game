using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhp : MonoBehaviour
{
    public Shooting shooting;
    public HandGunshooting Handgunshooting;
    public GunSetActive GunSetactive;
    public HandGunSetActive HandGunSetactive;
    public Exprission_Damage Exprission_damage;

    [SerializeField] public int enemyhp;

    public GameObject Victory;
    
    // Start is called before the first frame update
    void Start()
    {
          Victory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhp <= 0)
        {
            Destroy(gameObject, 0.1f);
            Victory.SetActive(true);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        //弾が衝突した時
        if (collision.gameObject.tag == "shell")
        {
            GunSetactive.Gunshot();
            HandGunSetactive.HandGunshot();
            Exprission_damage.Instantiate_Damage();
            Exprission_damage.Add_Damage_Text();
        }
    }

    public void HandGunDamage()
    {
        enemyhp -= Handgunshooting.HandGunshellDamage;
    }

    public void GunDamage()
    {
        enemyhp -= shooting.shellDamage;
    }

}
