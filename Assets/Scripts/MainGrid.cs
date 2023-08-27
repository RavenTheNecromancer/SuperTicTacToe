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

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                Utils.CreateWorldText(
                    gridArray[x, y].ToString(), null, GetWorldPosition(x, y), 20,
                    Color.white, TextAnchor.MiddleCenter
                );
            }
        }
    }

	//Get coordinates for the given grid and calculates the position depending on the cell size
	private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
}