using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Sise : MonoBehaviour
{
    public TextMeshProUGUI canYazisi,bitisYazisi;
    public Transform sise2;
    int can = 3;
    public AudioSource siseDusurme;

     void Start()
    {
        Debug.Log("hello ali");
    }

    void Update()
    {
        canYazisi.text = "Can : " + can;
        if(can == 0)
        {
            bitisYazisi.text = "Oyun Bitti! \n Tekrar Oynamak Ýçin Bir Tuþa Basýn";
            Time.timeScale = 0;
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;

                 
                
            }

        }
        
    }

    void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-7f, 7f);
        if (temas.gameObject.tag == "Zemin")
        {

            sise2.position = new Vector3(rastgele, 6f, 0f);
            can--;
            siseDusurme.Play();


        }

    }

}
