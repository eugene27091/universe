using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color.a == 255f && transform.position.x >-14)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
    }
}
