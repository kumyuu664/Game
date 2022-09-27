using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //カーソル非表示
        Cursor.visible = false;
        //カーソルを中央に固定
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
