namespace Maple2.Trigger._52020010_qd {
    public static class _clock_d {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5011, 5012, 5013, 5014, 5015}, visible: false);
                context.SetInteractObject(interactIds: new []{10001275}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2005}, questIds: new []{60200050}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2005}, questIds: new []{60200050}, questStates: new byte[]{2})) {
                    return new StateReady_A(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2005}, questIds: new []{60200050}, questStates: new byte[]{3})) {
                    return new StateReady_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001275}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001274}, arg2: 0)) {
                    return new StateEvent_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5011, 5012}, visible: true);
                context.CreateMonster(spawnIds: new []{401}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "대체 어디 있는거야?", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5013}, visible: true);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_3002");
                context.AddBalloonTalk(spawnId: 401, msg: "분명히 책장 어딘가에 장치가 있었는데...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "어째서 이럴 때 기억나지 않는거야!!!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5014}, visible: true);
                context.AddBalloonTalk(spawnId: 401, msg: "여기였나?", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "아니... 생각해보니 소용 없군...", duration: 2800, delayTick: 0);
                context.SetInteractObject(interactIds: new []{10001275}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5015}, visible: true);
                context.AddBalloonTalk(spawnId: 401, msg: "어차피 거스를 수 없는 운명인 것을...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5011, 5012, 5013, 5014, 5015}, visible: false);
                context.DestroyMonster(spawnIds: new []{401});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_A : TriggerState {
            internal StateReady_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001275}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001274}, arg2: 0)) {
                    return new StateEvent_Start_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start_A : TriggerState {
            internal StateEvent_Start_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5011, 5012}, visible: true);
                context.CreateMonster(spawnIds: new []{401}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateEvent_01_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_A : TriggerState {
            internal StateEvent_01_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "대체 어디 있는거야?", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_02_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_A : TriggerState {
            internal StateEvent_02_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5013}, visible: true);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_3002");
                context.AddBalloonTalk(spawnId: 401, msg: "분명히 책장 어딘가에 장치가 있었는데...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_03_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03_A : TriggerState {
            internal StateEvent_03_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "어째서 이럴 때 기억나지 않는거야!!!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_04_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04_A : TriggerState {
            internal StateEvent_04_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5014}, visible: true);
                context.AddBalloonTalk(spawnId: 401, msg: "여기였나?", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_05_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_A : TriggerState {
            internal StateEvent_05_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 401, msg: "아니... 생각해보니 소용 없군...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_06_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_A : TriggerState {
            internal StateEvent_06_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5015}, visible: true);
                context.AddBalloonTalk(spawnId: 401, msg: "어차피 거스를 수 없는 운명인 것을...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_End_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_End_A : TriggerState {
            internal StateEvent_End_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5011, 5012, 5013, 5014, 5015}, visible: false);
                context.DestroyMonster(spawnIds: new []{401});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
