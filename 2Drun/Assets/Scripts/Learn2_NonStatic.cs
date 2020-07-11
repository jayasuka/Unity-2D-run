using UnityEngine;

public class Learn2_NonStatic : MonoBehaviour
{
    // 儲存場景上物件與元件
    public GameObject boy;

    public Transform boyTran;

    public Camera cam;

    public ParticleSystem ps;

    // 靜態與非靜態差異
    // 非靜態需要有物件與元件

    // 存取
    // 非靜態屬性

    private void Start()
    {
        // 取得
        print(boy.tag);
        print(boy.layer);

        // 存放
        boyTran.position = new Vector3(0, 3, 0);
        boyTran.localScale = new Vector3(2, 2, 2);
    }

    private void Update()
    {
        // 非靜態方法
        boyTran.Rotate(0, 0, 10);
        boyTran.Translate(0.2f, 0, 0);
    }
}
