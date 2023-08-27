using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClickHandle : MonoBehaviour
{

    public GameObject xObjectPrefab;
	public GameObject oObjectPrefab;
    private MainGrid mainGrid;
    private int tileX;
    private int tileY;

    public void Initialize(MainGrid mainGrid, int x, int y)
    {
        this.mainGrid = mainGrid;
        tileX = x;
        tileY = y;
    }

    private void OnMouseDown()
    {
        // This function will be called when the tile is clicked
        // You can implement any actions you want here
        var position = new Vector3(tileX, tileY);
        Debug.Log("Tile Clicked: (" + tileX + ", " + tileY + ")");
		GameObject oObject = Instantiate(oObjectPrefab, position, Quaternion.identity);
        Instantiate(oObject);
		//projectile.GetComponent<Rigidbody>().velocity = fireballSpawnPoint.forward * projectileSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
