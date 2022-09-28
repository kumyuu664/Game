using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitpoint : MonoBehaviour
{
    public EnemyShellDamage enemyshelldamage;
    [SerializeField] public float hp;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Image;
    
    void Start()
    {
        Panel.SetActive(false);
    }

    void Update()
    {
        if (hp <= 0)
        {
            Panel.SetActive(true);
        }

        Image.GetComponent<Image>().fillAmount = hp / 100;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemyshell")
        {
            hp -= enemyshelldamage.EnemyshellDamage;
        }
    }

}
