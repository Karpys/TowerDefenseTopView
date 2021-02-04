using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> ListSlotTrans;
    public List<GameObject> ListSlot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPlace()
    {
        for(int i =0;i<ListSlot.Count;i++)
        {
            ListSlot[i].GetComponent<SlotScript>().index += 1;
            ListSlot[i].transform.parent = ListSlotTrans[ListSlot[i].GetComponent<SlotScript>().index].transform;
        }
    }
}
