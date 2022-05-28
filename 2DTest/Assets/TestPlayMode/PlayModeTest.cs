using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class PlayModeTest
{
    [UnityTest]
    public IEnumerator Jump()
    {
        SceneManager.LoadScene(0);

        yield return new WaitForSeconds(2);

        GameObject player = GameObject.Find("Player");
        Movement move = player.GetComponent<Movement>();

        Assert.AreEqual(move.jumps, move.jumps = 2);
    }

    [UnityTest]
    public IEnumerator Right()
    {
        SceneManager.LoadScene(0);

        yield return new WaitForSeconds(2);

        GameObject player = GameObject.Find("Player");
        Movement move = player.GetComponent<Movement>();
        
        Assert.IsTrue(player.transform.position.x >= 0.1f);
    }
}
