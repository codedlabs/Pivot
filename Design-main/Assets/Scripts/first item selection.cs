using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class firstitemselection : MonoBehaviour
{
    // Start is called before the first frame update

    public Text textBox;
    public Dropdown dropdown;
    public int index;

    // Start is called before the first frame update
    void Start()
    {

        dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        List<string> items = new List<string>();
        items.Add("Options");
        items.Add("IKEA");
        items.Add("Abyat");
        items.Add("Midas");


        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });

        }
        dropdown.onValueChanged.AddListener(delegate { dropdownitemselected(dropdown); });
    }
    void dropdownitemselected(Dropdown dropdown)
    {
        index = dropdown.value;
        textBox.text = dropdown.options[index].text;
    }
}


   

