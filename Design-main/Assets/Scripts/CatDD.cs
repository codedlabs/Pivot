using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatDD : MonoBehaviour
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
        items.Add("Table");
        items.Add("Charies");
        items.Add("Lanbs");
        

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


    void Update()
    {
        index = dropdown.value;
        if (index != null)
        {

            //  if(index==0){
            // load scene 0
            //  SceneManager.LoadScene("Testtt");}
            if (index == 1)
            {

                SceneManager.LoadScene("Table");
            }
            else if (index == 2)
            {

                SceneManager.LoadScene("Charies");
            }
            else if (index == 3)
            {
                //load scene 0
                SceneManager.LoadScene("Lambs");
            }
            


        }
    }
}


