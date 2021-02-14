using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpawnEnnemies;
    public MapManager Map;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            GameObject En = Instantiate(SpawnEnnemies, transform.position, transform.rotation);
            En.GetComponent<Ennemy>().Pathing = Map;
            Map.ListEnnemy.Add(En);
        }
    }
}
