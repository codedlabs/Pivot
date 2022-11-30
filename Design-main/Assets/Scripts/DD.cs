using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DD : MonoBehaviour
{
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {

        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        List<string> items = new List<string>();
        items.Add("2x3");
        items.Add("4x4");
        items.Add("5x6");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });

        }
        dropdownitemselected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { dropdownitemselected(dropdown); });




    }


    void dropdownitemselected(Dropdown dropdown)
    {
        int index = dropdown.value;
        textBox.text = dropdown.options[index].text;

    }
}
