using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool test;

    private void Start()
    {
        // 語法:
        // 如果(布林值){程式內容}
        // 作用:當布林值為true才會執行{}程式內容
        if(test)
        {
            print("我是判斷式");
        }
    }

    public bool opendoor;

    private void Update()
    {
        // 作用:當布林值為true會執行 if () {} 程式內容
        // 作用:當布林值為false會執行 else {} 程式內容
        if (opendoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
}
