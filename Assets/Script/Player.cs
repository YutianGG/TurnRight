﻿using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度")]
    public float speed = 10.5f;
    [Header("點擊距離")]
    public float push = 0.15f;
    [Header("玩家物件")]
    public GameObject target;
    [Header("判斷器大小")]
    public Vector2 radius;
    [Header("判斷器位置")]
    public Vector3 offset;
    public float roset;  
    [Header("上個位置紀錄")]
    public Vector3 reset;
    public float reroset;
    [Header("錯誤音效")]
    public AudioClip soundWrong;

    private AudioSource aud;

    [Header("方向判斷")]
    private bool click;

    [Header("觸控位置紀錄")]
    public float x;
    public float y;
    private float x1;
    private float y1;
    private float x2;
    private float y2;

    private int i = 0;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    public void Start()
    {
        
        offset.x = gameObject.transform.position.x;
        offset.y = gameObject.transform.position.y;
        offset.z = gameObject.transform.position.z;
        reset = offset;
   
        roset = gameObject.transform.rotation.x;
        reroset = roset;
    }
    public void Update()
    {
        Touch();
        Click();
        Move();
    }

    /// <summary>
    /// 觸控位置
    /// </summary>
    private void Touch()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            x1 = Input.mousePosition.x;
            y1 = Input.mousePosition.y;
            
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            x2 = Input.mousePosition.x;
            y2 = Input.mousePosition.y;
            x = x2 - x1;
            y = y2 - y1;
            TouchJunge(); //判斷觸控方向
        }

    }

    /// <summary>
    /// 觸控方向
    /// </summary>
    private void TouchJunge()
    {
        if (x == 0 && y == 0) // 原點
        {
            click = true;
        }
        else if (x > 0 && y > 0) //第一象限
        {
            if (x > y)
            {
                reset = offset;
                offset.x += 0.8f;
            }
            else
            {
                reset = offset;
                offset.y += 0.8f;
            }
        }
        else if (x < 0 && y > 0) //第二象限
        {
            x = x * -1;
            if (x > y)
            {
                reset = offset;
                offset.x -= 0.8f;
            }
            else
            {
                reset = offset;
                offset.y += 0.8f;
            }
        }
        else if (x < 0 && y < 0) //第三象限
        {
            if (x > y)
            {
                reset = offset;
                offset.y -= 0.8f;
            }
            else
            {
                reset = offset;
                offset.x -= 0.8f;
            }
        }
        else if (x > 0 && y < 0) //第四象限
        {
            y = y * -1;
            if (x > y)
            {
                reset = offset;
                offset.x += 0.8f;
            }
            else
            {
                reset = offset;
                offset.y -= 0.8f;
            }
        }
        
    }

    /// <summary>
    /// 移動方向
    /// </summary>
    public void Click()
    {
        if(click == true && i != 45)
        {
            transform.Rotate(0, 0, -2);
            i++;
        }
        else
        {
            click = false;
            i = 0;
        }
        
    }
    public void Move()
    {
        transform.position = Vector3.Lerp(transform.position, offset, 0.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Wall")
        {
            if(click == true)
            {
                transform.Rotate(0, 0, 2*i);
                click = false;
                i = 0;
                
            }
            //aud.PlayOneShot(soundWrong);
            else offset = reset;

        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "Win")
        {
            
        }
    }

}
