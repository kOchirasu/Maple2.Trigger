namespace Maple2.Trigger._02000367_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3101, 3102, 3103, 3104, 3105, 3106, 3113, 3114}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 33, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 44, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000983, 10000984, 10000985, 10000986, 10000987, 10000988, 10000995, 10000996}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new State전투01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{11101, 11102, 11103, 11104, 11105, 11106, 11107, 11201, 11202, 11203, 11204, 11205}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{11101, 11102, 11103, 11104, 11105, 11106, 11107, 11201, 11202, 11203, 11204, 11205})) {
                    return new State전투02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3101, 3102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000983, 10000984}, state: 1);
                context.CreateMonster(spawnIds: new []{12101, 12102, 12201, 12202, 12203, 12204, 12205, 12206, 12207}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{12101, 12102, 12201, 12202, 12203, 12204, 12205, 12206, 12207})) {
                    return new State전투03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투03 : TriggerState {
            internal State전투03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3103, 3104}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000985, 10000986}, state: 1);
                context.CreateMonster(spawnIds: new []{13101, 13102, 13103, 13104, 13105, 13106, 13107, 13108, 13109, 13201, 13202, 13203, 13204}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{13101, 13102, 13103, 13104, 13105, 13106, 13107, 13108, 13109, 13201, 13202, 13203, 13204})) {
                    context.SetMesh(triggerIds: new []{3105, 3106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(interactIds: new []{10000987, 10000988}, state: 1);
                    return new State합류Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State합류Wait : TriggerState {
            internal State합류Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "main") == 1) {
                    return new State전투04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투04 : TriggerState {
            internal State전투04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{30001, 30002, 30003, 30004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{30001, 30002, 30003, 30004})) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 33, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 44, visible: true, enabled: true, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{41101, 41102, 41103, 41104, 41105, 41106, 41201, 41202, 41203, 41204}, arg2: false);
                context.SetUserValue(triggerId: 9999900, key: "main2", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{41101, 41102, 41103, 41104, 41105, 41106, 41201, 41202, 41203, 41204})) {
                    context.SetMesh(triggerIds: new []{3113, 3114}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(interactIds: new []{10000995, 10000996}, state: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
