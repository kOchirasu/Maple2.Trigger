namespace Maple2.Trigger._02100009_bf {
    public static class _main {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State타이머설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머설정 : TriggerState {
            internal State타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: true);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(id: "10000", arg2: 300, arg3: true, arg4: true, arg5: 0);
            }

            public override TriggerState Execute() {
                return new State끝(context);
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {100000001}) && context.MonsterDead(arg1: new[] {100000002})) {
                    return new StateSuccess(context);
                }

                if (context.TimeExpired(arg1: "10000")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "10000");
            }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuccess_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 1, script: "$02100009_BF__text__0$", arg3: 4000);
            }
        }

        private class StateSuccess_2 : TriggerState {
            internal StateSuccess_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.DungeonClear();
                    return new StateSuccess_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }
        }

        private class StateSuccess_3 : TriggerState {
            internal StateSuccess_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 50000230, arg3: 1, arg4: false, arg5: false);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Find02100009");
                context.SetEventUI(arg1: 7, script: "$02100009_BF__MAIN__1$", arg3: 2000, arg4: "0");
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "02100009_2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 50000230, arg3: 1, arg4: false, arg5: false);
                context.SetEventUI(arg1: 5, script: "$02100009_BF__MAIN__0$", arg3: 2000, arg4: "0");
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}