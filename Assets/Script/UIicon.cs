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
    private void Start()
    {
       
    }
    private void Update()
    {
        SetButton();
    }
    private void SetButton()
    {
       
        Play.onClick.AddListener(PLAY);
       /* Home.onClick.AddListener(HOME);
        Skin.onClick.AddListener(SKIN);
        Share.onClick.AddListener(SHARE);
        Setting.onClick.AddListener(SETTING);*/
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
