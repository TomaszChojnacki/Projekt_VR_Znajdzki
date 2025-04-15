using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZbieranieKaczek : MonoBehaviour
{
    private bool czyZebrano = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (!czyZebrano)
        {
            czyZebrano = true; 
            FindObjectOfType<MenadzerPunktow>().DodajPunkty();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(UsunObiektPoCzasie(5f));
    }

    private IEnumerator UsunObiektPoCzasie(float czas)
    {
        yield return new WaitForSeconds(czas); // Poczekaj okreœlony czas
        Destroy(gameObject); 
    }

}
