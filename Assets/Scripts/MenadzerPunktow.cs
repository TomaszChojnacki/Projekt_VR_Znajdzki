using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenadzerPunktow : MonoBehaviour
{
    public int punkty;
    public TextMeshProUGUI punktyNaInterfejsie;

    private void Start()
    {
        punktyNaInterfejsie.text = punkty.ToString();
    }

    private void Update()
    {
        Wygral();
    }
    public void DodajPunkty()
    {
        punkty++;
        punktyNaInterfejsie.text = punkty.ToString();
    }

    public void Wygral()
    {
        if (punkty >= 15)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }
}
