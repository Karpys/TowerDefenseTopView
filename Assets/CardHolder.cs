﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class CardHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public CardStats stats;
    public Image Image;
    public TextMeshProUGUI Nom;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI Cost;
    public GameObject Descri;
    public InventoryCard inventory;



    public Vector3 startPos;
    public Vector3 PostoGo;
    public bool MouseOn;
    public float UpDiff;
    public float speed;
    public int id;
    public bool attach;
    public bool CanPick;
    void Start()
    {
        Image.sprite = stats.Image;
        Nom.text = stats.name;
        Description.text = stats.description;
        Cost.text = stats.cost.ToString();
        startPos = transform.position;
        PostoGo = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, PostoGo, speed);
        /*if (Input.GetMouseButtonUp(0) && MouseOn)
        {
            inventory.PlaceEnd(id, this.gameObject);
            GameManager.CardInHand = false;
            GameManager.CardHand = null;
        }

        if (Input.GetMouseButtonDown(0) && MouseOn && GameManager.CardHand==this.gameObject)
        {
            inventory.Replace(id);
        }

        if (Input.GetMouseButton(0) && MouseOn && GameManager.CardHand == this.gameObject)
        {
            
            transform.position = Mouse.MousePosition;
            GameManager.CardInHand = true;
        }*/

        if(CanPick && Input.GetMouseButtonDown(0))
        {
            if(attach)
            {
                inventory.PlaceEnd(id, this.gameObject);
                GameManager.CardInHand = false;
                GameManager.CardHand = null;
                attach = false;
            }else
            {
                inventory.Replace(id);
                GameManager.CardHand = this.gameObject;
                GameManager.CardInHand = true;
                attach = true;
            }
        }

        if(attach)
        {
            transform.position = Mouse.MousePosition;
            GameManager.CardInHand = true;
        }

        if(attach && Input.GetKeyDown(KeyCode.S))
        {
            GameManager.CardHand = null;
            GameManager.CardInHand = false;
            Destroy(gameObject);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if(collision.CompareTag("Mouse") && GameManager.CardInHand==false)
        {
            
            MouseOn = true;
            GameManager.CardHand = this.gameObject;
            
        }*/
        if(GameManager.CardInHand==false)
        {
            PostoGo = new Vector3(startPos.x, startPos.y + UpDiff, startPos.z);
            Descri.SetActive(true);
            CanPick = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        /* if(collision.CompareTag("Mouse"))
         {
             PostoGo = startPos;
             MouseOn = false;
             GameManager.CardHand = null;
             
         }*/
        if(GameManager.CardInHand == false)
        {
            Descri.SetActive(false);
            PostoGo = startPos;
            CanPick = false;
        }
    }
}
