using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    // Start is called before the first frame update
    public MapManager Pathing;
    public List<Transform> Path;
    void Start()
    {
        Path = Pathing.PathingEnnemy;
        transform.position = new Vector3(Path[0].transform.position.x, Path[0].transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Path.Count > 0)
        {
            if (new Vector2(Path[0].transform.position.x, Path[0].transform.position.y)!=new Vector2(transform.position.x,transform.position.y))
            {
                transform.position = Vector2.MoveTowards(transform.position, Path[0].transform.position, 0.1f);
                
            }
            else
            {
                Path.Remove(Path[0]);
            }
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, -1);
    }
}
