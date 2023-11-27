using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeScript : MonoBehaviour
{
    [SerializeField]
    private float pipeSpeed = 1.5f;
    private void Update()
    {
        this.transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
    }

}
