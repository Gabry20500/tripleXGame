using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public InputField inputfield;
    public Text SumText;
    public Text MoltiplicationText;

    int min = 1, max = 10;
    int counter = 2;
    private List<int> RandNum = new List<int>(3);
    // Start is called before the first frame update
    void Start()
    {

        int rand;
        for(int i = 0; i < 3; i++)
        {
            rand = Random.Range(min, max);
            print("The rand Val is:" + rand);
            RandNum.Add(rand);
        }
 
        int sum = NumSum();
        int mol = NumMoltiplication();
        SumText.text = sum.ToString();
        MoltiplicationText.text = mol.ToString();

    }

    private int NumSum()
    {
        int SumRes = 0;

        for(int i = 0; i< 3; i++)
        {
            SumRes = SumRes + RandNum[i];
        }

        return SumRes;
    }

    private int NumMoltiplication()
    {
        int MoltiplicationRes = 1;

        for (int i = 0; i < 3; i++)
        {
            MoltiplicationRes = MoltiplicationRes * RandNum[i];
        }

        return MoltiplicationRes;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
