namespace Maple2.Trigger._02100004_bf {
    public static class _achieve_tentomanfight {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "LastRoundStart", value: 0);
                context.SetUserValue(key: "LastRoundEnd", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "LastRoundStart") == 1) {
                    context.State = new StateMobCheck01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobCheck01 : TriggerState {
            internal StateMobCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {2000})) {
                    context.State = new StateMobCheck02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobCheck02 : TriggerState {
            internal StateMobCheck02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 102, arg2: new[] {2001})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2002})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2003})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2004})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2005})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2006})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2008})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2009})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2010})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2011})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2012})
                    && !context.NpcDetected(arg1: 102, arg2: new[] {2013})) {
                    context.State = new StateCheckSuccess(context);
                    return;
                }

                if (context.GetUserValue(key: "LastRoundEnd") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSuccess : TriggerState {
            internal StateCheckSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2000})) {
                    context.State = new StateMemberCheck(context);
                    return;
                }

                if (context.GetUserValue(key: "LastRoundEnd") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMemberCheck : TriggerState {
            internal StateMemberCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 102) == 10) {
                    context.State = new StateAchieve(context);
                    return;
                }

                if (context.GetUserValue(key: "LastRoundEnd") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAchieve : TriggerState {
            internal StateAchieve(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "TenToOneFight");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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