using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupManager : MonoBehaviour
{
    // Variables to be assigned (Preafabs)\\
    [SerializeField]
    private GameObject popup;
    [SerializeField]
    private GameObject header;
    [SerializeField]
    private GameObject body;
    [SerializeField]
    private GameObject button;

    //Other variables\\
    private GameObject newPopup;
    private GameObject newCanvas;
    private GameObject newHeader;
    private GameObject newBody;
    private GameObject newButton;

    private GameObject returnPopup;


    void Start()
    {

    }

    public void CreatePopup(float posX, float posY, string headerText, string bodyText, Color bodyColor, string buttonText, float rotation = 0)
    {
        newPopup = Instantiate(popup, new Vector3(posX, posY, 0), Quaternion.identity);
        newCanvas = newPopup.transform.GetChild(0).gameObject;
        newHeader = Instantiate(header, newCanvas.transform, false);
        newBody = Instantiate(body, newCanvas.transform, false);
        newButton = Instantiate(button, newCanvas.transform, false);

        newPopup.transform.eulerAngles = new Vector3(0,0,rotation);

        newHeader.GetComponent<TextMeshProUGUI>().text = headerText;

        newBody.GetComponent<TextMeshProUGUI>().text = bodyText;
        newBody.GetComponent<TextMeshProUGUI>().color = bodyColor;

        newButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = buttonText;
    }
}
