using UnityEngine;
using System.Collections;

public class ClickMove : MonoBehaviour {

    public GameObject player;
	
	// Update is called once per frame
	public void OnClick (Vector3 position) {
        var navPos = player.GetComponent<navigatePosition>();
        navPos.NavigateTo(position);
	}
}
