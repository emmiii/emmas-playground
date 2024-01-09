using NUnit.Framework;
using Bowling_ClassLibrary;
using FluentAssertions;

namespace BowlingTest
{
    public class Tests
    {
        [Test]
        public void GutterGame()
        {
            var game = "--|--|--|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(0);
        }

        [Test]
        public void OnePinInEachFrame()
        {
            var game = "1-|1-|1-|1-|1-|1-|1-|1-|1-|1-||";
            Bowling.GetScore(game).Should().Be(10);
        }

        [Test]
        public void TwoPinsInAFrame()
        {
            var game = "--|12|--|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(3);
        }

        [Test]
        public void PinsInMultipleFrames()
        {
            var game = "5-|12|--|-2|--|--|8-|--|11|--||";
            Bowling.GetScore(game).Should().Be(20);
        }

        [Test]
        public void OneSpare()
        {
            var game = "--|-/|--|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(10);
        }

        [Test]
        public void OneSpareAndFollowingBall()
        {
            var game = "--|-/|1-|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(12);
        }

        [Test]
        public void OneStrike()
        {
            var game = "--|X|--|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(10);
        }

        [Test]
        public void OneStrikeAndFollowingFirstBall()
        {
            var game = "--|X|2-|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(14);
        }

        [Test]
        public void OneStrikeAndFollowingTwoBall()
        {
            var game = "--|X|24|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(22);
        }

        [Test]
        public void TwoSparesInARow()
        {
            var game = "--|5/|5/|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(25);
        }

        [Test]
        public void TwoStrikesInARow()
        {
            var game = "--|X|X|--|--|--|--|--|--|--||";
            Bowling.GetScore(game).Should().Be(30);
        }

        [Test]
        public void TwoStrikesAndFollowingPins()
        {
            var game = "--|X|X|42|2-|--|7-|--|--|--||";
            Bowling.GetScore(game).Should().Be(55);
        }

        [Test]
        public void SpareStrikeAndFollowingPins()
        {
            var game = "--|1/|X|42|2-|--|7-|--|--|--||";
            Bowling.GetScore(game).Should().Be(51);
        }

        [Test]
        public void AllStrikes()
        {
            var game = "X|X|X|X|X|X|X|X|X|X|X|X";
            Bowling.GetScore(game).Should().Be(300);
        }

        [Test]
        public void All5Spares()
        {
            var game = "5/|5/|5/|5/|5/|5/|5/|5/|5/|5/|5-|-";
            Bowling.GetScore(game).Should().Be(150);
        }

        [Test]
        public void FullGame()
        {
            var game = "X|7/|9-|X|-8|8/|-6|X|X|X|--|";
            Bowling.GetScore(game).Should().Be(150);
        }
    }
}