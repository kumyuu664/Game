using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunSetActive : MonoBehaviour
{
    [SerializeField] private GameObject Damage;

    public GameObject HandGun;

    public Enemyhp EnemyHP;
    public Exprission_Damage Exprission_damage;
    
    
    // Start is called before the first frame update
    void Start()
    {
        HandGun.SetActive(false);
    }

    void Update()
    {
        if(HandGun.activeSelf == true)
        {
            Exprission_damage.Shell_Damage = 18;
        }
    }

    // Update is called once per frame
    public void HandGunshot()
    {
        if(HandGun.activeSelf == true)
        {
            EnemyHP.HandGunDamage();
        }
    }


    public void DisplayHandGun()
    {
        //表示
        HandGun.SetActive(true);
    }


    public void HideHandGun()
    {
        //非表示
        HandGun.SetActive(false);
    }
}
