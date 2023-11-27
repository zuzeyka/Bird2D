using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBuilding : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Here");
        if (collision != null && collision.gameObject.name != "Float")
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
