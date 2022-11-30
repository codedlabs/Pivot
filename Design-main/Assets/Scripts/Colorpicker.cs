using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colorpicker : MonoBehaviour
{
    [SerializeField]
    RectTransform _texture;
    [SerializeField]
    GameObject _sphereTest;
    [SerializeField]
    Texture2D _refsprite;

    public void onclickpicker() {
        setcolor();
    }

    private void setcolor() {
        Vector3 imagepos = _texture.position;
        float globalPoX = Input.mousePosition.x - imagepos.x;  //this must be for the VR pointer 
        float globalPoy = Input.mousePosition.y - imagepos.y; // this must be for the Vr pointer 
        int localposx = (int)(globalPoX * (_refsprite.width / _texture.rect.width));
        int localposy = (int)(globalPoy * (_refsprite.height / _texture.rect.height));

        Color c = _refsprite.GetPixel(localposx, localposy);
        setAcutualcolor(c);
    }//end of the setcolor  function 
      void setAcutualcolor(Color c) {
        _sphereTest.GetComponent<MeshRenderer>().material.color = c;
    
    }


}
