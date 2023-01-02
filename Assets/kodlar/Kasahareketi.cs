using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kasahareketi : MonoBehaviour
{
    public AudioSource siseAlma;
    public float hiz;
    public Transform Sise;
    int puan;
    public TextMeshProUGUI puanYazisi;


    void Update()
    {
        puanYazisi.text = "Puan : " + puan;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);

        }
    }

    void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-7f, 7f);

        if(temas.gameObject.tag == "Sise")
        {
            Sise.position = new Vector3(rastgele, 6f, 0f);
            puan += 10;
            siseAlma.Play();
        }

    }

}
