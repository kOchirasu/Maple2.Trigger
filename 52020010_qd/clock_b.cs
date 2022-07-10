namespace Maple2.Trigger._52020010_qd {
    public static class _clock_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003, 5004, 5005, 5006}, visible: false);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001272}, arg2: 0)) {
                    return new StateEvent_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.CreateMonster(spawnIds: new []{201, 202, 203}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_3001");
                context.AddBalloonTalk(spawnId: 203, msg: "와! 쾅쾅한다!", duration: 2500, delayTick: 0);
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
                context.AddBalloonTalk(spawnId: 202, msg: "여보... 우리 어쩌면 좋아요?", duration: 2800, delayTick: 0);
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
                context.AddBalloonTalk(spawnId: 201, msg: "일이 이렇게 되어버릴 줄은...", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnId: 202, msg: "우리 도망 못가는거죠?", duration: 2800, delayTick: 1000);
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
                context.SetEffect(triggerIds: new []{5005}, visible: true);
                context.AddBalloonTalk(spawnId: 203, msg: "쾅쾅! 쾅쾅!", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 201, msg: "난 대체 무얼 위해...", duration: 2800, delayTick: 0);
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
                context.AddBalloonTalk(spawnId: 202, msg: "여보!", duration: 2800, delayTick: 0);
                context.AddBalloonTalk(spawnId: 201, msg: "!!!", duration: 2000, delayTick: 1000);
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
                context.AddBalloonTalk(spawnId: 201, msg: "여보, 내 딸... 모두 미안하오...", duration: 2000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5006}, visible: true);
                context.AddBalloonTalk(spawnId: 202, msg: "여보...", duration: 2000, delayTick: 1000);
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
                context.SetEffect(triggerIds: new []{5003, 5004, 5005, 5006}, visible: false);
                context.DestroyMonster(spawnIds: new []{201, 202, 203});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
