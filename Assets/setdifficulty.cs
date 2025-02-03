using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class setdifficulty : MonoBehaviour
{
    public Button easy, hard;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        easy.onClick.AddListener(seteasy);
        hard.onClick.AddListener(sethard);
    }

    void seteasy()
    {
        Player.GetComponent<Player>().sethealth(400);
        SceneManager.LoadScene("level1");
        Debug.Log("Playing on EASY");
    }

    void sethard()
    {
        Player.GetComponent<Player>().sethealth(100);
        SceneManager.LoadScene("level1");
        Debug.Log("Playing on HARD");
    }


}
