using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitcontr : MonoBehaviour {
    // Use this for initialization
   public GameObject but;
    public GameObject viter;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void Start () 
    {
        but.SetActive(false);
        viter.SetActive(false);
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool vis = !Cursor.visible;
            Cursor.visible = vis;
            but.SetActive(vis);
            viter.SetActive(false);
        }
    }
   public  void exit()
    {
        but.SetActive(false);
        viter.SetActive(true);
    }
    public void leave()
    {
        Application.Quit();
    }
}
