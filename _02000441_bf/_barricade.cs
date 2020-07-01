using System;

namespace Maple2.Trigger._02000441_bf {
    public static class _barricade {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateCheckUser04_GuildRaid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckUser04_GuildRaid : TriggerState {
            internal StateCheckUser04_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 4, arg3: "GreaterEqual")) {
                    context.State = new StateMaxCount04_Start(context);
                    return;
                }

                if (context.CountUsers(arg1: 701, arg2: 4, arg3: "Less")) {
                    context.State = new StateMaxCount04_Wait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait : TriggerState {
            internal StateMaxCount04_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 40012, textID: 40012, duration: 3000);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 4, arg3: "GreaterEqual")) {
                    context.State = new StateMaxCount04_Start(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMaxCount04_Start(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateMaxCount04_Wait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Start : TriggerState {
            internal StateMaxCount04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 904, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2038801, key: "start", value: 1);
                context.SetEffect(arg1: new int[] {70001}, arg2: false);
                context.SetEffect(arg1: new int[] {70002}, arg2: false);
                context.SetEffect(arg1: new int[] {70003}, arg2: false);
                context.SetMesh(arg1: new int[] {80000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {706})) {
                    context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000441_BF__BARRICADE__0$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State차단(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {70001}, arg2: true);
                context.SetEffect(arg1: new int[] {70002}, arg2: true);
                context.SetEffect(arg1: new int[] {70003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
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