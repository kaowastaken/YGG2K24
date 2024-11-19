using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private SpriteState spriteState;
    [SerializeField] private Button button;

    

    //public Sprite ButtonImage;
    //public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void  SpriteChange() 
    {
        button.spriteState = spriteState;
    }

  




  /*private void Close(GameObject obj)
    {
        obj.SetActive(false);
    }*/

   /* public void changeButtonImagae()
    {
        button.image.sprite = ButtonImage;
    }
   */

}
