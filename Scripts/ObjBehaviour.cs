// ��ȿ��� ��ȣ�ۿ� ������ �� ������Ʈ�� ����
using UnityEngine;

public class ObjBehaviour: MonoBehaviour
{
    [SerializeField] Texture2D cursorArrow;
    [SerializeField] Texture2D cursorSearch;
    [SerializeField] GameObject blocker;

    public GameManager manager;
    private void OnMouseDown()
    {
        manager.Action(GameObject.Find(this.name));
    }
    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorSearch, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }


    private void Update()
    {
        if (blocker.activeSelf == true) GetComponent<BoxCollider2D>().enabled = false;
        else GetComponent<BoxCollider2D>().enabled = true;
    }

}
