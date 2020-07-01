namespace Maple2.Trigger._52020009_qd {
    public static class _event {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetEffect(arg1: new[] {5202}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetEffect(arg1: new[] {5201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalk : TriggerState {
            internal StateWalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_Ready_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Ready_01 : TriggerState {
            internal StateEvent_Ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001267}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10001268}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10001269}, arg2: 1);
                context.AddBalloonTalk(spawnPointId: 101, msg: "이름... 내 이름이 기억나지 않아...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001267}, arg2: 0)) {
                    context.State = new StateEvent_A(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001268}, arg2: 0)) {
                    context.State = new StateEvent_B(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001269}, arg2: 0)) {
                    context.State = new StateEvent_C(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEvent_Ready_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Ready_02 : TriggerState {
            internal StateEvent_Ready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "누가 내 이름 좀 찾아줘!", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001267}, arg2: 0)) {
                    context.State = new StateEvent_A(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001268}, arg2: 0)) {
                    context.State = new StateEvent_B(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001269}, arg2: 0)) {
                    context.State = new StateEvent_C(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEvent_Ready_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A : TriggerState {
            internal StateEvent_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "아니야! 그건 내 이름이 적힌 책이 아니라고!", duration: 2800,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_A_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_End : TriggerState {
            internal StateEvent_A_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "그건 왕의 비밀병기와 관련된 책이란 말이야!", duration: 2800,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEvent_Ready_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_B : TriggerState {
            internal StateEvent_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "$map:02020010$의 거대 병기?", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_B_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_B_End : TriggerState {
            internal StateEvent_B_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "그런 책에 내 이름이 적혀 있을 리가 없잖아!", duration: 2800,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEvent_Ready_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C : TriggerState {
            internal StateEvent_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "그 책은! 내 일기장!", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEvent_C_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_End : TriggerState {
            internal StateEvent_C_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "그래... 기억났다. 내 이름...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNew_Event(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNew_Event : TriggerState {
            internal StateNew_Event(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5202}, arg2: true);
                context.ChangeMonster(arg1: 101, arg2: 102);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_D(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_D : TriggerState {
            internal StateEvent_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "내 이름은 $npcName:11003602$.", duration: 2800,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_D_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_D_End : TriggerState {
            internal StateEvent_D_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001267}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001268}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001269}, arg2: 0);
                context.AddBalloonTalk(spawnPointId: 102, msg: "크리티아스의 관찰자.", duration: 2800, delayTick: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}