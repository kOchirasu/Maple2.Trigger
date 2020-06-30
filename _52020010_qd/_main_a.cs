using System;

namespace Maple2.Trigger._52020010_qd {
    public static class _main_a {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetActor(arg1: 8001, arg2: false, arg3: "Event_01_A");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200045},
                    arg3: new byte[] {2})) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "!!!", duration: 1000, delayTick: 0);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetActor(arg1: 8001, arg2: true, arg3: "Event_03_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8001, arg2: false, arg3: "Event_03_A");
                context.CameraReset(interpolationTime: 1f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}