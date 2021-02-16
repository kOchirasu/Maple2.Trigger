namespace Maple2.Trigger._52100052_qd {
    public static class _04_randomportal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002088, 10002089, 10002090}, arg2: 0);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3300}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 30, visible: false, enabled: false, minimapVisible: false);
                context.SetUserValue(key: "SearchStart", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SearchStart") == 1) {
                    return new StatePickRandomPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickRandomPortal : TriggerState {
            internal StatePickRandomPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new StateToWall01(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateToRoom01(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateToTower01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToWall01 : TriggerState {
            internal StateToWall01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002088}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "ToRoomFalse", value: 1);
                context.SetUserValue(triggerId: 7, key: "ToTowerFalse", value: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002088}, arg2: 0)) {
                    return new StateToWall02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToWall02 : TriggerState {
            internal StateToWall02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3200}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3201, 3202}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
                context.SetEventUI(arg1: 1, script: "$02000396_BF__04_RANDOMPORTAL__0$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateToWallGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToWallGuide01 : TriggerState {
            internal StateToWallGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11001563, script: "$52100052_QD__04_RANDOMPORTAL__0$", arg4: 5);
                context.SetSkip(state: new StateToWallGuide01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateToWallGuide01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToWallGuide01Skip : TriggerState {
            internal StateToWallGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToRoom01 : TriggerState {
            internal StateToRoom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002089}, arg2: 1);
                context.SetUserValue(triggerId: 5, key: "ToWallFalse", value: 1);
                context.SetUserValue(triggerId: 7, key: "ToTowerFalse", value: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002089}, arg2: 0)) {
                    return new StateToRoom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToRoom02 : TriggerState {
            internal StateToRoom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52100052_QD__04_RANDOMPORTAL__1$", arg3: 2000, arg4: "0");
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateToRoomGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToRoomGuide01 : TriggerState {
            internal StateToRoomGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11001563, script: "$52100052_QD__04_RANDOMPORTAL__2$", arg4: 5);
                context.SetSkip(state: new StateToRoomGuide01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateToRoomGuide01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToRoomGuide01Skip : TriggerState {
            internal StateToRoomGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToTower01 : TriggerState {
            internal StateToTower01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "ToWallFalse", value: 1);
                context.SetUserValue(triggerId: 6, key: "ToRoomFalse", value: 1);
                context.SetInteractObject(arg1: new[] {10002090}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002090}, arg2: 0)) {
                    return new StateToTower02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToTower02 : TriggerState {
            internal StateToTower02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52100052_QD__04_RANDOMPORTAL__3$", arg3: 2000, arg4: "0");
                context.SetMesh(arg1: new[] {3300}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Opened");
                context.SetPortal(portalId: 30, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateToTowerGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToTowerGuide01 : TriggerState {
            internal StateToTowerGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11001563, script: "$52100052_QD__04_RANDOMPORTAL__4$", arg4: 5);
                context.SetSkip(state: new StateToTowerGuide01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateToTowerGuide01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToTowerGuide01Skip : TriggerState {
            internal StateToTowerGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "FindWay", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}