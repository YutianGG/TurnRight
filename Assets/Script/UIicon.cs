using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIicon : MonoBehaviour
{
    public Button Play;
    public Button Home;
    public Button Setting;
    public Button Return;
    public Button Share;
    public Button Skin;
    public Button Continue;
    public Button Information;

    public GameObject set;

    private void Awake()
    {
        // 取得按鈕

        Information = GameObject.Find("Information").GetComponent<Button>();
        Continue = GameObject.Find("Continue").GetComponent<Button>();
        Setting = GameObject.Find("Setting").GetComponent<Button>();
        Return = GameObject.Find("Return").GetComponent<Button>();
        Share = GameObject.Find("Share").GetComponent<Button>();
        Skin = GameObject.Find("Skin").GetComponent<Button>();
        Home = GameObject.Find("Home").GetComponent<Button>();
        Play = GameObject.Find("Play").GetComponent<Button>();
        SetButton();
    }
    private void SetButton()
    {
        //讀取按鈕
        Play.onClick.AddListener(PLAY);
        Home.onClick.AddListener(HOME);
        Skin.onClick.AddListener(SKIN);
        Share.onClick.AddListener(SHARE);
        Setting.onClick.AddListener(SETTING);
    }
    private void PLAY()
    {
        print("go");
    }
    private void HOME()
    {
        
    }
    private void SKIN()
    {

    }
    private void SHARE()
    {

    }
    private void RETURN()
    {
        
    }
    private void SETTING()
    {
        set.SetActive(true);
    }
    private void CONTINUE()
    {

    }
    private void INFORNATION()
    {

    }

}
