using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{

   public AudioSource cell_membrane;
    public AudioSource Golgi;
    public AudioSource Lyso;
    public AudioSource Nucleus;
    public AudioSource Centro;
    public AudioSource Mitho;
    public AudioSource Endo;


    public GameObject gogli_pannel;
    public GameObject mitho_pannel;
    public GameObject cellmeme_pannel;
    public GameObject nucleus_pannel;
    public GameObject centro_pannel;
    public GameObject lyso_pannel;
    public GameObject endo_pannel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                //Select Stage
                if (hit.transform.name == "membrane")
                {
                    Debug.Log("mil gaya");
                    cell_membrane.Play();
                    Golgi.Stop();
                    Lyso.Stop();
                    Nucleus.Stop();
                    Centro.Stop();
                    Mitho.Stop();
                    Endo.Stop();
                    gogli_pannel.SetActive(false);
                    mitho_pannel.SetActive(false);
                    nucleus_pannel.SetActive(false);
                    cellmeme_pannel.SetActive(true);
                    centro_pannel.SetActive(false);
                    endo_pannel.SetActive(false);
                }

                if (hit.transform.name == "Golgi")
                {
                    Debug.Log("mil gaya 2");
                    Golgi.Play();
                    cell_membrane.Stop();
                    Lyso.Stop();
                    Nucleus.Stop();
                    Centro.Stop();
                    Mitho.Stop();
                    Endo.Stop();
                    gogli_pannel.SetActive(true);
                    nucleus_pannel.SetActive(false);
                    mitho_pannel.SetActive(false);
                    cellmeme_pannel.SetActive(false);
                    lyso_pannel.SetActive(false);
                    centro_pannel.SetActive(false);
                    endo_pannel.SetActive(false);
                }

                if (hit.transform.name == "Lyso")
                {
                    Debug.Log("mil gaya 3");
                    Golgi.Stop();
                    cell_membrane.Stop();
                    Lyso.Play();
                    Nucleus.Stop();
                    Centro.Stop();
                    Mitho.Stop();
                    Endo.Stop();
                    gogli_pannel.SetActive(false);
                    mitho_pannel.SetActive(false);
                    nucleus_pannel.SetActive(false);
                    cellmeme_pannel.SetActive(false);
                    lyso_pannel.SetActive(true);
                    centro_pannel.SetActive(false);
                    endo_pannel.SetActive(false);

                }
                if (hit.transform.name == "Nucleus")
                {
                    Debug.Log("mil gaya 4");
                    Golgi.Stop();
                    cell_membrane.Stop();
                    Lyso.Stop();
                    Nucleus.Play();
                    Centro.Stop();
                    Mitho.Stop();
                    Endo.Stop();
                    gogli_pannel.SetActive(false);
                    mitho_pannel.SetActive(false);
                    nucleus_pannel.SetActive(true);
                    cellmeme_pannel.SetActive(false);
                    lyso_pannel.SetActive(false);
                    centro_pannel.SetActive(false);
                    endo_pannel.SetActive(false);
                }
                if (hit.transform.name == "Centro")
                {
                    Debug.Log("mil gaya 5");
                    Golgi.Stop();
                    cell_membrane.Stop();
                    Lyso.Stop();
                    Nucleus.Stop();
                    Centro.Play();
                    Mitho.Stop();
                    Endo.Stop();
                    gogli_pannel.SetActive(false);
                    mitho_pannel.SetActive(false);
                    nucleus_pannel.SetActive(false);
                    cellmeme_pannel.SetActive(false);
                    lyso_pannel.SetActive(false);
                    centro_pannel.SetActive(true);
                    endo_pannel.SetActive(false);

                }
                if (hit.transform.name == "Mitho")
                {
                    Debug.Log("mil gaya 5");
                    Golgi.Stop();
                    cell_membrane.Stop();
                    Lyso.Stop();
                    Nucleus.Stop();
                    Centro.Stop();
                    Mitho.Play();
                    Endo.Stop();

                    mitho_pannel.SetActive(true);
                    gogli_pannel.SetActive(false);
                    nucleus_pannel.SetActive(false);
                    cellmeme_pannel.SetActive(false);
                    lyso_pannel.SetActive(false);
                    centro_pannel.SetActive(false);
                    endo_pannel.SetActive(false);
                }
                if (hit.transform.name == "Endo")
                {
                    Debug.Log("mil gaya 5");
                    Golgi.Stop();
                    cell_membrane.Stop();
                    Lyso.Stop();
                    Nucleus.Stop();
                    Centro.Stop();
                    Mitho.Stop();
                    Endo.Play();

                    gogli_pannel.SetActive(false);
                    mitho_pannel.SetActive(false);
                    nucleus_pannel.SetActive(false);
                    cellmeme_pannel.SetActive(false);
                    lyso_pannel.SetActive(false);
                    centro_pannel.SetActive(false);
                    endo_pannel.SetActive(true);
                }



            }

          
        }

        if (Input.GetMouseButtonDown(1)) {
            Golgi.Stop();
            cell_membrane.Stop();
            Lyso.Stop();
            Nucleus.Stop();
            Centro.Stop();
            Mitho.Stop();
            Endo.Stop();
            gogli_pannel.SetActive(false);
            mitho_pannel.SetActive(false);
            nucleus_pannel.SetActive(false);
            cellmeme_pannel.SetActive(false);
            lyso_pannel.SetActive(false);
            centro_pannel.SetActive(false);
            endo_pannel.SetActive(false);
        }

    }
}
