using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper
{
    public class Grid : MonoBehaviour
    {
        // Funtions & Variables go here
        public GameObject tilePrefab;
        public int width = 10, height = 10;
        public float spacing = .155f;

        private Tile[,] tiles;
        // Functionality for spawning tiles
        Tile SpawnTile(Vector3 pos)
        {
            // Clone tile prefab
            GameObject clone = Instantiate(tilePrefab);
            //Edit it's properties
            clone.transform.position = pos;
            Tile currentTile = clone.GetComponent<Tile>();
            // Return it
            return currentTile;
        }
        //spawn tiles in a grid like pattern
        void GenerateTiles()
        {
            // Create a new 2D array of size width x height
            tiles = new Tile[width, height];
            //Loop through the entire tile list
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //NOTE: (GenerateTiles(): Part 2) goes here
                    //Store half size for latar use
                    Vector2 halfSize = new Vector2(width * 0.5f,
                        height * 0.5f);
                    // Pivot tiles around grid
                    Vector2 pos = new Vector2(x - halfSize.x,
                        y - halfSize.y);
                    //Apply spacing
                    pos *= spacing;
                    //Spawn the tile using spwan function made earlier
                    Tile tile = SpawnTile(pos);
                    //Attach newly spawned tile to self (transform)
                    tile.transform.SetParent(transform);
                    // Store it's array coordinates within itself for future reference
                    tile.x = x;
                    tile.y = y;
                    // Store tile in array at those coordinates
                    tiles[x, y] = tile;
                }
            }
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GenerateTiles();
        }
        public int GetAdjacentMineCount(Tile tile)
        {
            //Set count to 0
            int count = 0;
            //Loop through all the adjacent tiles on the X
            for (int x = -1; x <= 1; x++)
            {
                //Loop through all the adjacent tiles on the Y
                for (int y = -1; y <= 1; y++)
                {
                    //Calculate which adjacent tile to look at
                    int desiredX = tile.x + x;
                    int desiredY = tile.y + y;
                    //Check if the desired x & y is outside bounds
                    if(desiredX < 0 || desiredX >= width || desiredY < 0 || desiredY >= height)
                    {
                        // continue to next element in loop
                        continue;
                    }
                    // select current tile
                    Tile currentTile = tiles[desiredX, desiredY];
                    // Check if that tile is a mine
                    if ()
                }
            }
        }
    }



}


//void FFuncover(int x, int y, bool[,] visited)
//{
//    // Is x and y within bounds of the grid?
//    if(x >= 0    && y ?= 0 &&
//        x < width && y < height)
//    {
//        // Have these coordinates been visited?
//        if (visited[x, y])
//            return;
//        // Reveal tile in that x and y coordinate
//        Tile tile = tile[x, y]
//    }
//}

