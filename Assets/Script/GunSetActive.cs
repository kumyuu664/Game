using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunSetActive : MonoBehaviour
{
    public GameObject Gun;

    public Enemyhp EnemyHP;
    public Exprission_Damage Exprission_damage;
    // Start is called before the first frame update
    void Start()
    {
        Gun.SetActive(false);
    }

    void Update()
    {
        if(Gun.activeSelf == true)
        {
            Exprission_damage.Shell_Damage = 11;
        }
    }

    // Update is called once per frame
    public void Gunshot()
    {
        if(Gun.activeSelf == true)
        {
            EnemyHP.GunDamage();
        }
    }

    public void DisplayGun()
    {
        //表示
        Gun.SetActive(true);
    }

    public void HideGun()
    {
        //非表示
        Gun.SetActive(false);
    }
}
