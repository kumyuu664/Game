using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exprission_Damage : MonoBehaviour
{
    public GameObject Damage_text;
    public GameObject canvas;
    public GameObject text_clone;

    private TextMeshProUGUI Damage;

    private bool isText = false;

    public int Damage_Done;
    public int Shell_Damage;

    public Canvas_Damage_Text Canvas_Damage_text;

    // Start is called before the first frame update
    void Start()
    {
        Damage_Done = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isText)
        {
            Canvas_Damage_text.Find_Damage_Text();
            Invoke("Text_Bool", Canvas_Damage_text.Destroy_Time);
        }
    }

    public void Instantiate_Damage()
    {
        if(!isText)
        {
            Damage_Done += Shell_Damage;

            text_clone = Instantiate(Damage_text, transform.position, transform.rotation * Quaternion.Euler(0f, 180f, 0f)) as GameObject;
            text_clone.transform.SetParent(canvas.transform);
            
            this.Damage = GameObject.Find("Damage_Text(Clone)").GetComponent<TextMeshProUGUI>();
            Damage.text = Damage_Done.ToString();

            isText = true;
        }
    }

    void Text_Bool()
    {
        isText = false;
    }


    public void Add_Damage_Text()
    {
        if(isText)
        {
            Damage_Done += Shell_Damage;
            Canvas_Damage_text.Destroy_Time += 0.5f;
        }
    }
}
