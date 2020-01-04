# Unity_UGUI_Button_AddListener_Callback_By_Script
[筆記] Unity 透過代碼給 UGUI Button 添加 onClick 事件的方式


![image](https://raw.githubusercontent.com/Yasudabo/Unity_UGUI_Button_AddListener_Callback_By_Script/master/UGUIButtonAddListenerScriptDemo.gif)

--------
1. 無參數事件
<pre>
m_Button.onClick.AddListener(OutIo);
</pre>

<br/>
2. 帶參數事件，兩種寫法，選順眼的就好
<br/>{ } 的區域裡可以執行更多事件
<pre>
m_Button.onClick.AddListener( delegate { OutIo(1); });
</pre>

<pre>
m_Button.onClick.AddListener( () => { OutIo(2); });
</pre>
