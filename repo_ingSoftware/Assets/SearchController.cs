using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchController : MonoBehaviour
{
    public InputField inputfield;

    public List<InfoPanel> element = new List<InfoPanel>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()
    {
        if(inputfield.text.Length == 0)
        {
            foreach (var e in element)
                e.gameObject.SetActive(true);
        }
        else
        {
            foreach (var e in element)
            {
                var e_name = e.nameDisplay.text.ToLower();
                var i_name = inputfield.text.ToLower();
                if (e_name.Contains(i_name))
                {
                    e.gameObject.SetActive(true);
                }
                else
                {
                    e.gameObject.SetActive(false);
                }
            }
        }

        
    }
}
