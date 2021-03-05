using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public MapManager Map;
    public Spawn Spawner;
    public int IndexSpawn;
    public List<GameObject> ListEnSpawn;
    public List<float> TimeBetweenSpawn;
    public int MaxId;
    void Start()
    {
        CreateWave();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateWave()
    {
        for(int i=0;i<Spawner.spawn.Count;i++)
        {
            MaxId+=Spawner.spawn[i].Nbr;
        }
        MaxId += Spawner.spawn.Count;
        int ResetLoop = 0;
        int ActualSpawner = 0;
        for(int j=0;j<MaxId;j++)
        {
            if(ResetLoop!=Spawner.spawn[ActualSpawner].Nbr)
            {
                ListEnSpawn.Add(Spawner.spawn[ActualSpawner].En);
                TimeBetweenSpawn.Add(Spawner.spawn[ActualSpawner].TimeBtw);
                ResetLoop += 1;
            }else
            {
                ResetLoop = 0;
                ActualSpawner += 1;
            }
        }
        Debug.Log(MaxId);
    }
}
