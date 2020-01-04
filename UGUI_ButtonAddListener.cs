using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UGUI_ButtonAddListener : MonoBehaviour {

    public Button m_Button_NoParameter;
    public Button m_Button_Parameter_1;
    public Button m_Button_Parameter_2;

    public Button[] ButtonList;


    void Start () {
        // A simple way for add a listener by script.
        m_Button_NoParameter.onClick.AddListener(OutIo);

        // If the callback have parameter, there are two ways of writing, just choose the one you like.
        m_Button_Parameter_1.onClick.AddListener( delegate { OutIo(1); /* You can do other action in {} */ });
        m_Button_Parameter_2.onClick.AddListener( () =>    { OutIo(2); /* You can do other action in {} */ });

        // If using array elements to add listener...
        // It is important to note that not assign array element directly, we should using a temporary variable instead.
        for (int i=0; i < ButtonList.Length; i++) {
            int tmpId = i;
            ButtonList[i].onClick.AddListener( () => OutIoElement(tmpId) );
        }
    }

    private void OutIo() {
        Debug.Log("You click the Button -" + "<color=darkblue> No Parameter" +"</color>！");
    }

    private void OutIo(int id) {
        Debug.Log("You click the Button -" + "<color=#800000ff> Parameter " + id + "</color>！");
    }

    private void OutIoElement(int id) {
        Debug.Log("Button <color=#3A773BFF>[" + id + "]</color>");
    }



}
