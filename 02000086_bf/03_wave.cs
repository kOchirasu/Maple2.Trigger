namespace Maple2.Trigger._02000086_bf {
    public static class _03_wave {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000159}, state: 1);
                context.SetEffect(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326}, visible: false);
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226}, visible: false);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "Closed");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000159}, arg2: 0)) {
                    return new StateDelay1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay1 : TriggerState {
            internal StateDelay1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326}, visible: true);
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226}, visible: true);
                context.SetTimer(timerId: "3", seconds: 2);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "Opened");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State웨이브1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브1 : TriggerState {
            internal State웨이브1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000086_BF__03_WAVE__0$", duration: 3000, boxId: 401);
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_601");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_602");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_603");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_604");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_605");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_606");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105, 106})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay2 : TriggerState {
            internal StateDelay2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State웨이브2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브2 : TriggerState {
            internal State웨이브2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106}, arg2: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_601");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_602");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_603");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_604");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_605");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_606");
                context.SetTimer(timerId: "3", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105, 106})) {
                    return new StateDelay4(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay3 : TriggerState {
            internal StateDelay3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State웨이브3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브3 : TriggerState {
            internal State웨이브3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000086_BF__03_WAVE__1$", duration: 3000, boxId: 401);
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106}, arg2: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_601");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_602");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_603");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_604");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_605");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_606");
                context.SetTimer(timerId: "3", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105, 106})) {
                    return new StateDelay4(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay4 : TriggerState {
            internal StateDelay4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateDelay5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay5 : TriggerState {
            internal StateDelay5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000159}, state: 1);
                context.SetEffect(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326}, visible: false);
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226}, visible: false);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "Closed");
                context.SetTimer(timerId: "3", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateDelay6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay6 : TriggerState {
            internal StateDelay6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
