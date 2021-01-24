using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCard : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> ListPlace;
    public List<GameObject> ListCardInst;
    public List<GameObject> ListCard;
    void Start()
    {
        PlaceCardInit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceCardInit()
    {
        int id = 0;
        foreach (var i in ListCardInst)
        {
            GameObject Card = Instantiate(i, ListPlace[id].transform.position, transform.rotation);
            Card.GetComponent<CardHolder>().inventory = this;
            Card.GetComponent<CardHolder>().id = id;
            ListCard.Add(Card);
            id += 1;
        }
    }

    public void PlaceEnd(int id, GameObject card)
    {
        ListCard.Add(card);
        /*card.transform.position = ListPlace[ListCard.Count-1].transform.position;*/
        card.GetComponent<CardHolder>().startPos = ListPlace[ListCard.Count-1].transform.position;
        card.GetComponent<CardHolder>().PostoGo = ListPlace[ListCard.Count-1].transform.position;
        card.GetComponent<CardHolder>().id = ListCard.Count-1;
    }

    public void Replace(int place)
    {
        for(int i = place;i<ListCard.Count-1;i++)
        {
            Debug.Log("Count "+(i+1));
            /*ListCard[i + 1].transform.position = ListPlace[i].transform.position;*/
            ListCard[i + 1].GetComponent<CardHolder>().startPos= ListPlace[i].transform.position;
            ListCard[i + 1].GetComponent<CardHolder>().PostoGo = ListPlace[i].transform.position;
            ListCard[i + 1].GetComponent<CardHolder>().id = i;
        }
        ListCard.Remove(ListCard[place]);
    }
}

