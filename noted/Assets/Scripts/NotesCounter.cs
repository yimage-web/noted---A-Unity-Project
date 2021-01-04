using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotesCounter : MonoBehaviour
{
    private int used = 0;
    public Text notesUsed;
    private int countSpec;
    private string noteNames = "noteBase (";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        notesUsed.text = " Notes Used : " + used;


        for (int i = 1; i <= 9; i++)
        {
            countSpec = GameObject.Find(noteNames + i + ")").GetComponent<Notes>().countSpec;
            used = used + countSpec;
        }
        

    }
}
