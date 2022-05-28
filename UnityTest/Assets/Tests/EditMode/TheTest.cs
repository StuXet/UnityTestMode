using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TheTest
{
        Score score = new Score();

    [Test]
    public void TestWin()
    {
        Assert.IsTrue(score.WinnerWinnerChickenDinner());    
    }

    [Test]
    public void TestRandomWin()
    {
        Assert.IsTrue(score.RandomDinner());    
    }

    public IEnumerator TheTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
