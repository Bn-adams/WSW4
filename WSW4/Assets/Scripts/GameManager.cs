using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Spawner gSpawner;
    private void SpawnGround()
    {
        GameObject newGround = gSpawner.Spawn(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        gSpawner = GameObject.FindObjectOfType<GroundSpawner>();

        for (int i = 0; i < 10; i++)
        {
            SpawnGround();

        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
