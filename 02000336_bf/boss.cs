namespace Maple2.Trigger._02000336_bf {
    public static class _boss {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90, 92, 93});
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7015}, visible: true);
                context.CreateMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State조직원Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조직원Spawn : TriggerState {
            internal State조직원Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.SetMesh(triggerIds: new []{8041, 8042, 8043, 8044}, visible: false, arg4: 0, arg5: 10f);
                context.SetSkill(triggerIds: new []{5801}, enabled: true);
                context.CreateMonster(spawnIds: new []{181, 182, 183});
                context.SetTimer(timerId: "2", seconds: 2, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State웨이홍_Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이홍_Script01 : TriggerState {
            internal State웨이홍_Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91});
                context.DestroyMonster(spawnIds: new []{90});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 8001, enabled: true);
                context.SetConversation(type: 2, spawnId: 11003124, script: "$02000336_BF__BOSS__0$", arg4: 3);
                context.SetSkip(state: new State웨이홍_Script02(context));
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State웨이홍_Script02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State웨이홍_Script02 : TriggerState {
            internal State웨이홍_Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003124, script: "$02000336_BF__BOSS__1$", arg4: 3);
                context.SetSkip(state: new StateEnd(context));
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.CameraSelect(triggerId: 8001, enabled: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
