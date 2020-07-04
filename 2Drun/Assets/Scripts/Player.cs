
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
    [Header("hight"), Tooltip("CHR hight"), Range(10, 50)]
    int hight = 50;
    [Header("sound"), Tooltip("sound area")]
    AudioClip soundhight;
    AudioClip soundhit;
    [Header("gold")]
    int gold;
    [Header("hp") Tooltip("CHR hp")]
    float hp = 950.5f;
    [Header("dead"), Tooltip("true = dead ,false = survive")]
    bool dead;

    







    #endregion

}
