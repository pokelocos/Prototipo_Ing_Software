using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public Text nameDisplay;
    public Text descriptionDisplay;
    public Image imageDisplay;

    public void SetInfo(string name, string description,Sprite img)
    {
        nameDisplay.text = name;
        descriptionDisplay.text = description;
        imageDisplay.sprite = img;
    }

}
