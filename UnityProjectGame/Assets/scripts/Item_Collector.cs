using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Item_Collector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            collectionSoundEffect.Play();
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }
    }
}
