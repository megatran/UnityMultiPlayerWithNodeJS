using UnityEngine;
using System.Collections;

public class ScreenClicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire2"))
        {
            Clicked();
        }
	}

    void Clicked()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();
        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
            var clickMove = hit.collider.gameObject.GetComponent<ClickMove>();
            clickMove.OnClick(hit.point);
        }
    }
}
