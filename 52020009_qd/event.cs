namespace Maple2.Trigger._52020009_qd {
    public static class _event {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201, 5202}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2003})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetEffect(triggerIds: new []{5201}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWalk : TriggerState {
            internal StateWalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_Ready_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Ready_01 : TriggerState {
            internal StateEvent_Ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001267, 10001268, 10001269}, state: 1);
                context.AddBalloonTalk(spawnId: 101, msg: "이름... 내 이름이 기억나지 않아...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001267}, arg2: 0)) {
                    return new StateEvent_A(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001268}, arg2: 0)) {
                    return new StateEvent_B(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001269}, arg2: 0)) {
                    return new StateEvent_C(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvent_Ready_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Ready_02 : TriggerState {
            internal StateEvent_Ready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "누가 내 이름 좀 찾아줘!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001267}, arg2: 0)) {
                    return new StateEvent_A(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001268}, arg2: 0)) {
                    return new StateEvent_B(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001269}, arg2: 0)) {
                    return new StateEvent_C(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvent_Ready_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A : TriggerState {
            internal StateEvent_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "아니야! 그건 내 이름이 적힌 책이 아니라고!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_A_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_End : TriggerState {
            internal StateEvent_A_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "그건 왕의 비밀병기와 관련된 책이란 말이야!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_Ready_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_B : TriggerState {
            internal StateEvent_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$map:02020010$의 거대 병기?", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_B_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_B_End : TriggerState {
            internal StateEvent_B_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "그런 책에 내 이름이 적혀 있을 리가 없잖아!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_Ready_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C : TriggerState {
            internal StateEvent_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "그 책은! 내 일기장!", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvent_C_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_End : TriggerState {
            internal StateEvent_C_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "그래... 기억났다. 내 이름...", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNew_Event(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNew_Event : TriggerState {
            internal StateNew_Event(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5202}, visible: true);
                context.ChangeMonster(removeSpawnId: 101, addSpawnId: 102);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_D(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_D : TriggerState {
            internal StateEvent_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "내 이름은 $npcName:11003602$.", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_D_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_D_End : TriggerState {
            internal StateEvent_D_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001267, 10001268, 10001269}, state: 0);
                context.AddBalloonTalk(spawnId: 102, msg: "크리티아스의 관찰자.", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
