namespace Maple2.Trigger._81000003_item {
    public static class _goal {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "gameStart") == 1) {
                    context.State = new State결승점(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결승점 : TriggerState {
            internal State결승점(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 401, isOnlyWinner: true, expRate: 1f);
                context.MiniGameGiveReward(winnerBoxId: 401, contentType: "UserOpenMiniGameExtraReward", gameName: "UserMassive_Crazyrunner");
                context.EndMiniGame(winnerBoxId: 401, isOnlyWinner: true, gameName: "UserMassive_Crazyrunner");
                context.AddBuff(arg1: new[] {401}, arg2: 70000132, arg3: 1);
                context.AddBuff(arg1: new[] {401}, arg2: 70000019, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State결승점(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}