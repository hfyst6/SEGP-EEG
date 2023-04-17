using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyBindScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Dictionary<string ,KeyCode> keys= new Dictionary<string,KeyCode>();
    public Text up , down ;
    private Color32 normal= new Color(39,171,249,255);
    private Color32 selected = new Color32(239,116,36,255);
    private GameObject currentKey;
    void Start()
    {
        keys.Add("Up",KeyCode.W);
        keys.Add("Down",KeyCode.S);

        up.text= keys["Up"].ToString();
        down.text= keys["Down"].ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keys["Up"])){

        Debug.Log("Up");
        }
         if(Input.GetKeyDown(keys["Down"])){

        Debug.Log("Down");
        }

        
    }
    void OnGUI(){
        if(currentKey!=null)
        {
            Event e = Event.current;
            if(e.isKey){
                keys[currentKey.name]=e.keyCode;
                currentKey.GetComponent<Text>().text=e.keyCode.ToString();
                currentKey=null;
            } 
        }
    }
    public void ChangeKey(GameObject clicked)
    {
        if(currentKey!=null)
        {
            currentKey.GetComponent<Text>().color=normal;
        }
        currentKey=clicked;
        currentKey.GetComponent<Text>().color=selected;
        currentKey.GetComponent<Text>().color=normal;
    }
    
}
