using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
public class MazeMaker : MonoBehaviour
{
    public List<GameObject> obstacles;
    public float placeChance;
    public int mapSizeX;
    public int mapSizeZ;
    public Transform mapParent;
    public NavMeshSurface surface;
    private void Start()
    {
        MakeMaze();
        surface.BuildNavMesh();
    }
    public void MakeMaze()
    {
        for(int i =0; i<mapSizeX; i++)
        {
            for(int q =0; q< mapSizeZ; q++)
            {
                Vector3 direction = new Vector3(i, 0, q);
                int random = Random.Range(1, 10);
                if (random <= placeChance)
                {
                    random = Random.Range(0, obstacles.Count);
                    GameObject obstacle = Instantiate(obstacles[random], mapParent.position + direction, Quaternion.identity);
                    obstacle.transform.SetParent(mapParent);
                }
            }
        }
        
    }
}
