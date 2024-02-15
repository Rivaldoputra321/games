using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MengaturText : MonoBehaviour
{
        [Header("Deckripsi Sampah")]
        public TrackableAR[] tr;
        [TextArea]
        public string[] Deskripsi;

        [Header("UI Dekripsi")]
        public Text txtDescripsi;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i < tr.Length; i++)
        {
            if(tr[i].GetMarker())
            {
                txtDescripsi.text = Deskripsi[i];
            }
        }
    }
}
