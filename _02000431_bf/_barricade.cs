namespace Maple2.Trigger._02000431_bf {
    public static class _barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {80000, 80001, 80002, 80003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateCheckUser04_GuildRaid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckUser04_GuildRaid : TriggerState {
            internal StateCheckUser04_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) >= 4) {
                    return new StateMaxCount04_Start(context);
                }

                if (context.GetUserCount(boxId: 701) < 4) {
                    return new StateMaxCount04_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait : TriggerState {
            internal StateMaxCount04_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) >= 4) {
                    return new StateMaxCount04_Start(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateMaxCount04_Start(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMaxCount04_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Start : TriggerState {
            internal StateMaxCount04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override TriggerState Execute() {
                return new StateDungeonStart(context);
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999101, key: "start", value: 1);
                context.SetEffect(arg1: new[] {70001, 70002, 70003}, arg2: false);
                context.SetMesh(arg1: new[] {80000, 80001, 80002, 80003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State유저감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {706})) {
                    return new State카운트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000431_BF__BARRICADE__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State차단(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {80000, 80001, 80002, 80003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {70001, 70002, 70003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}