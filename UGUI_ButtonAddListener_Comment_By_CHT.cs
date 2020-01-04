using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UGUI_ButtonAddListener_Comment_By_CHT : MonoBehaviour {

    public Button m_Button_NoParameter;
    public Button m_Button_Parameter_1;
    public Button m_Button_Parameter_2;

    public Button[] ButtonList;


    void Start () {

        // 沒有參數的寫法
        m_Button_NoParameter.onClick.AddListener(OutIo);

        // 如果回調的事件要帶參數，可以使用委託的方式來指定，
        // 委託有兩種寫法，選喜歡的方式寫就好。
        m_Button_Parameter_1.onClick.AddListener( delegate { OutIo(1); });
        m_Button_Parameter_2.onClick.AddListener( () =>    { OutIo(2); });

        // { } 裡可以增加其它要觸發的事件
        m_Button_Parameter_2.onClick.AddListener(() => {
            Debug.Log("<color=#800000ff>按下按鈕 - 參數2 - 其它事件A </color>！");
            Debug.Log("<color=#800000ff>按下按鈕 - 參數2 - 其它事件B </color>！");
        });


        // 需要注意的是，如果要傳遞給委託的參數是來自陣列或迴圈，
        // 若直接傳遞引用，委託的回調會接收不到內容 (我也不知道為什麼)，
        // 解決方式是先用一個臨時變量去儲存，再透過這個臨時變量去傳遞。
        // https://forum.unity.com/threads/problem-using-array-element-as-parameter-in-addlistener-callback-function.272630/
        for (int i=0; i < ButtonList.Length; i++) {

            // 這樣會報錯，i 會等於 ButtonList 的大小，如果是物件則會變成null
            // ButtonList[i].onClick.AddListener( () => OutIoElement(i) );
            
            // 要用透過一個臨時變量去傳遞才不會有問題
            int tmpId = i;
            ButtonList[i].onClick.AddListener( () => OutIoElement(tmpId) );
        }

    }

    private void OutIo() {
        Debug.Log("按下按鈕 -<color=darkblue> 沒有參數 </color>！");
    }

    private void OutIo(int id) {
        Debug.Log("按下按鈕 -<color=#800000ff> 參數 " + id + "</color>！");
    }

    private void OutIoElement(int id) {
        Debug.Log("按鈕 <color=#3A773BFF>[" + id + "]</color>");
    }



}
