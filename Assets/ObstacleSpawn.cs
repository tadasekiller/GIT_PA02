using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] public GameObject[] Obstacles;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Spawn()
    {
        transform.position = new Vector3(Random.Range(-1.5f, 1.5f), 0, 8);
        Instantiate(Obstacles[Mathf.RoundToInt(Random.Range(0, 4))],transform.position,transform.rotation);
    }
}
