using UnityEngine;
using System.Collections;

public class BallCreator : MonoBehaviour {

	[SerializeField]
	private GameObject ball;
    private GameObject wood;

	[SerializeField]
	private Sprite[] ballImages;
    private Sprite woodImages;

	private float minX = -4.7f, maxX = 6.5f, minY = -2.5f, maxY = 1.5f;

	public void CreateBall(int index) {
		GameObject gameBall = Instantiate(ball, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0),
		                                  Quaternion.identity) as GameObject;

		gameBall.GetComponent<SpriteRenderer> ().sprite = ballImages [index];
	}

    public void CreateRandomObject()
    {
        GameObject randomWood = Instantiate(wood, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0),
                                          Quaternion.identity) as GameObject;

        randomWood.GetComponent<SpriteRenderer>().sprite = woodImages;
    }


} // BallCreator
