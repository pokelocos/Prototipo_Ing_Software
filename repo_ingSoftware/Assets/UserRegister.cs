using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserRegister : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject name;
    public GameObject email;
    public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!name.GetComponent<InputField>().textComponent.text.Equals("") && !email.GetComponent<InputField>().textComponent.text.Equals(""))
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
}
