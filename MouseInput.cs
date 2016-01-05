using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class MouseInput : NetworkBehaviour
{
    void RaycastTest()
    {
        if (!isLocalPlayer)
            return;
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(MousePos, Vector2.zero);
        Debug.DrawRay(MousePos, Vector2.down);
        if (hit.collider != null)
            if (Input.GetKeyDown(KeyCode.Mouse0))
                CmdDoDamage(hit.collider);
           
    }
    [Command]
    void CmdDoDamage(Collider2D c)
    {
            Enemy enemy = c.GetComponent<Enemy>();
            enemy.TakeDamage(10);
    }
    void Update()
    {
        RaycastTest();
    }
}
