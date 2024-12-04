using System.Net.Sockets;
using UnityEngine;

public class BuildController : MonoBehaviour
{
    public GameObject foundation;
    public GameObject foundationPreview;

    Transform grid;

    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Grid")
            {
                grid = hit.transform;
                foundationPreview.transform.position = grid.transform.position;

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    GameObject spawnFoundation = Instantiate(foundation, grid.transform.position, Quaternion.identity);
                }
            }
        }
        else 
        {
            foundationPreview.transform.position = hit.point;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject spawnFoundation = Instantiate(foundation, hit.point, Quaternion.identity);
            }
        }
    }
}
