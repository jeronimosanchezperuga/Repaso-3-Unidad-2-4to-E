using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{
    public GameObject prefab;
    public Text inputCloneAmount;
    public Text displayClonesLeft;
    public InputField IField;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }

    public void ClonePrefab()
    {
        if (inputCloneAmount.text != "")
        {
            IField.readOnly = true;
            int cloneAmount = int.Parse(inputCloneAmount.text);
            if (counter < cloneAmount)
            {
                Instantiate(prefab);
                counter++;
                displayClonesLeft.text = (cloneAmount - counter).ToString();
            }
            else
            {
                displayClonesLeft.text = "No hay más";
            }
        }
        else
        {
            displayClonesLeft.text = "ERROR. Ingrese un valor";
        }

          
    }
}
