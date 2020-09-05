using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateoObjectOnClick : MonoBehaviour
{
    public GameObject firstTrigger;
    public GameObject secondTrigger;
    public GameObject thirdTrigger;
    public GameObject fourthTrigger;
    public GameObject fifthTrigger;
    public GameObject sixthTrigger;
    public GameObject seventhTrigger;
    public GameObject eighthTrigger;
    public GameObject ninethTrigger;
    public GameObject tenthTrigger;
    public GameObject eleventhTrigger;
    public GameObject twelfthTrigger;
    public GameObject thirteenthTrigger;
    public GameObject fourteenthTrigger;
    public GameObject fifteenthTrigger;
    public GameObject sixteenthTrigger;
    public GameObject seventeenthTrigger;
    public GameObject eighteenthTrigger;
    public GameObject nineteenthTrigger;
    public GameObject tweentiethTrigger;
    public GameObject twentyFirstTrigger;
    public GameObject twentySecondTrigger;
    public GameObject twentyThirdTrigger;
    public GameObject twentyFourthTrigger;
    public GameObject twentyFifthTrigger;
    public GameObject twentySixthTrigger;
    public GameObject twentySeventhTrigger;
    public GameObject twentyEighthTrigger;
    public GameObject twentyNinethTrigger;
    public GameObject thirtiethTrigger;
    public GameObject thirtyFirstTrigger;
    public GameObject thirtySecondTrigger;
    public GameObject thirtyThirdTrigger;
    public GameObject thirtyFourthTrigger;
    public GameObject thirtyFifthTrigger;
    public GameObject thirtySixthTrigger;
    public GameObject thirtySeventhTrigger;
    public GameObject thirtyEighthTrigger;
    public GameObject thirtyNinethTrigger;
    public GameObject fortiethTrigger;
    public GameObject fortyFirstTrigger;
    public GameObject fortySecondTrigger;
    public GameObject fortyThirdTrigger;
    public GameObject fortyFourthTrigger;
    public GameObject fortyFifthTrigger;
    public GameObject fortySixthTrigger;
    public GameObject fortySeventhTrigger;
    public GameObject fortyEighthTrigger;
    public GameObject fortyNinethTrigger;
    public GameObject fiftiethTrigger;
    private GameObject InstantiatedObj;

    Ray ray;
    RaycastHit hit;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.collider.name == "Trigger1")
                {
                    Debug.Log("Player 0 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(firstTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger2")
                {
                    Debug.Log("Player 1 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(secondTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger3")
                {
                    Debug.Log("Player 2 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirdTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger4")
                {
                    Debug.Log("Player 3 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fourthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger5")
                {
                    Debug.Log("Player 4 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fifthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger6")
                {
                    Debug.Log("Player 5 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(sixthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger7")
                {
                    Debug.Log("Player 6 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(seventhTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger8")
                {
                    Debug.Log("Player 7 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(eighthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger9")
                {
                    Debug.Log("Player 8 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(ninethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger10")
                {
                    Debug.Log("Player 9 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(tenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger11")
                {
                    Debug.Log("Player 10 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(eleventhTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger12")
                {
                    Debug.Log("Player 11 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twelfthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger13")
                {
                    Debug.Log("Player 12 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirteenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger14")
                {
                    Debug.Log("Player 13 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fourteenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger15")
                {
                    Debug.Log("Player 14 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fifteenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger16")
                {
                    Debug.Log("Player 15 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(sixteenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger17")
                {
                    Debug.Log("Player 16 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(seventeenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger18")
                {
                    Debug.Log("Player 17 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(eighteenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger19")
                {
                    Debug.Log("Player 18 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(nineteenthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger20")
                {
                    Debug.Log("Player 19 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(tweentiethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger21")
                {
                    Debug.Log("Player 20 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentyFirstTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger22")
                {
                    Debug.Log("Player 21 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentySecondTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger23")
                {
                    Debug.Log("Player 22 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentyThirdTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger24")
                {
                    Debug.Log("Player 23 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentyFourthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger25")
                {
                    Debug.Log("Player 24 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentyFifthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger26")
                {
                    Debug.Log("Player 25 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentySixthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger27")
                {
                    Debug.Log("Player 26 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentySeventhTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger28")
                {
                    Debug.Log("Player 27 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentyEighthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger29")
                {
                    Debug.Log("Player 28 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(twentyNinethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger30")
                {
                    Debug.Log("Player 29 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtiethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger31")
                {
                    Debug.Log("Player 30 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtyFirstTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger32")
                {
                    Debug.Log("Player 31 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtySecondTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger33")
                {
                    Debug.Log("Player 32 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtyThirdTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger34")
                {
                    Debug.Log("Player 33 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtyFourthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger35")
                {
                    Debug.Log("Player 34 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtyFifthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger36")
                {
                    Debug.Log("Player 35 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtySixthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger37")
                {
                    Debug.Log("Player 36 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtySeventhTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger38")
                {
                    Debug.Log("Player 37 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtyEighthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger39")
                {
                    Debug.Log("Player 38 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(thirtyNinethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger40")
                {
                    Debug.Log("Player 39 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortiethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger41")
                {
                    Debug.Log("Player 40 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortyFirstTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger42")
                {
                    Debug.Log("Player 41 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortySecondTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger43")
                {
                    Debug.Log("Player 42 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortyThirdTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger44")
                {
                    Debug.Log("Player 43 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortyFourthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger45")
                {
                    Debug.Log("Player 44 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortyFifthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger46")
                {
                    Debug.Log("Player 45 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortySixthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger47")
                {
                    Debug.Log("Player 46 Should Appear");
                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortySeventhTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }

                if (hit.collider.name == "Trigger48")
                {
                    Debug.Log("Player 47 Should Appear");

                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortyEighthTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger49")
                {
                    Debug.Log("Player 48 Should Appear");

                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fortyNinethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
                if (hit.collider.name == "Trigger50")
                {
                    Debug.Log("Player 49 Should Appear");

                    Vector2 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
                    InstantiatedObj = Instantiate(fiftiethTrigger, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
                }
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Destroy(InstantiatedObj);
        }
    }
}
