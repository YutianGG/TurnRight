using UnityEngine;

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

    private bool up;
    private bool down;
    private bool right;
    private bool left;

    public float x;
    public float y;
    private float x1;
    private float y1;
    private float x2;
    private float y2;
    private Vector3 velocity = Vector3.zero;


    public void Start()
    {
        offset.x = gameObject.transform.position.x ;
    }
    public void Update()
    {
        Touch();
        Up();
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
            Click();
        }
        else if (x > 0 && y > 0) //第一象限
        {
            if (x > y)
            {
                Right();
            }
            else
            {
                up = true;
            }
        }
        else if (x < 0 && y > 0) //第二象限
        {
            x = x * -1;
            if (x > y)
            {
                Left();
            }
            else
            {
                up = true;
            }
        }
        else if (x < 0 && y < 0) //第三象限
        {
            if (x > y)
            {
                Down();
            }
            else
            {
                Left();
            }
        }
        else if (x > 0 && y < 0) //第四象限
        {
            y = y * -1;
            if (x > y)
            {
                Right();
            }
            else
            {
                Down();
            }
        }
        
    }

    /// <summary>
    /// 移動方向
    /// </summary>
    public void Click()
    {
        for(int i = 1; i<= 90; i++)
        {
            transform.Rotate(0, 0, -1);
            
        }
        
    }
    public void Up()
    {
        if (up == true)
        {
            offset.y += 0.8f;
            transform.position = Vector3.SmoothDamp(transform.position, offset, ref velocity, 0.5f);
            
        }
        
           
    }
    public void Down()
    {
        print("d");
    }
    public void Right()
    {
        print("r");
    }
    public void Left()
    {
        print("l");
    }

    private void OnDrawGizmos()
    {
       
        // 圖示 顏色
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        // 圖示 繪製球體(中心點，半徑)
        Gizmos.DrawCube(offset, radius);
    }

}
