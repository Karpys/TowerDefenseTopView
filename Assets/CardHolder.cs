using System.Collections;
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



    public Vector3 startPos;
    public Vector3 PostoGo;
    public bool MouseOn;
    public float UpDiff;
    public float speed;
    void Start()
    {
        Image.sprite = stats.Image;
        Nom.text = stats.name;
        Description.text = stats.description;
        Cost.text = stats.cost.ToString();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, PostoGo, speed);
        if(Input.GetMouseButton(0) && MouseOn)
        {
            transform.position = Mouse.MousePosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            PostoGo = new Vector3(startPos.x, startPos.y + UpDiff, startPos.z);
            MouseOn = true;
            Descri.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            PostoGo = startPos;
            MouseOn = false;
            Descri.SetActive(false);
        }
    }
}
