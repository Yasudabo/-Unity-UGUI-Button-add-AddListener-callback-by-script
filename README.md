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
<br/>※你可以在 { } 的範圍裡可以添加更多要觸發的事件。
<pre>
m_Button.onClick.AddListener( delegate { OutIo(1); /*其它事件*/ });
</pre>

<pre>
m_Button.onClick.AddListener( () => { OutIo(2); /*其它事件*/ });
</pre>

<br/>
3. 迴圈帶參數的寫法
<br/>> 注意：傳遞的參數需要先用一個臨時變量儲存後再傳遞，
<br/>> 否則傳遞的參數值會是迴圈的數量，或是null，進而導致報錯！
<pre>
for (int i=0; i < ButtonList.Length; i++) {
<br/>     int tmpId = i;
<br/>     ButtonList[i].onClick.AddListener( () => OutIoElement(tmpId) );
<br/>}
</pre>



