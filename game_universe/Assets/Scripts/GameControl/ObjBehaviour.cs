// 방안에서 상호작용 가능한 각 오브젝트에 적용
using UnityEngine;

public class ObjBehaviour : MonoBehaviour
{
    [SerializeField] Texture2D cursorArrow;
    [SerializeField] Texture2D cursorSearch;
    [SerializeField] GameObject blocker1;
    [SerializeField] GameObject blocker2;

    public GameManager manager;
    private void OnMouseDown()
    {
        life.remain--;
        life1.remain--;
        contract5_life.remain--;
        contract5_paperlife.remain--;

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
        if (blocker1 != null && blocker1.activeSelf == true)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            Cursor.visible = false;
        }
        else if (blocker2 != null && blocker2.activeSelf == true)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            Cursor.visible = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = true;
            Cursor.visible = true;
        }
    }

}
