using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> SpawnEnnemies;
    public MapManager Map;
    public Spawn Spawner;
    public int IndexSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
        }
    }
}
