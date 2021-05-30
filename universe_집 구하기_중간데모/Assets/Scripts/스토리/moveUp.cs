using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp: MonoBehaviour
{
    void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color.a==255f && transform.position.y < 5)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
}
