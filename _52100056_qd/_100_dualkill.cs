namespace Maple2.Trigger._52100056_qd {
    public static class _100_dualkill {
        public class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckDualKill", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "CheckDualKill") == 1) {
                    return new StateCheckDualKill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckDualKill : TriggerState {
            internal StateCheckDualKill(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateLionBlueDead(context);
                }

                if (context.MonsterDead(arg1: new[] {901})) {
                    return new StateLionRedDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLionBlueDead : TriggerState {
            internal StateLionBlueDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "ChangeLionDualKill");
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLionRedDead : TriggerState {
            internal StateLionRedDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "ChangeLionDualKill");
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}