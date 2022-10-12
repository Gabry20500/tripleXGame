using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trpleX : MonoBehaviour
{
    public InputField inputField;
    public Text notificationText;


    // Start is called before the first frame update
    void Start()
    {
        Random rdm = new Random();
        private int max = 10;
        
        for (int i = 0; i < 3; i++)
        {
            print(rnd.Next(max));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
