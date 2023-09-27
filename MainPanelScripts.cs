using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPanelScripts : MonoBehaviour
{
    [SerializeField]
    GameObject MainPanel;
    public void SecondSceneOpen()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
