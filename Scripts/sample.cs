using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sample : MonoBehaviour
{
    public GameManager manager;
    private void OnMouseDown()
    {
        manager.Action(GameObject.Find(this.name));
    }
    void OnMouseEnter()
    {
        GetComponent<Image>().color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<Image>().color = Color.white;
    }

}
