namespace Maple2.Trigger._02000346_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 9001, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 9002, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 9003, visible: false, animationEffect: false, animationDelay: 0);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000791}, state: 0);
                context.SetMesh(triggerIds: new []{6001, 6010}, visible: true);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new StateObjective_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjective_01 : TriggerState {
            internal StateObjective_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateObjective_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjective_02 : TriggerState {
            internal StateObjective_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: true);
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetCinematicUI(type: 3, script: "$02000346_BF__MAIN1__0$");
                context.SetTimer(timerId: "5", seconds: 5, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000346_BF__MAIN1__2$", stage: 0, count: 3);
                context.SetTimer(timerId: "3", seconds: 3, display: false);
                context.SetMesh(triggerIds: new []{6001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 9001, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 9002, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 9003, visible: true, animationEffect: true, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetEventUI(arg1: 7, script: "$02000346_BF__MAIN1__1$", duration: 3000);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, visible: true, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{6010}, visible: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000791}, state: 1);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateClear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear_02 : TriggerState {
            internal StateClear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40009);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
