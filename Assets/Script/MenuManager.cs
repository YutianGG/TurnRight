using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.GetInt("Level");
        PlayerPrefs.GetInt("Star");
    }
    private void Update()
    {
        SetStar();
        SetLevel();
    }

    private void SetStar()
    {
        
    }
    private void SetLevel()
    {
        
    }
    
}
