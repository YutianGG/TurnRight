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

    private Black BL;
    public GameObject black;
    private void Start()
    {
        SetButton();
    }

    private void SetButton()
    {
       
        Play.onClick.AddListener(PLAY);
        Home.onClick.AddListener(HOME);
        Skin.onClick.AddListener(SKIN);
        Share.onClick.AddListener(SHARE);
        Setting.onClick.AddListener(SETTING);

    }
    private void Shot()
    {
        black.SetActive(false);
    }
    private void PLAY()
    {
      
        SceneManager.LoadScene("LEVEL");
    }
    private void HOME()
    {
        SceneManager.LoadScene("HOME");
    }
    private void SKIN()
    {
        SceneManager.LoadScene("Skin");
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
        set.SetActive(false);
    }
    private void INFORNATION()
    {

    }

}
