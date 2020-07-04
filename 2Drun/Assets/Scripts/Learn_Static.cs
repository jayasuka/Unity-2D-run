
using UnityEngine;

public class Learn_Static : MonoBehaviour
{
    private void Start()
    {
        // 動態成員用法
        // 靜態屬性 Property = 欄位 Field (儲存資料)
        // 語法:類別名稱.靜態屬性名稱
        print(Mathf.PI);
        print(Mathf.Infinity);

        print(Random.value);   // 0 - 1 隨機值

        // 靜態方法 Method
        // 語法:類別名稱.靜態方法名稱(對應參數)
        print(Mathf.Abs(-789));

        // 取得 100 - 500 隨機值
        print(Random.Range(100, 501));
    }

    private void Update()
    {
        // print(Time.time);

    }
}
