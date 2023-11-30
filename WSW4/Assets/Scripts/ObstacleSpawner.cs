using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour, Spawner
{
    [SerializeField] private GameObject obs;
    public GameObject Spawn(GameObject caller)
    {
        GameObject obstacle = Instantiate(obs);
        obstacle.transform.SetParent(caller.transform);
        obstacle.transform.parent = caller.transform;
        // Assuming the obs origin is centered, we need half its height, and half the ground's height to position it on the ground.

        float yPos = caller.transform.localScale.y / 2 + obstacle.transform.localScale.y / 2;
        float xPos = UnityEngine.Random.Range(-5, 5) + caller.transform.localScale.x / obstacle.transform.localScale.x;
        float zPos = UnityEngine.Random.Range(-5, 5) + caller.transform.localScale.z/ obstacle.transform.localScale.z;

        obstacle.transform.position = new Vector3(xPos, yPos, zPos);
        return obstacle;
    }
}
