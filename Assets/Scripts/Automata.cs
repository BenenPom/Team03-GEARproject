using System.Collections;
using UnityEngine;

public class Automata : MonoBehaviour
{
    [SerializeField]
    GameObject controller;

    [SerializeField]
    GameObject[] vehicles;

    [SerializeField, Range(1, 100)]
    int automataCount = 50;

    GameObject[] automata;
    float[] speeds;

    Vector3 currentPosition;
    Vector3 previousPosition;
    bool accelerate;


    void Start()
    {
        automata = new GameObject[automataCount];
        speeds = new float[automataCount];
        for (int i = 0; i < automataCount; i++)
        {
            automata[i] = Instantiate(vehicles[Random.Range(0, vehicles.Length)]);
            automata[i].transform.localPosition = new Vector3(
                Random.Range(-50f, 50f), 
                Random.Range(0f, 50f), 
                Random.Range(-50f, 50f)
            );
            automata[i].transform.localRotation = Random.rotation;
            automata[i].transform.SetParent(transform);
            speeds[i] = Random.value * 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ControlAutomata();
    }

    void ControlAutomata()
    {
        previousPosition = currentPosition;
        currentPosition = controller.transform.position;
        accelerate = Vector3.Distance(currentPosition, previousPosition) > 0.001f;

        for (int i = 0; i < automataCount; i++)
        {
            automata[i].transform.Rotate(Vector3.up, speeds[i] * Time.deltaTime * (accelerate ? 100f : 0f));
        }

    }

}
