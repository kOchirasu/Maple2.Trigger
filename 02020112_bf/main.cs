namespace Maple2.Trigger._02020112_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: 0f);
                context.SetUserValue(triggerId: 99990002, key: "JumpFloor", value: 0);
                context.SetUserValue(triggerId: 99990017, key: "JumpFloor", value: 0);
                context.SetActor(triggerId: 9901, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9902, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9903, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9904, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new State중력방_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력방_Wait : TriggerState {
            internal State중력방_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{915})) {
                    return new State중력방_발판(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력방_발판 : TriggerState {
            internal State중력방_발판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990020, key: "GravityRoom", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GravityRoom") == 2) {
                    return new State중력방_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력방_전투 : TriggerState {
            internal State중력방_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{141, 142, 143, 144})) {
                    return new StateCamera_발판점프대(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_발판점프대 : TriggerState {
            internal StateCamera_발판점프대(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.SetUserValue(triggerId: 99990020, key: "GravityRoom", value: 1);
                context.SetUserValue(triggerId: 99990002, key: "JumpFloor", value: 1);
                context.SetUserValue(triggerId: 99990017, key: "JumpFloor", value: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{611, 612}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 1f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130})) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: false);
                    return new State격리방_지하(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리방_지하 : TriggerState {
            internal State격리방_지하(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MonsterDead") == 1) {
                    return new State격리방_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리방_Wait : TriggerState {
            internal State격리방_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{932})) {
                    return new State격리방_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리방_전투 : TriggerState {
            internal State격리방_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{191}, arg2: false);
                context.SetUserValue(triggerId: 99990008, key: "Start", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{191})) {
                    context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                    context.SetUserValue(triggerId: 99990008, key: "Start", value: 2);
                    context.SetUserValue(triggerId: 99990013, key: "EliteDead", value: 1);
                    context.SetUserValue(triggerId: 99990014, key: "EliteDead", value: 1);
                    context.SetUserValue(triggerId: 99990015, key: "EliteDead", value: 1);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
