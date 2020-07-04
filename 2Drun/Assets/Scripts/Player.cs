
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

    [Header("Speed"), Tooltip("CHR speed")]
    int speed = 80;
    [Header("jump"), Tooltip("CHR jump"), Range(10, 50)]
    int jump = 50;
    [Header("sound"), Tooltip("sound area")]
    AudioClip soundhight;
    AudioClip soundhit;
    [Header("gold")]
    int gold;
    [Header("hp")]
    float hp = 950.5f;
    [Header("dead"), Tooltip("true = dead ,false = survive")]
    bool dead;









    #endregion



    #region 方法區域
    // C# 括號符號是成對出現的: () [] {} "" ''
    // 摘要:方法的說明
    // 在方法上方舔加三條 /
    // 自訂方法 - 不會執行的，需要呼叫
    // API - 功能倉庫
    // 輸出功能 print ("字串")

    /// <summary>
    /// 角色的跳躍功能:跳躍動畫、撥放音效與往上跳
    /// </summary>
    private void Jump()
    {
        print("跳躍");
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
        Jump();
    }
    // 更新 update
    // 播放遊戲後一秒執行約 60 次 - 60FPS
    // 移動、監聽玩家鍵盤、滑鼠與觸碰
    private void Update()
    {
        Jump();
    }

    #endregion
}
