using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Vuforia
{
    public class TargetScript : MonoBehaviour
    {
        public Button Button1;
        
        public Transform PanelUI;
        public Transform SofaPanel;
        public Transform ChairPanel;
        public Transform BedPanel;

        public List<Transform> Panels;

        public List<Button> SofaButtons;
        public List<Button> ChairButtons;
        public List<Button> BedButtons;

        public List<Button> SofaImages;
        public List<Button> ChairImages;
        public List<Button> BedImages;

        //public List<Button> CategoryButtons;

        private int a; 

        public void EnterShop()
        {
            Button1.gameObject.SetActive(false);
            PanelUI.gameObject.SetActive(true);
        }

        private void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
            foreach (TrackableBehaviour tb in tbs)
            {
                
                Button1.gameObject.SetActive(true);
            }
        }

        public void DisplayPanel(int a)
        {
            for(int i=0;i<Panels.Count;i++)
            {
                if(i!=a)
                {
                    Panels[i].gameObject.SetActive(false);
                }
                else
                {
                    Panels[a].gameObject.SetActive(true);
                    PanelUI.gameObject.SetActive(false);
                }
            }
        }

        public void BackButton()
        {
            PanelUI.gameObject.SetActive(true);

            foreach(var listofpanels in Panels)
            {
                listofpanels.gameObject.SetActive(false);
            }

            foreach(var listofsofapanels in SofaImages)
            {
                listofsofapanels.gameObject.SetActive(false);
            }

            foreach(var listofchairpanels in ChairImages)
            {
                listofchairpanels.gameObject.SetActive(false);
            }

            foreach(var listofbedpanels in BedImages)
            {
                listofbedpanels.gameObject.SetActive(false);
            }

            SceneManager.LoadScene("Scene_1");
        }

        public void DisplaySofa(int a)
        {
            SofaPanel.gameObject.SetActive(true);

            foreach (var listofpanels in Panels)
            {
                listofpanels.gameObject.SetActive(false);
            }

            for (int i=0;i<SofaButtons.Count;i++)
            {
                if(i!=a)
                {
                    SofaImages[i].gameObject.SetActive(false);
                }
                else
                {
                    SofaImages[a].gameObject.SetActive(true);
                    PanelUI.gameObject.SetActive(false);
                }
            }
        }

        public void DisplayChair(int a)
        {
            ChairPanel.gameObject.SetActive(true);

            foreach (var listofpanels in Panels)
            {
                listofpanels.gameObject.SetActive(false);
            }

            for (int i=0;i<ChairButtons.Count;i++)
            {
                if(i!=a)
                {
                    ChairImages[i].gameObject.SetActive(false);
                }
                else
                {
                    ChairImages[a].gameObject.SetActive(true);
                    PanelUI.gameObject.SetActive(false);
                }
            }
        }

        public void DisplayBed(int a)
        {
            BedPanel.gameObject.SetActive(true);

            foreach (var listofpanels in Panels)
            {
                listofpanels.gameObject.SetActive(false);
            }

            for (int i=0;i<BedButtons.Count;i++)
            {
                if(i!=a)
                {
                    BedImages[i].gameObject.SetActive(false);
                }
                else
                {
                    BedImages[a].gameObject.SetActive(true);
                    PanelUI.gameObject.SetActive(false);
                }
            }
        }
    }

}
