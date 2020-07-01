namespace Maple2.Trigger._02000486_bf {
    public static class _100_dualkill {
        public class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckDualKill", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckDualKill") == 1) {
                    context.State = new StateCheckDualKill(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckDualKill : TriggerState {
            internal StateCheckDualKill(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    context.State = new StateLionBlueDead(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {901})) {
                    context.State = new StateLionRedDead(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLionBlueDead : TriggerState {
            internal StateLionBlueDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "ChangeLionDualKill");
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLionRedDead : TriggerState {
            internal StateLionRedDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "ChangeLionDualKill");
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
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