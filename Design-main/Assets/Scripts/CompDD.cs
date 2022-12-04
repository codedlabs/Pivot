using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompDD : MonoBehaviour
{
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
        items.Add("ABYAT");
        items.Add("MIDAS");
        
        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });

        }
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
