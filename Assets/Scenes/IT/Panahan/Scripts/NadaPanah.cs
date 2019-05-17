using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class NadaPanah : MonoBehaviour {
	
	private Ray mouseRay1;
	private RaycastHit rayHit;
	private float posX;
	private float posY;

	public GameObject bowString;
	GameObject arrow;
	public GameObject arrowPrefab;
	public GameObject gameManager;	
	public GameObject risingText;
	public GameObject target;

	public AudioClip stringPull;
	public AudioClip stringRelease;
	public AudioClip arrowSwoosh;

	bool stringPullSoundPlayed;
	bool stringReleaseSoundPlayed;
	bool arrowSwooshSoundPlayed;

	private List<Vector3> bowStringPosition;
	LineRenderer bowStringLinerenderer;
    
	float arrowStartX;
	float length;

	bool arrowShot;
	bool arrowPrepared;
    
	Vector3 stringPullout;
	Vector3 stringRestPosition = new Vector3 (-0.44f, -0.06f, 2f);

	public enum GameStates {
		menu, 
		instructions,
		game,
		over,
		hiscore,
	};

	public GameStates gameState = GameStates.menu;

	public Canvas menuCanvas;
	public Canvas instructionsCanvas;
	public Canvas highscoreCanvas;
	public Canvas gameCanvas;
	public Canvas gameOverCanvas;

	public Text arrowText;
	public Text scoreText;
	public Text endscoreText;
	public Text actualHighscoreText;
	public Text newHighscoreText;
	public Text newHighText;

	public int arrows = 5;
	public int score = 0;

	void resetGame() {
		arrows = 5;
		score = 0;
		if (GameObject.Find("arrow") == null)
			createArrow (true);
	}

	void Start () {
		menuCanvas.enabled = true;
		highscoreCanvas.enabled = false;
		gameCanvas.enabled = false;
		gameOverCanvas.enabled = false;

		initScore ();

		createArrow (true);

		bowStringLinerenderer = bowString.AddComponent<LineRenderer>();
        bowStringLinerenderer.positionCount = 3;
        bowStringLinerenderer.SetWidth(0.05F, 0.05F);
        bowStringLinerenderer.useWorldSpace = false; //not active
		bowStringLinerenderer.material = Resources.Load ("Materials/bowStringMaterial") as Material;
		bowStringPosition = new List<Vector3> ();
		bowStringPosition.Add(new Vector3 (-0.44f, 1.43f, 2f));
		bowStringPosition.Add(new Vector3 (-0.44f, -0.06f, 2f));
		bowStringPosition.Add(new Vector3 (-0.43f, -1.32f, 2f));
		bowStringLinerenderer.SetPosition (0, bowStringPosition [0]);
		bowStringLinerenderer.SetPosition (1, bowStringPosition [1]);
		bowStringLinerenderer.SetPosition (2, bowStringPosition [2]);
		arrowStartX = 0.7f;

		stringPullout = stringRestPosition;
	}
    
	void Update () {
		switch (gameState) {
		case GameStates.menu:
			if (Input.GetKeyDown(KeyCode.Escape)) {
				Application.Quit();
			}
			break;

		case GameStates.game:
			showArrows();
			showScore();
			if (Input.GetKeyDown(KeyCode.Escape)) {
				showMenu();
			}
			if (Input.GetMouseButton(0)) {
				if (!stringPullSoundPlayed) {
					GetComponent<AudioSource>().PlayOneShot(stringPull);
					stringPullSoundPlayed = true;
				}
				prepareArrow();
			}
			if (Input.GetMouseButtonUp (0) && arrowPrepared) {
				if (!stringReleaseSoundPlayed) {
					GetComponent<AudioSource>().PlayOneShot(stringRelease);
					stringReleaseSoundPlayed = true;
				}
				if (!arrowSwooshSoundPlayed) {
					GetComponent<AudioSource>().PlayOneShot(arrowSwoosh);
					arrowSwooshSoundPlayed = true;
				}
				shootArrow();
			}
			drawBowString();
			break;
		case GameStates.instructions:
			break;
		case GameStates.over:
			break;
		case GameStates.hiscore:
			break;
		}
	}
	
	public void initScore() {
		if (!PlayerPrefs.HasKey ("Score"))
			PlayerPrefs.SetInt ("Score", 0);
	}


	public void showScore() {
		scoreText.text = "Nilai: " + score.ToString();
	}


	public void showArrows() {
		arrowText.text = "Panahan: " + arrows.ToString ();
	}

	public void createArrow(bool hitTarget) {
		Camera.main.GetComponent<camMovement> ().resetCamera ();
		stringPullSoundPlayed = false;
		stringReleaseSoundPlayed = false;
		arrowSwooshSoundPlayed = false;
		if (arrows > 0) {
			if (hitTarget) {
				float x = Random.Range(-1f,8f);
				float y = Random.Range(-3f,1f);
				Vector3 position = target.transform.position;
				position.x = x;
				position.y = y;
				target.transform.position = position;
            }else
            {
                GameObject rt1 = (GameObject)Instantiate(risingText, new Vector3(0, 0, 0), Quaternion.identity);
                rt1.transform.position = this.transform.position + new Vector3(0, 0, 0);
                rt1.GetComponent<TextMesh>().text = "Yah Tidak Kena, Coba lagi yaaaaa";
            }
			this.transform.localRotation = Quaternion.identity;
			arrow = Instantiate (arrowPrefab, Vector3.zero, Quaternion.identity) as GameObject;
			arrow.name = "arrow";
			arrow.transform.localScale = this.transform.localScale;
			arrow.transform.localPosition = this.transform.position + new Vector3 (0.7f, 0, 0);
			arrow.transform.localRotation = this.transform.localRotation;
			arrow.transform.parent = this.transform;
			arrow.GetComponent<PanahRotation> ().setBow (gameObject);
			arrowShot = false;
			arrowPrepared = false;
            arrows --;
		}
		else {
			gameState = GameStates.over;
			gameOverCanvas.enabled = true;
			endscoreText.text = "Semua panah sudah dilepas dan nilai mu " + score + " points.";
		}
	}

	public void shootArrow() {
		if (arrow.GetComponent<Rigidbody>() == null) {
			arrowShot = true;
			arrow.AddComponent<Rigidbody>();
			arrow.transform.parent = gameManager.transform;
			arrow.GetComponent<Rigidbody>().AddForce (Quaternion.Euler (new Vector3(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z))*new Vector3(25f*length,0,0), ForceMode.VelocityChange);
		}
		arrowPrepared = false;
		stringPullout = stringRestPosition;

		Camera.main.GetComponent<camMovement> ().resetCamera ();
		Camera.main.GetComponent<camMovement> ().setArrow (arrow);

	}

	public void prepareArrow() {
		mouseRay1 = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(mouseRay1, out rayHit, 1000f) && arrowShot == false)
		{
			posX = this.rayHit.point.x;
			posY = this.rayHit.point.y;
			Vector2 mousePos = new Vector2(transform.position.x-posX,transform.position.y-posY);
			float angleZ = Mathf.Atan2(mousePos.y, mousePos.x + 21)*Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0,0,angleZ);
			length = mousePos.magnitude / 3f;
			length = Mathf.Clamp(length,0,1);
			stringPullout = new Vector3(-(0.44f+length), -0.06f, 2f);
			Vector3 arrowPosition = arrow.transform.localPosition;
			arrowPosition.x = (arrowStartX - length);
			arrow.transform.localPosition = arrowPosition;
		}
		arrowPrepared = true;
	}

	public void drawBowString() {
        bowStringLinerenderer = bowString.GetComponent<LineRenderer>();
        bowStringLinerenderer.SetPosition(0, bowStringPosition[0]);
        bowStringLinerenderer.SetPosition(1, stringPullout);
        bowStringLinerenderer.SetPosition(2, bowStringPosition[2]);
    }

	public void setPoints(int points){
		score += points;
		if (points == 50) {
			arrows++;
			GameObject rt1 = (GameObject)Instantiate(risingText, new Vector3(0,0,0),Quaternion.identity);
			rt1.transform.position = this.transform.position + new Vector3(0,0,0);
			rt1.transform.name = "target1";
			rt1.GetComponent<TextMesh>().text= "Keren, Lanjutkan";
		}
	}

	public void showHighscore() {
		menuCanvas.enabled = false;
		highscoreCanvas.enabled = true;
		actualHighscoreText.text = "Nilai Ttinggi: " + PlayerPrefs.GetInt ("Score") + " points";
		newHighscoreText.text = "Nilai Kamu: " + score + " points";
		if (score > PlayerPrefs.GetInt("Score"))
			newHighText.enabled = true;
		else
			newHighText.enabled = false;
	}

	public void hideHighScore() {
		menuCanvas.enabled = true;
		highscoreCanvas.enabled = false;
		if (score > PlayerPrefs.GetInt ("Score")) {
			PlayerPrefs.SetInt("Score",score);
		}
		resetGame();
	}

	public void checkHighScore() {
		gameOverCanvas.enabled = false;
		if (score > PlayerPrefs.GetInt ("Score")) {
			showHighscore();
		}
		else {
			menuCanvas.enabled = true;
			resetGame();
		}
	}

	public void startGame() {
		menuCanvas.enabled = false;
		highscoreCanvas.enabled = false;
		gameCanvas.enabled = true;
		gameState = GameStates.game;
	}

	public void showMenu() {
		menuCanvas.enabled = true;
		gameState = GameStates.menu;
		resetGame ();
	}
}
