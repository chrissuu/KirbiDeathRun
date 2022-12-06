using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class player_controller
{
    // A Test behaves as an ordinary method
    [Test]
    public void kirbi_on_left_track()
    {
        // ACT
        int track = 0; // left track
        float kirbi_pos = PlayerController.getKirbiPosX(track);

        // ASSERT
        Assert.AreEqual(-5.0f, kirbi_pos);
    }

    [Test]
    public void kirbi_on_right_track()
    {
        // ACT
        int track = 2; // right track
        float kirbi_pos = PlayerController.getKirbiPosX(track);

        // ASSERT
        Assert.AreEqual(5.0f, kirbi_pos);
    }
}
