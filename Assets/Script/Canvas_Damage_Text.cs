using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Damage_Text : MonoBehaviour
{
    public Exprission_Damage Exprission_damage;

    public float Destroy_Time = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Find_Damage_Text()
    {
        Destroy(Exprission_damage.text_clone, Destroy_Time);
    }
}
