using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public MapManager Map;
    public List<Spawn> Spawner;
    public List<GameObject> ListEnSpawn;
    public List<float> TimeBetweenSpawn;
    public int MaxId;
    public bool LaunchWave;
    public float TimerSpawn;
    void Start()
    {
        CreateWave();
    }

    // Update is called once per frame
    void Update()
    {
        if(LaunchWave)
        {
            TimerSpawn -= Time.deltaTime;

            if (TimerSpawn <= 0 && ListEnSpawn.Count != 0)
            {
                if(Spawner[0].BlendWave)
                {
                    SpawnRandom();
                }else
                {
                    SpawnEn();
                }
            }else if(ListEnSpawn.Count<=0 && Spawner.Count>1)
            {
                MaxId = 0;
                LaunchWave = false;
                TimerSpawn = 1;
                Spawner.Remove(Spawner[0]);
                CreateWave();
            }
        }
    }

    public void SpawnEn()
    {
        GameObject En = Instantiate(ListEnSpawn[0], transform.position, transform.rotation);
        En.GetComponent<Ennemy>().Pathing = Map;
        TimerSpawn = TimeBetweenSpawn[0];
        ListEnSpawn.Remove(ListEnSpawn[0]);
        TimeBetweenSpawn.Remove(TimeBetweenSpawn[0]);
    }

    public void SpawnRandom()
    {
        int rdmid = Random.Range(0, ListEnSpawn.Count);
        GameObject En = Instantiate(ListEnSpawn[rdmid], transform.position, transform.rotation);
        En.GetComponent<Ennemy>().Pathing = Map;
        TimerSpawn = TimeBetweenSpawn[rdmid];
        ListEnSpawn.Remove(ListEnSpawn[rdmid]);
        TimeBetweenSpawn.Remove(TimeBetweenSpawn[rdmid]);
    }

    public void CreateWave()
    {
        for(int i=0;i<Spawner[0].spawn.Count;i++)
        {
            MaxId+=Spawner[0].spawn[i].Nbr;
        }
        MaxId += Spawner[0].spawn.Count;
        int ResetLoop = 0;
        int ActualSpawner = 0;
        for(int j=0;j<MaxId;j++)
        {
            if(ResetLoop!=Spawner[0].spawn[ActualSpawner].Nbr)
            {
                ListEnSpawn.Add(Spawner[0].spawn[ActualSpawner].En);
                TimeBetweenSpawn.Add(Spawner[0].spawn[ActualSpawner].TimeBtw);
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
