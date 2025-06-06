using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public GameObject[] mapPrefabs;
    public Transform spawnPoint;
    public float distance = 0.0f;
    public List<GameObject> spawnedMaps = new List<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {
            spawnPoint = other.transform;
            SpawnRandomMap();
        }
    }

    void SpawnRandomMap()
    {
        Vector3 spawnPos = spawnPoint.position + spawnPoint.forward * distance;

        int randomIndex = Random.Range(0, mapPrefabs.Length); // 0〜2の中でランダム
        GameObject map = Instantiate(mapPrefabs[randomIndex], spawnPos, spawnPoint.rotation);
        spawnedMaps.Add(map);

        Debug.Log(spawnPoint.position);

        if (spawnedMaps.Count > 3)
        {
            Destroy(spawnedMaps[0]);       // 一番古いMAPを削除
            spawnedMaps.RemoveAt(0);
        }
    }
}
