using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class EstructurasDatos : MonoBehaviour
{  
    //Estructuras de Datos 
    //bucles 
    //Break , Continue, goto, return . en un sitio del programa ponemos  linea:  y goto linea; nos lleva hasta el punto de la linea .

    [SerializeField] GameObject cube;
    [SerializeField] GameObject emptyWall;
    List<GameObject> cubeList = new List<GameObject>();


    private Vector3 VectorFunction(int x, int y, int z)
    {   
        return new Vector3(cube.transform.position.x + x, cube.transform.position.y + y, cube.transform.position.z + z);
    }


    void Start()

    {
        //ARRAY 2D ************************************* 
        //primera posicion y  otra Z
        // int[,] array2D = new int[5, 5];


        //Primera manera de guardar datos 

        //array2D[0, 0] = 4;
        //array2D[0, 1] = 4;
        //array2D[0, 2] = 34; 

        //SEGUNDA MANERA DE GUARDAR DATOS 



        //Vector3[,] array2D = new Vector3[5, 5]
        //{
        //      {new Vector3(0,0),new Vector3(0,1),new Vector3(0,2),new Vector3(0,3),new Vector3(0,4)},
        //      {new Vector3(1,0),new Vector3(1,1),new Vector3(1,2),new Vector3(1,3),new Vector3(1,4)},
        //      {new Vector3(2,0),new Vector3(2,1),new Vector3(2,2),new Vector3(2,3),new Vector3(2,4)},
        //      {new Vector3(3,0),new Vector3(3,1),new Vector3(3,2),new Vector3(3,3),new Vector3(3,4)},
        //      {new Vector3(4,0),new Vector3(4,1),new Vector3(4,2),new Vector3(4,3),new Vector3(4,4)}


        //};



        //for (int i = 0; i < array2D.GetLength(0); i++)
        //{
        //    for (int j = 0; j < array2D.GetLength(1); j++)
        //    {
        //        Debug.Log(array2D[i, j]);


        //         Instantiate(cube, array2D[i, j], cube.transform.rotation);



        //    }

        //}

        //ARRAY 3D ****************************************

        //    Vector3[,,] array3D = new Vector3[2, 5, 5]
        //    {
        //    {
        //          {new Vector3(0,0,0),new Vector3(0,0,1),new Vector3(0,0,2),new Vector3(0,0,3),new Vector3(0,0,4)},
        //          {new Vector3(0,1,0),new Vector3(0,1,1),new Vector3(0,1,2),new Vector3(0,1,3),new Vector3(0,1,4)},
        //          {new Vector3(0,2,0),new Vector3(0,2,1),new Vector3(0,2,2),new Vector3(0,2,3),new Vector3(0,2,4)},
        //          {new Vector3(0,3,0),new Vector3(0,3,1),new Vector3(0,3,2),new Vector3(0,3,3),new Vector3(0,3,4)},
        //          {new Vector3(0,4,0),new Vector3(0,4,1),new Vector3(0,4,2),new Vector3(0,4,3),new Vector3(0,4,4)}
        //    },
        //      {
        //          {new Vector3(1,0,0),new Vector3(1,0,1),new Vector3(1,0,2),new Vector3(1,0,3),new Vector3(1,0,4)},
        //          {new Vector3(1,1,0),new Vector3(1,1,1),new Vector3(1,1,2),new Vector3(1,1,3),new Vector3(1,1,4)},
        //          {new Vector3(1,2,0),new Vector3(1,2,1),new Vector3(1,2,2),new Vector3(1,2,3),new Vector3(1,2,4)},
        //          {new Vector3(1,3,0),new Vector3(1,3,1),new Vector3(1,3,2),new Vector3(1,3,3),new Vector3(1,3,4)},
        //          {new Vector3(1,4,0),new Vector3(1,4,1),new Vector3(1,4,2),new Vector3(1,4,3),new Vector3(1,4,4)}
        //    },


        //};




        //    for (int X = 0; X < array3D.GetLength(0); X++)
        //    {
        //        for (int Y = 0; Y < array3D.GetLength(1); Y++)
        //        {

        //         Instantiate(cube, array3D[0, Y, X], cube.transform.rotation);

        //        }

        //    }

        //    for (int X = 0; X < array3D.GetLength(0); X++)
        //    {
        //        for (int Y = 0; Y < array3D.GetLength(1); Y++)
        //        {

        //            Instantiate(cube, array3D[1, Y, X], cube.transform.rotation);

        //        }

        //    }


        //ARRAYS DE ARRAYS ********************************

        int[][] lista = new int[6][]
        {
            new int[10]{0,0,0,1,1,1,1,0,0,0},
            new int[10]{0,0,0,1,1,1,1,0,0,0},
            new int[10]{0,0,0,0,0,0,0,0,0,0},
            new int[10]{0,2,2,0,0,0,0,3,3,0},
            new int[10]{0,2,2,0,0,0,0,3,3,0},
            new int[10]{0,0,0,0,0,0,0,0,0,0}
        };

        
       

        for(int filas=0; filas<lista.Length; filas++)
        {
            for(int columnas = 0; columnas < lista[filas].Length; columnas++) 
            {
                if (lista[filas][columnas] == 0)
                {
                    if (columnas <= 9)
                    {
                        GameObject ob =Instantiate(cube, VectorFunction(columnas,filas,0), cube.transform.rotation);
                       
                    }
                   

                }
            }
        }

       


        //DICTIONARY******************************************

        //Dictionary<string, int> players = new Dictionary<string, int>(5);// le podemos poner los datos que vamos a usar 
        //players.Add("Carlos",1999);
        //players.Add("Juan", 138);
        //players.Add("Pedro", 399);
        //players.Add("Geremias", 4000);
        //players.Add("Ana", 3);
        //players.Add("Maria", 7);

        //foreach(KeyValuePair<string,int>dict in players)
        //{
        //    Debug.Log(dict.Key + " " + dict.Value);
        //}

        //if (players.ContainsKey("Carlos"))
        //{
        //    Debug.Log("Verdadero");
        //}
        //else
        //{
        //    Debug.Log("Falso");
        //}

        // ARRAY LIST *************************************

        //ArrayList money=new ArrayList();


        //private void Awake()
        //{
        //    money.Add(34);
        //    money.Add("hello").GetType();
        //    money.Add(GameObject.Find("Pater"));
        //} 
    }

    // Update is called once per frame
    void Update()
    {

    }




}
//arrays 
//arrays 2D 
//arrays 3D 
//Listas
//ArrayList 
//diccionarios
