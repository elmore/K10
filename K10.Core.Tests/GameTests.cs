using NUnit.Framework;
using System;

namespace K10.Core.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void GamePhaseIsSetupForFirstRound()
        {
            var game = new Game();

            var state1 = new GameState();

            var state2 = game.Turn(state1);

            Assert.AreEqual(GamePhase.Opening, state1.Phase);
        }
    }
}
