using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Do_menu : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}