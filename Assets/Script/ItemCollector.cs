using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coins=0;
    [SerializeField]private Text CherriesText;
    [SerializeField] private AudioSource collectsoundeffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cheery")) 
        {
            collectsoundeffect.Play();
            Destroy(collision.gameObject);
            coins++;
            CherriesText.text = "Coins: " + coins;
        }
    }
}
