using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    // Start is called before the first frame update
    public MapManager Pathing;
    public List<GameObject> Path;
    public bool Dummy;
    public float life;
    public float speed;
    public bool Gelee;
    void Start()
    {
        if(!Dummy)
        {
        Path = new List<GameObject>(Pathing.PathingEnnemy);
        transform.position = new Vector3(Path[0].transform.position.x, Path[0].transform.position.y, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!Dummy)
        {

        if (Path.Count > 0)
        {
            if (new Vector2(Path[0].transform.position.x, Path[0].transform.position.y)!=new Vector2(transform.position.x,transform.position.y))
            {
                transform.position = Vector2.MoveTowards(transform.position, Path[0].transform.position, speed * Time.deltaTime);
                
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, Path[0].GetComponent<TransfromScript>().Turn));
                Path.Remove(Path[0]);
            }
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, -1);

           
        }
        if (life <= 0)
        {
            Clear();
        }
    }

    public void Clear()
    {
        Pathing.ListEnnemy.Remove(this.gameObject);
        Destroy(gameObject);
    }
}
