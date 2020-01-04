# Unity_UGUI_Button_AddListener_Callback_By_Script
[筆記] Unity 透過代碼給 UGUI Button 添加 onClick 事件的方式


![image](https://raw.githubusercontent.com/Yasudabo/Unity_UGUI_Button_AddListener_Callback_By_Script/master/UGUIButtonAddListenerScriptDemo.gif)

--------
1. 無參數事件
<pre>
m_Button.onClick.AddListener(OutIo);
</pre>

<br/>
2. 帶參數事件，兩種寫法，選順眼的就好。
<br/>    你可以在 { } 的範圍裡可以添加更多事件
<pre>
m_Button.onClick.AddListener( delegate { OutIo(1); /*其它事件*/ });
</pre>

<pre>
m_Button.onClick.AddListener( () => { OutIo(2); /*其它事件*/ });
</pre>



