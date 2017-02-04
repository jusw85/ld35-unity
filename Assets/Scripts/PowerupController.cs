using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class PowerupController : MonoBehaviour {

    private DudeController dudeController;

    [HideInInspector]
    public string powerup = "";

    private void Start() {
        var dude = GameObject.FindGameObjectWithTag("Player");
        if (dude != null) {
            dudeController = dude.GetComponent<DudeController>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (dudeController != null && other.tag.Equals("Player")) {
            if (powerup.Equals("Freeze")) {
                dudeController.canFreeze = true;
            }
            Destroy(transform.parent.gameObject);
        }
    }

}
