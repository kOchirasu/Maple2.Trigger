using System;

namespace Maple2.Trigger._52020010_qd {
    public static class _clock_b {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2003})) {
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
                if (context.ObjectInteracted(arg1: new int[] {10001272}, arg2: 0)) {
                    context.State = new StateEvent_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_3001");
                context.AddBalloonTalk(spawnPointID: 203, msg: "와! 쾅쾅한다!", duration: 2500, delayTick: 0);
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
                context.AddBalloonTalk(spawnPointID: 202, msg: "여보... 우리 어쩌면 좋아요?", duration: 2800, delayTick: 0);
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
                context.AddBalloonTalk(spawnPointID: 201, msg: "일이 이렇게 되어버릴 줄은...", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 202, msg: "우리 도망 못가는거죠?", duration: 2800, delayTick: 1000);
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
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 203, msg: "쾅쾅! 쾅쾅!", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 201, msg: "난 대체 무얼 위해...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 202, msg: "여보!", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 201, msg: "!!!", duration: 2000, delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 201, msg: "여보, 내 딸... 모두 미안하오...", duration: 2000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 202, msg: "여보...", duration: 2000, delayTick: 1000);
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
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.DestroyMonster(arg1: new int[] {201});
                context.DestroyMonster(arg1: new int[] {202});
                context.DestroyMonster(arg1: new int[] {203});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}