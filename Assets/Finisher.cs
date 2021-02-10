using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finisher : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> Finish;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyFinish(GameObject Ennemy)
    {
        for(int i=0;i<Finish.Count;i++)
        {

        if(Finish[i].GetComponent<FinishHolder>().FinishType==FinishType.Gelee)
        {
            if(Ennemy)
            {
                if(Ennemy.GetComponent<Ennemy>().Gelee)
                {
                    Ennemy.GetComponent<Ennemy>().life -= 10;
                    Debug.Log("Bg Remi");
                }
            }
        }
        }
    }
    public enum FinishType
    {
        Gelee,
    }
}
