using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000006_me {
    public static class _goal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "gameStart") == 1) {
                    return new State결승점(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결승점 : TriggerState {
            internal State결승점(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 401, isOnlyWinner: true, expRate: 1.0f);
                context.MiniGameGiveReward(winnerBoxId: 401, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 401, isOnlyWinner: true, type: MiniGame.CrazyRunners);
                context.AddBuff(boxIds: new []{401}, skillId: 70000019, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State결승점(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
