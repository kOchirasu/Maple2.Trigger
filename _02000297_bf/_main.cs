namespace Maple2.Trigger._02000297_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {6100, 6200});
                context.SetAgent(arg1: new[] {101, 102, 103, 104, 105, 106, 121, 122, 123, 124, 125, 126, 127, 128}, arg2: false);
                context.SetUserValue(key: "BattleStart", value: 0);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateLoadingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BattleStart") == 1) {
                    context.State = new StateLoadingDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBossBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02000297_BF__MAIN__0$", arg3: 5000, arg4: "0");
                context.SetAgent(arg1: new[] {101, 102, 103, 104, 105, 106, 121, 122, 123, 124, 125, 126, 127, 128}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBossBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {6100});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {6200})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}