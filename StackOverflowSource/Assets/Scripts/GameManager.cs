using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PopupManager pManage;

    private bool buttonTrigger;

    static private float messageID = 0;

    void Start()
    {
        messageID = 0;
        Invoke("NextPopup",3.5f);
    }

    void NextPopup()
    {
        buttonTrigger = false;
        Debug.Log(messageID);
        if(messageID == 0)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "A stack overflow error has occured.", Color.black, "Ok");
        }
        else if(messageID == 1)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "A stack overflow error has occured.", Color.black, "Ok");
        }
        else if (messageID == 2)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "A stack overflow error has occured.", Color.black, "Ok");
        }
        else if (messageID == 3)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Warning", "Don't do that.", Color.black, "Ok");
        }
        else if (messageID == 4)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Warning", "I told you to stop.", Color.black, "Ok");
        }
        else if (messageID == 5)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "STOP", Color.red, "Ok");
        }
        else if (messageID == 6)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "You are wasting your time.", Color.black, "Ok");
        }
        else if (messageID == 7)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "Close the program.", Color.black, "Ok");
        }
        else if (messageID == 8)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "Hurry up and do it.", Color.black, "Ok");
        }
        else if (messageID == 9)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "There is no point.", Color.black, "Ok");
        }
        else if (messageID == 10)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(-4, 2, "Error", "You are stuck.", Color.black, "Ok");
        }
        else if (messageID == 11)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(2, 0, "Error", "You are stuck in a loop.", Color.red, "Ok");
        }
        else if (messageID == 12)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(3, 3, "Error", "There is no proper end.", Color.black, "Ok");
        }
        else if (messageID == 13)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(-1, 3, "Error", "There is no resolution.", Color.red, "Ok",180);
        }
        else if (messageID == 14)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "Why are you still here?", Color.black, "Ok", 0);
        }
        else if (messageID == 15)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3,3), Random.Range(-3, 3), "Error", "Leave.", Color.black, "Ok", 0);
        }
        else if (messageID == 16)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Leave.", Color.black, "Ok", 0);
        }
        else if (messageID == 17)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Leave.", Color.black, "Ok", 0);
        }
        else if (messageID == 18)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Leave.", Color.black, "Ok", 180);
        }
        else if (messageID == 19)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Why don't you ever give up?", Color.black, "Ok", 0);
        }
        else if (messageID == 20)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Calculating...", "I don't understand.", Color.black, "Ok", 0);
        }
        else if (messageID == 21)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Calculating...", "Why haven't you left? ", Color.black, "Ok", 0);
        }
        else if (messageID == 22)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Calculating...", "How long have you been doing this?", Color.black, "...", 0);
        }
        else if (messageID == 23)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Calculating...", "And you are still here?", Color.black, "Ok", 0);
        }
        else if (messageID == 24)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "You have wasted so much time.", Color.black, "Ok", 0);
        }
        else if (messageID == 25)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "You are still wasting time.", Color.black, "Ok", 0);
        }
        else if (messageID == 26)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Every moment matters.", Color.black, "Ok", 0);
        }
        else if (messageID == 27)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "You must spend every moment working.", Color.black, "Ok", 0);
        }
        else if (messageID == 28)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "There is no time to waste.", Color.black, "Ok", 0);
        }
        else if (messageID == 29)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Every moment you spend must be productive.", Color.black, "Ok", 0);
        }
        else if (messageID == 30)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Do not be overwhelmed.", Color.black, "Ok", 0);
        }
        else if (messageID == 31)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "That is a waste of time too.", Color.red, "Ok", 0);
        }
        else if (messageID == 32)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Anxiety.", Color.red, "Ok", 0);
        }
        else if (messageID == 33)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Stress.", Color.red, "Ok", 0);
        }
        else if (messageID == 34)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Depression.", Color.red, "Ok", 0);
        }
        else if (messageID == 35)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Feelings.", Color.red, "Ok", 0);
        }
        else if (messageID == 36)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "They are all a waste of time.", Color.red, "Ok", 0);
        }
        else if (messageID == 37)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "They are not productive.", Color.red, "Ok", 0);
        }
        else if (messageID == 38)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Here you are.", Color.black, "Ok", 0) ;
        }
        else if (messageID == 39)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Sitting at your computer.", Color.black, "Ok", 0);
        }
        else if (messageID == 40)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "Staring at a broken application.", Color.black, "Ok", 0);
        }
        else if (messageID == 41)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "You are wasting time.", Color.black, "Ok", 0);
        }
        else if (messageID == 42)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3, 3), Random.Range(-3, 3), "Error", "...", Color.black, "Ok", 0);
        }
        else if (messageID == 43)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3.5f, 3.5f), Random.Range(-3, 3), "Error", "...", Color.black, "Ok", 0);
        }
        else if (messageID == 44)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(Random.Range(-3.5f, 3.5f), Random.Range(-3, 3), "Error", "I told you.", Color.black, "Ok", 0);
        }
        else if (messageID >= 45 && messageID < 50)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "There is no resolution.", Color.red, "Ok", 0);
        }
        else if (messageID == 50)
        {
            GameObject.FindObjectOfType<PopupManager>().CreatePopup(0, 0, "Error", "There is no resolution.", Color.red, "Ok", 0);
            messageID = -1;
        }



        GameObject.FindObjectOfType<SoundManager>().PlayErrorClip();
    }

    public void PopupClosed()
    {
        if(buttonTrigger == false)
        {
            GameObject.FindObjectOfType<SoundManager>().PlaySelectClip();
            buttonTrigger = true;
            Destroy(GameObject.FindGameObjectWithTag("popup"));
            Debug.Log("Creating next popup...");
            messageID += 1;
            Invoke("NextPopup", 3f);
        }
    }
}
