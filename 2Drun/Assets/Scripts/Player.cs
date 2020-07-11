
using UnityEngine;

public class Player : MonoBehaviour
{
    //  單行註解:  2020.07.04 jayasuka
    //  說明:

    /*
     * 多行註解
     * 多行註解
     * */

    #region 欄位區域

    //命名規則
    //1.有意義的名稱
    //2.不要使用數字開頭
    //3.不要使用特殊符號，例:@#/\*空格
    //4.可以使用中文

    //欄位語法
    //修飾詞 類型  欄位名稱 = 值；
    //沒有 = 值
    //整數。浮點數 預設值 0
    //字串 預設值 ""
    //布林值 false

    //私人  private - 僅限於此類別使用 | 不會顯示 - 預設值
    //公開  public  - 所有類別皆可使用 | 會顯示

    //屬性欄位
    //標題 Header
    //提示 Tooltip
    //範圍 Range

    [Header("Speed"), Tooltip("CHR speed"), Range(1,500)]
    public int speed = 80;
    [Header("jump"), Tooltip("CHR jump"), Range(100, 500)]
    public int height = 300;
    [Header("sound"), Tooltip("sound area")]
    AudioClip soundhight;
    AudioClip soundhit;
    [Header("gold")]
    public int gold;
    [Header("hp")]
    public float hp = 950.5f;
    [Header("dead"), Tooltip("true = dead ,false = survive")]
    public bool dead;

    [Header("動畫控制器")]
    public Animator ani;
    [Header("膠囊碰撞器")]
    public CapsuleCollider2D cc2d;
    [Header("剛體")]
    public Rigidbody2D rig;

    /// <summary>
    /// 是否在地板上
    /// </summary>
    public bool isGround;
    #endregion



    #region 方法區域
    // C# 括號符號是成對出現的: () [] {} "" ''
    // 摘要:方法的說明
    // 在方法上方舔加三條 /
    // 自訂方法 - 不會執行的，需要呼叫
    // API - 功能倉庫
    // 輸出功能 print ("字串")

    private void move()
    {
        // 如果剛體.加速度.大小 小於 10
        if (rig.velocity.magnitude < 10)
        {
            // 剛體.添加能力(二維向量)
            rig.AddForce(new Vector2(speed, 0));
        }
    }
    /// <summary>
    /// 角色的跳躍功能:跳躍動畫、撥放音效與往上跳
    /// </summary>
    private void Jump()
    {
        // 布林值 = 輸入.取得按鍵(按鍵代碼列舉.左邊 alt)
        bool Jump = Input.GetKey(KeyCode.LeftAlt);

        // 動畫控制器代號

        // 顛倒運算子 !
        // 作用:將布林值變成相反
        // !true ----- false

        ani.SetBool("跳躍鈕", !isGround);

        // 搬家  Alt+上、下
        // 格式化 Ctrl+ K D

        // 如果在地板上
        if (isGround)
        {
            if (Jump)
            {
                isGround = false;                       // 不在地板上
                rig.AddForce(new Vector2(0, height));   // 剛體.添加推力(二維向量)
            }

        }
    }

    /// <summary>
    /// 角色的滑行功能:滑行動畫、播放音效、縮小碰撞範圍
    /// </summary>
    private void slide()
    {
        // 布林值 = 輸入.取得按鍵(按鍵代碼列舉.左邊 ctrl)
        bool slide = Input.GetKey(KeyCode.LeftControl);

        // 動畫控制器代號
        ani.SetBool("滑鈕", slide);

        if (slide)   // 如果 玩家 按下 左邊 ctrl 就縮小
        {
            cc2d.offset = new Vector2(-1.6f, -1.4f);   // 位移
            cc2d.size = new Vector2(1.2f, 2.1f);   // 尺寸
        }
        // 否則 恢復
        else
        {
            cc2d.offset = new Vector2(-1.6f, -0.35f);   // 位移
            cc2d.size = new Vector2(1.2f, 4.23f);   // 尺寸
        }

    }

    /// <summary>
    /// 碰到障礙物時受傷:扣血
    /// </summary>
    private void Hit()
    {
        print("碰撞");
    }

    /// <summary>
    /// 吃金幣:金幣數量增加，更新介面、金幣音效
    /// </summary>
    private void EatCoin()
    {
        print("吃金幣");
    }

    /// <summary>
    /// 死亡:動畫，遊戲結束
    /// </summary>
    private void Dead()
    {
        print("死亡");
    }
    #endregion

    #region 事件區域

    // 開始 start
    private void Start()
    {

    }
    // 更新 update
    // 播放遊戲後一秒執行約 60 次 - 60FPS
    // 移動、監聽玩家鍵盤、滑鼠與觸碰
    private void Update()
    {
        slide();
    }

    private void FixedUpdate()
    {
        Jump();
        move();
    }
    /// <summary>
    /// 碰撞事件:碰到物件開始執行一次
    /// </summary>
    /// <param name="collision">碰到物件的碰撞資訊</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 如果碰到物件的名稱等於"地板"
        if (collision.gameObject.name == "地板")
        {
            // 是否在地板上 = 是
            isGround = true;
        }
    }
    #endregion
}
