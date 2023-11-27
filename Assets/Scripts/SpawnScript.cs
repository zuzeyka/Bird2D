using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnObjects;

    private float timer = 5f;
    private float pipeCountDown;

    private void Start()
    {
        pipeCountDown = timer;
    }

    // Update is called once per frame
    void Update()
    {
        pipeCountDown -= Time.deltaTime;
        if (pipeCountDown <= 0)
        {
            GameObject randomPrefab = GetRandomPrefab(spawnObjects);
            if (randomPrefab != null)
            {
                GameObject pipesInstance =
                    Instantiate(randomPrefab,
                    this.transform.position +
                    Vector3.up * Random.Range(-2.4f, 3f),
                    Quaternion.identity);
            }
            timer = Random.Range(2f, 9f);
            Debug.Log(timer.ToString());
            pipeCountDown = timer;
        }
    }
    static GameObject GetRandomPrefab(GameObject[] prefabs)
    {
        if (prefabs.Length == 0)
        {
            return null;
        }

        int randomIndex = Random.Range(0, prefabs.Length - 1);

        return prefabs[randomIndex];
    }
}
