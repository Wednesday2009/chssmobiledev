using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TestScript_Transition : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton()
    {

        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "Button_1":
                SceneManager.LoadScene("CHSS_academic_Page");
                break;
            case "Button_2":
                SceneManager.LoadScene("CHSS_research_Page");
                break;
            case "Button_3":
                SceneManager.LoadScene("CHSS_publication_Page");
                break;
            case "Button_4":
                SceneManager.LoadScene("CHSS_F&S_Page");
                break;
            case "Button_5":
                SceneManager.LoadScene("CHSS_facility_Page");
                break;
            case "Button_6":
                SceneManager.LoadScene("CHSS_about_Page");
                break;
            case "sub_back_but":
                SceneManager.LoadScene("CHSS_Page");
                break;
            case "dept_button":
                SceneManager.LoadScene("CHSS_department_Page");
                break;
            case "degree_button":
                SceneManager.LoadScene("CHSS_degree_Page");
                break;
            case "doa_button":
                SceneManager.LoadScene("CHSS_doa_Page");
                break;
            case "doh_button":
                SceneManager.LoadScene("CHSS_doh_Page");
                break;
            case "dohk_button":
                SceneManager.LoadScene("CHSS_dohk_Page");
                break;
            case "doss_button":
                SceneManager.LoadScene("CHSS_doss_Page");
                break;
            case "baa_button":
                SceneManager.LoadScene("CHSS_BAA_Page");
                break;
            case "bsa_button":
                SceneManager.LoadScene("CHSS_BSA_Page");
                break;
            case "bacma_button":
                SceneManager.LoadScene("CHSS_BACMA_Page");
                break;
            case "bae_button":
                SceneManager.LoadScene("CHSS_BAE_Page");
                break;
            case "ess_button":
                SceneManager.LoadScene("");
                break;
            case "aurp_button":
                SceneManager.LoadScene("");
                break;
        }

    }
}
