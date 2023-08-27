using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGrid
{
    //fields
    private int width;
    private int height;
    private float cellSize;

    //The 2D array itself *note* We gotta do 3D array afterwards to store the sub-arrays 
    private int[,] gridArray;

    //MainGrid constructor
    public MainGrid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];

        //Grid offset so middle is in center
        Vector3 offset = new Vector3(-cellSize * (width - 1) * 0.5f, -cellSize * (height - 1) * 0.5f);

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                Utils.CreateWorldText(
                    gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + offset, 20,
                    Color.white, TextAnchor.MiddleCenter
                );

                //Draw Line on Bottom
                Debug.DrawLine(GetWorldPosition(x, y) + offset * 1.5f, GetWorldPosition(x + 1, y) + offset * 1.5f, Color.white, 100f);
				//Draw Line on Left
				Debug.DrawLine(GetWorldPosition(x, y) + offset * 1.5f, GetWorldPosition(x, y + 1) + offset * 1.5f, Color.white, 100f);

			}
            //Draw horizontal on Top
			Debug.DrawLine(GetWorldPosition(0, height) + offset * 1.5f, GetWorldPosition(width, height) + offset * 1.5f, Color.white, 100f);
			//Draw vertical on Right
			Debug.DrawLine(GetWorldPosition(width, 0) + offset * 1.5f, GetWorldPosition(width, height) + offset * 1.5f, Color.white, 100f);
                

		}
	}

	//Get coordinates for the given grid and calculates the position depending on the cell size
	private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
}
