namespace Maple2.Trigger._52020010_qd {
    public static class _clock_d {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5011}, arg2: false);
                context.SetEffect(arg1: new[] {5012}, arg2: false);
                context.SetEffect(arg1: new[] {5013}, arg2: false);
                context.SetEffect(arg1: new[] {5014}, arg2: false);
                context.SetEffect(arg1: new[] {5015}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001275}, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2005}, arg2: new[] {60200050},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2005}, arg2: new[] {60200050},
                    arg3: new byte[] {2})) {
                    context.State = new StateReady_A(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2005}, arg2: new[] {60200050},
                    arg3: new byte[] {3})) {
                    context.State = new StateReady_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001275}, arg2: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001274}, arg2: 0)) {
                    context.State = new StateEvent_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5011}, arg2: true);
                context.SetEffect(arg1: new[] {5012}, arg2: true);
                context.CreateMonster(arg1: new[] {401}, arg2: true);
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
                context.AddBalloonTalk(spawnPointId: 401, msg: "대체 어디 있는거야?", duration: 2800, delayTick: 0);
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
                context.SetEffect(arg1: new[] {5013}, arg2: true);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_3002");
                context.AddBalloonTalk(spawnPointId: 401, msg: "분명히 책장 어딘가에 장치가 있었는데...", duration: 2800, delayTick: 0);
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
                context.AddBalloonTalk(spawnPointId: 401, msg: "어째서 이럴 때 기억나지 않는거야!!!", duration: 2800, delayTick: 0);
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
                context.SetEffect(arg1: new[] {5014}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 401, msg: "여기였나?", duration: 2800, delayTick: 0);
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
                context.AddBalloonTalk(spawnPointId: 401, msg: "아니... 생각해보니 소용 없군...", duration: 2800, delayTick: 0);
                context.SetInteractObject(arg1: new[] {10001275}, arg2: 1);
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
                context.SetEffect(arg1: new[] {5015}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 401, msg: "어차피 거스를 수 없는 운명인 것을...", duration: 2800, delayTick: 0);
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
                context.SetEffect(arg1: new[] {5011}, arg2: false);
                context.SetEffect(arg1: new[] {5012}, arg2: false);
                context.SetEffect(arg1: new[] {5013}, arg2: false);
                context.SetEffect(arg1: new[] {5014}, arg2: false);
                context.SetEffect(arg1: new[] {5015}, arg2: false);
                context.DestroyMonster(arg1: new[] {401});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateReady_A : TriggerState {
            internal StateReady_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001275}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001274}, arg2: 0)) {
                    context.State = new StateEvent_Start_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start_A : TriggerState {
            internal StateEvent_Start_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5011}, arg2: true);
                context.SetEffect(arg1: new[] {5012}, arg2: true);
                context.CreateMonster(arg1: new[] {401}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateEvent_01_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_A : TriggerState {
            internal StateEvent_01_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 401, msg: "대체 어디 있는거야?", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_02_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_A : TriggerState {
            internal StateEvent_02_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5013}, arg2: true);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_3002");
                context.AddBalloonTalk(spawnPointId: 401, msg: "분명히 책장 어딘가에 장치가 있었는데...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_03_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_03_A : TriggerState {
            internal StateEvent_03_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 401, msg: "어째서 이럴 때 기억나지 않는거야!!!", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_04_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_A : TriggerState {
            internal StateEvent_04_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5014}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 401, msg: "여기였나?", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_05_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_A : TriggerState {
            internal StateEvent_05_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 401, msg: "아니... 생각해보니 소용 없군...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_06_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_A : TriggerState {
            internal StateEvent_06_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5015}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 401, msg: "어차피 거스를 수 없는 운명인 것을...", duration: 2800, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEvent_End_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_End_A : TriggerState {
            internal StateEvent_End_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5011}, arg2: false);
                context.SetEffect(arg1: new[] {5012}, arg2: false);
                context.SetEffect(arg1: new[] {5013}, arg2: false);
                context.SetEffect(arg1: new[] {5014}, arg2: false);
                context.SetEffect(arg1: new[] {5015}, arg2: false);
                context.DestroyMonster(arg1: new[] {401});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}