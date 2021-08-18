using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public static TextManager instance;//static instance method available to all classes (including playerController). 
    int score;
   
    public void IncreaseScore()
    {
        score++;
        instance.textMesh.text = "Enjimon EXP Tokens: " + score;
    }

   
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null){
            
            instance = this;
        }
        score = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
