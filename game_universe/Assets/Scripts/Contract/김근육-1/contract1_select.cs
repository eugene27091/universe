using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contract1_select : MonoBehaviour
{
    [SerializeField] Texture2D cursorArrow;
    [SerializeField] Text talkText;
    [SerializeField] GameObject textBox;
    
    // Start is called before the first frame update
    void Start()
    {
        talkText.text = "계약할까?";
        textBox.SetActive(true);
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}
