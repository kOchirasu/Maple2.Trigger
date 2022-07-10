namespace Maple2.Trigger._52020020_qd {
    public static class _main_c {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200145}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 201, msg: "전 밖에서 기다리고 있겠습니다.", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMove : TriggerState {
            internal StateMove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOut : TriggerState {
            internal StateOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
