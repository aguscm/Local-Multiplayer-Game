using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

namespace Complete
{
    public class GameManager : MonoBehaviour
    {
        //[SerializeField] public TankInputSystem tankInputSystem;
        static public int m_numberOfPlayers = 2;             // The number of players of the game
        static public int m_maxNumberOfPlayers = 4;         // The maximum number of players in the game
        public int m_NumRoundsToWin = 5;            // The number of rounds a single player has to win to win the game
        public float m_StartDelay = 3f;             // The delay between the start of RoundStarting and RoundPlaying phases
        public float m_EndDelay = 3f;               // The delay between the end of RoundPlaying and RoundEnding phases
        public CameraControl m_CameraControl;       // Reference to the CameraControl script for control during different phases
        public Text m_MessageText;                  // Reference to the overlay Text to display winning text, etc.
        public GameObject m_TankPrefab;             // Reference to the prefab the players will control
        public TankManager[] m_Tanks;               // A collection of managers for enabling and disabling different aspects of the tanks
        public Camera m_OverheadCamera;             // This camera will appear with 3 players
        public Camera m_mainCam;                    //Reference to the mainCam of the game

        
        private int m_RoundNumber;                  // Which round the game is currently on
        private WaitForSeconds m_StartWait;         // Used to have a delay whilst the round starts
        private WaitForSeconds m_EndWait;           // Used to have a delay whilst the round or game ends
        private TankManager m_RoundWinner;          // Reference to the winner of the current round.  Used to make an announcement of who won
        private TankManager m_GameWinner;           // Reference to the winner of the game.  Used to make an announcement of who won

        public GameObject m_UIPlayerSelector;       // Reference to the Player Selector UI
        public GameObject m_UITextMsg;              // Reference to the UI Main Text
        private PlayerInputManager playerInputManager;
        

        //public MultiplayerEventSystem multiplayerEventSystem;
        private void Awake()
        {
            playerInputManager = GetComponent<PlayerInputManager>();
        }
        private void Start()
        {
            // Create the delays so they only have to be made once
            m_StartWait = new WaitForSeconds (m_StartDelay);
            m_EndWait = new WaitForSeconds (m_EndDelay);
            //Saves the info of the mainCam
            m_mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        }

        void Update()
        {

        }

        public void StartGame(int numberOfPlayers)
        {
            SetNumberOfPlayers(numberOfPlayers);
            SpawnAllTanks();
            SetCameraTargets();
            RearrangeCameras();

            // Once the tanks have been created and the camera is using them as targets, start the game
            m_CameraControl.enabled = true;
            StartCoroutine(GameLoop());
        }

        public void SetNumberOfPlayers(int number)
        {
            m_numberOfPlayers = number;


        }

        public void AddPlayer()
        {
            if (m_numberOfPlayers <= m_maxNumberOfPlayers)
            {
                m_numberOfPlayers++;
                SpawnTank(m_numberOfPlayers);
                RearrangeCameras();
            }else
            {
                Debug.Log("It is not possible to add more than " + m_maxNumberOfPlayers + " players");
            }
        }

        public void OnPlayerJoined(PlayerInput input)
        {
            InputUser.PerformPairingWithDevice(Keyboard.current, input.user);
            input.SwitchCurrentControlScheme("Keyboard" + (input.gameObject.GetComponent<TankMovement>().m_PlayerNumber), Keyboard.current);

        }
        private void SpawnAllTanks()
		{
            //Saves the info of the mainCam
			Camera mainCam = GameObject.Find ("Main Camera").GetComponent<Camera>();

            // For all the players...
            for (int i = 0; i < m_maxNumberOfPlayers; i++)
			{
                SpawnTank(i);
            }

            mainCam.gameObject.SetActive (false);

		}

        void SpawnTank(int i)
        {

            // ... create the tank, set their player number and references needed for control
            m_Tanks[i].m_Instance =
                Instantiate(m_TankPrefab, m_Tanks[i].m_SpawnPoint.position, m_Tanks[i].m_SpawnPoint.rotation) as GameObject;
            m_Tanks[i].m_PlayerNumber = i + 1;
            m_Tanks[i].Setup();

            //Changes the layer of the followcam
            var followCam = m_Tanks[i].m_Instance.transform.Find("Follow Cam");
            Debug.Log(followCam);
            if (followCam != null)
            {
                
                followCam.gameObject.layer = LayerMask.NameToLayer("CamP" + (i + 1));
                Debug.Log("follow cam of " + i + " is " + followCam.gameObject.layer);
            }
            //AddCamera(i, m_mainCam);
            //If the tank is not still playing, deactivate its controllers
            //if (i >= m_numberOfPlayers)
            //{
            //    DisableTank(m_Tanks[i].m_Instance);
            //}
        }

        private void DisableTank(GameObject tank)
        {
            foreach (MonoBehaviour component in tank.GetComponents<MonoBehaviour>())
            {
                component.enabled = false;
            }

            tank.GetComponent<PlayerInput>().enabled = true;

         
        }

		private void AddCamera (int i, Camera mainCam)
        {
			GameObject childCam = new GameObject ("Camera" + (i + 1));
			Camera newCam = childCam.AddComponent<Camera>();		
			newCam.CopyFrom (mainCam);
            childCam.AddComponent<CinemachineBrain>();

            childCam.transform.parent = m_Tanks[i].m_Instance.transform;

            newCam.cullingMask |= 1 << LayerMask.NameToLayer("CamP" + (i+1));

            //Assign the cam to the tank
            m_Tanks[i].m_PlayerCamera = newCam;
            newCam.enabled = false;

        }

        private void RearrangeCameras()
        {
            foreach (TankManager tank in m_Tanks)
            {
                Destroy(tank.m_PlayerCamera);
            }
            foreach (Camera camera in Camera.allCameras)
            {
                camera.enabled = false;
                Debug.Log(camera.gameObject.name);
            }

            int tanksAlive = 0;
            List<TankManager> TanksAlive = new List<TankManager>();

            //Search for the tanks alive in this moment
            for (int i = 0; i < m_numberOfPlayers; i++)
            {
                if (!m_Tanks[i].m_TankHealth.isDead())
                {
                    tanksAlive++;
                    TanksAlive.Add(m_Tanks[i]);
                    AddCamera(i, m_mainCam);

                    //m_Tanks[i].m_PlayerCamera.enabled = true;
                }
            }
            switch (TanksAlive.Count)
            {
                case 2:
                    Debug.Log("2 cameras");
                    TanksAlive[0].m_PlayerCamera.rect = new Rect(0.0f, 0.5f, 0.89f, 0.5f);
                    TanksAlive[1].m_PlayerCamera.rect = new Rect(0.11f, 0.0f, 0.89f, 0.5f);
                    m_OverheadCamera.gameObject.SetActive(false);
                    break;
                case 3:
                    Debug.Log("3 cameras");
                    TanksAlive[0].m_PlayerCamera.rect = new Rect(0.02f, 0.51f, 0.48f, 0.48f);
                    TanksAlive[1].m_PlayerCamera.rect = new Rect(0.51f, 0.51f, 0.48f, 0.48f);
                    TanksAlive[2].m_PlayerCamera.rect = new Rect(0.02f, 0.01f, 0.48f, 0.48f);
                    m_OverheadCamera.gameObject.SetActive(true);
                    m_OverheadCamera.rect = new Rect(0.51f, 0.01f, 0.48f, 0.48f);
                    break;
                case 4:
                    Debug.Log("4 cameras");
                    TanksAlive[0].m_PlayerCamera.rect = new Rect(0.02f, 0.51f, 0.48f, 0.48f);
                    TanksAlive[1].m_PlayerCamera.rect = new Rect(0.51f, 0.51f, 0.48f, 0.48f);
                    TanksAlive[2].m_PlayerCamera.rect = new Rect(0.02f, 0.01f, 0.48f, 0.48f);
                    TanksAlive[3].m_PlayerCamera.rect = new Rect(0.51f, 0.01f, 0.48f, 0.48f);
                    m_OverheadCamera.gameObject.SetActive(false);
                    break;
            }
        }


        private void SetCameraTargets()
        {
            // Create a collection of transforms the same size as the number of tanks
            Transform[] targets = new Transform[m_numberOfPlayers];

            // For each of these transforms...
            for (int i = 0; i < targets.Length; i++)
            {
                // ... set it to the appropriate tank transform
                targets[i] = m_Tanks[i].m_Instance.transform;
            }

            // These are the targets the camera should follow
            m_CameraControl.m_Targets = targets;
        }


        // This is called from start and will run each phase of the game one after another
        private IEnumerator GameLoop()
        {
            //// Start off by running the 'GameStarting' coroutine but don't return until it's finished
            //yield return StartCoroutine(GameStarting());

            // Continue by running the 'RoundStarting' coroutine but don't return until it's finished
            yield return StartCoroutine (RoundStarting());

            // Once the 'RoundStarting' coroutine is finished, run the 'RoundPlaying' coroutine but don't return until it's finished
            yield return StartCoroutine (RoundPlaying());

            // Once execution has returned here, run the 'RoundEnding' coroutine, again don't return until it's finished
            yield return StartCoroutine (RoundEnding());

            // This code is not run until 'RoundEnding' has finished.  At which point, check if a game winner has been found
            if (m_GameWinner != null)
            {
                // If there is a game winner, restart the level
                SceneManager.LoadScene (0);
            }
            else
            {
                // If there isn't a winner yet, restart this coroutine so the loop continues
                // Note that this coroutine doesn't yield.  This means that the current version of the GameLoop will end
                StartCoroutine (GameLoop());
            }
        }

        private IEnumerator GameStarting() {

            m_UIPlayerSelector.SetActive(false);
            m_UITextMsg.SetActive(true);

            yield return m_StartWait;

            m_UIPlayerSelector.SetActive(true);
            m_UITextMsg.SetActive(false);
        }

        private IEnumerator RoundStarting()
        {
            // As soon as the round starts reset the tanks and make sure they can't move
            ResetAllTanks();
            DisableTankControl();

            // Snap the camera's zoom and position to something appropriate for the reset tanks
            m_CameraControl.SetStartPositionAndSize();

            // Increment the round number and display text showing the players what round it is
            m_RoundNumber++;
            m_MessageText.text = "ROUND " + m_RoundNumber;

            // Wait for the specified length of time until yielding control back to the game loop
            yield return m_StartWait;
        }


        private IEnumerator RoundPlaying()
        {
            // As soon as the round begins playing let the players control the tanks
            EnableTankControl();

            // Clear the text from the screen
            m_MessageText.text = string.Empty;

            // While there is not one tank left...
            while (!OneTankLeft())
            {
                // ... return on the next frame
                yield return null;
            }
        }


        private IEnumerator RoundEnding()
        {
            // Stop tanks from moving
            DisableTankControl();

            // Clear the winner from the previous round
            m_RoundWinner = null;

            // See if there is a winner now the round is over
            m_RoundWinner = GetRoundWinner();

            // If there is a winner, increment their score
            if (m_RoundWinner != null)
                m_RoundWinner.m_Wins++;

            // Now the winner's score has been incremented, see if someone has one the game
            m_GameWinner = GetGameWinner();

            // Get a message based on the scores and whether or not there is a game winner and display it
            string message = EndMessage();
            m_MessageText.text = message;

            // Wait for the specified length of time until yielding control back to the game loop
            yield return m_EndWait;
        }


        // This is used to check if there is one or fewer tanks remaining and thus the round should end
        private bool OneTankLeft()
        {
            // Start the count of tanks left at zero
            int numTanksLeft = 0;

            // Go through all the tanks...
            for (int i = 0; i < m_numberOfPlayers; i++)
            {
                // ... and if they are active, increment the counter
                if (m_Tanks[i].m_Instance.activeSelf)
                    numTanksLeft++;
            }

            // If there are one or fewer tanks remaining return true, otherwise return false
            return numTanksLeft <= 1;
        }
        
        
        // This function is to find out if there is a winner of the round
        // This function is called with the assumption that 1 or fewer tanks are currently active
        private TankManager GetRoundWinner()
        {
            // Go through all the tanks...
            for (int i = 0; i < m_numberOfPlayers; i++)
            {
                // ... and if one of them is active, it is the winner so return it
                if (m_Tanks[i].m_Instance.activeSelf)
                {
                    return m_Tanks[i];
                }
            }

            // If none of the tanks are active it is a draw so return null
            return null;
        }


        // This function is to find out if there is a winner of the game
        private TankManager GetGameWinner()
        {
            // Go through all the tanks...
            for (int i = 0; i < m_numberOfPlayers; i++)
            {
                // ... and if one of them has enough rounds to win the game, return it
                if (m_Tanks[i].m_Wins == m_NumRoundsToWin)
                {
                    return m_Tanks[i];
                }
            }

            // If no tanks have enough rounds to win, return null
            return null;
        }


        // Returns a string message to display at the end of each round.
        private string EndMessage()
        {
            // By default when a round ends there are no winners so the default end message is a draw
            string message = "DRAW!";

            // If there is a winner then change the message to reflect that
            if (m_RoundWinner != null)
            {
                message = m_RoundWinner.m_ColoredPlayerText + " WINS THE ROUND!";
            }

            // Add some line breaks after the initial message
            message += "\n\n\n\n";

            // Go through all the tanks and add each of their scores to the message
            for (int i = 0; i < m_numberOfPlayers; i++)
            {
                message += m_Tanks[i].m_ColoredPlayerText + ": " + m_Tanks[i].m_Wins + " WINS\n";
            }

            // If there is a game winner, change the entire message to reflect that
            if (m_GameWinner != null)
            {
                message = m_GameWinner.m_ColoredPlayerText + " WINS THE GAME!";
            }

            return message;
        }


        // This function is used to turn all the tanks back on and reset their positions and properties
        private void ResetAllTanks()
        {
            for (int i = 0; i < m_maxNumberOfPlayers; i++)
            {
                m_Tanks[i].Reset();
            }
        }


        private void EnableTankControl()
        {
            for (int i = 0; i < m_maxNumberOfPlayers; i++)
            {
                m_Tanks[i].EnableControl();
            }
        }


        private void DisableTankControl()
        {
            for (int i = 0; i < m_maxNumberOfPlayers; i++)
            {
                m_Tanks[i].DisableControl();
            }
        }
    }
}