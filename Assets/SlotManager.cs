using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> ListSlotTrans;
    public List<GameObject> ListSlot;
    public Tower TowerRef;
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


    public void Replace(int id)
    {
        foreach(GameObject Slot in ListSlot)
        {
            if(Slot.GetComponent<SlotScript>().index>id)
            {
                Slot.GetComponent<SlotScript>().index -= 1;
            }
        }
    }

    public void DeleteSlot(GameObject Slot)
    {
        TowerRef.nbrSlot += 1;
        ListSlot.Remove(Slot);
        Destroy(Slot.gameObject);
    }
}
