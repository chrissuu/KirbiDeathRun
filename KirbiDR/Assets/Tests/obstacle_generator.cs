using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class obstacle_generator
{
    // A Test behaves as an ordinary method

    [Test]
    public void left_track_pos_retrieved()
    {
        // ACT
        int track = 0; // LEFT track
        float retrieved_pos = ObstacleGenerator.getTrackPosX(track);

        // ASSERT
        Assert.AreEqual(-5.0f, retrieved_pos);
    }

    [Test]
    public void right_track_pos_retrieved()
    {
        // ACT
        int track = 2; // RIGHT track
        float retrieved_pos = ObstacleGenerator.getTrackPosX(track);

        // ASSERT
        Assert.AreEqual(5.0f, retrieved_pos);
    }

    [Test]
    public void retrieving_invalid_track_defaults_to_middle_track_pos()
    {
        // ACT
        int track = -1; // INVALID track
        float retrieved_pos = ObstacleGenerator.getTrackPosX(track);

        // ASSERT
        Assert.AreEqual(0.0f, retrieved_pos);
    }

}
