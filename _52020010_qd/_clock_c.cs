using System;

namespace Maple2.Trigger._52020010_qd {
    public static class _clock_c {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5008}, arg2: false);
                context.SetEffect(arg1: new int[] {5009}, arg2: false);
                context.SetEffect(arg1: new int[] {5010}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2004})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001273}, arg2: 0)) {
                    context.State = new StateEvent_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5007}, arg2: true);
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.CreateMonster(arg1: new int[] {302}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5008}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 302, arg2: "Bore_B", arg3: 18000f);
                context.AddBalloonTalk(spawnPointID: 302, msg: "엄마 무서워...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 301, msg: "울지마렴... 조금 있으면 괜찮아 질거야...", duration: 2800,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5009}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 301, msg: "여보? 어디 간 거에요!", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5010}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 301, msg: "여보!!!", duration: 2800, delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 302, msg: "엄마... 아빠... 무서워...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEvent_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5007}, arg2: false);
                context.SetEffect(arg1: new int[] {5008}, arg2: false);
                context.SetEffect(arg1: new int[] {5009}, arg2: false);
                context.SetEffect(arg1: new int[] {5010}, arg2: false);
                context.DestroyMonster(arg1: new int[] {301});
                context.DestroyMonster(arg1: new int[] {302});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}