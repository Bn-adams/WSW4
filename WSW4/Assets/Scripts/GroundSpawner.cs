using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour, Spawner
{
    private int numSpawns;
    [SerializeField] private GameObject groundPrefab;
    public Spawner spawner;
    private void Awake()
    {
        spawner = GetComponent<ObstacleSpawner>();
    }
    public GameObject Spawn(GameObject caller)
    {
        var newGround = Instantiate(groundPrefab);
        newGround.transform.position += new Vector3(0, 0, numSpawns * newGround.transform.localScale.z);
        newGround.transform.parent = transform;

        numSpawns++;

        spawner.Spawn(newGround);




        return groundPrefab;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
