using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    Player player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void OnClickPlayButton()
    {
        SceneManager.LoadScene("SongSelect");
        //Player.isEditMode = false;
    }
}
