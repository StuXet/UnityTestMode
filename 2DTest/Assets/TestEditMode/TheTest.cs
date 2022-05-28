using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TheTest
{
    Movement move = new Movement();
    // A Test behaves as an ordinary method
    [Test]
    public void TheBestTest()
    {
        Assert.AreEqual(move.movementSpeed, move.movementSpeed = 10);
        Assert.AreEqual(move.jumpForce, move.jumpForce = 1);
    }
}
