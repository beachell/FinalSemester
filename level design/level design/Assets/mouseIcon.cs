using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseIcon : MonoBehaviour
{//this is from unity 
     public Texture2D cursorTexture;

     private void Start()
     {
          Cursor.visible = false;
     }

     private void Update()
     {
          Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          transform.position = cursorPos;
     }
}
