using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // 結果表示テキスト
    public Text Answer;

    // 各数字ボタン
    public Button[] bNumber;

    // クリアボタン
    public Button bClear;

    // Start is called before the first frame update
    void Start()
    {
        Answer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 各数字ボタン押下
    public void InputNumber(Text number){
        // 押下したボタンの数字を式欄に追記する
        Answer.text += number.text; 

    }

    // クリアボタン押下
    public void InputClear(Text equal){
        //初期化
        Answer.text = "";        
    }
}
