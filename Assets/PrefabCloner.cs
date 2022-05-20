using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabCloner : MonoBehaviour
{
    public GameObject prefab;
    public Text inputCloneAmount;
    int counter;
    public Text displayClonesLeft;
    public InputField IField;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "";
    }

    // Update is called once per frame
    void Update()
    {

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
                displayClonesLeft.text = "Ya clonó suficientes objetos";
            }
        }else 
        {
            displayClonesLeft.text = "Error. Ingrese un valor";
        }
    }
}
