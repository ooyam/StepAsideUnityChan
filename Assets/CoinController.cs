using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{

    //メインカメラを入れる
    public GameObject mainCamObj;

    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
        //メインカメラの取得
        mainCamObj = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);

        //メインカメラがオブジェクトを通過した場合
        if (mainCamObj.transform.position.z > this.transform.position.z)
        {
            //通過したオブジェクトを破棄
            Destroy(this.gameObject);
        }
    }
}