namespace Maple2.Trigger._02010086_bf {
    public static class _boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 799) == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{995, 999, 998});
                context.CreateMonster(spawnIds: new []{199}, arg2: true);
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new State소환_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_01 : TriggerState {
            internal State소환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{181, 188}, arg2: true);
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new State소환_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_02 : TriggerState {
            internal State소환_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{182, 187}, arg2: true);
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new State소환_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_03 : TriggerState {
            internal State소환_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{183, 186}, arg2: true);
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new State소환_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_04 : TriggerState {
            internal State소환_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{184, 185}, arg2: true);
                context.SetTimer(timerId: "20", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(timerId: "20")) {
                    return new State소환_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_05 : TriggerState {
            internal State소환_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{996}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOpen : TriggerState {
            internal StatePortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{181, 182, 183, 184, 185, 186, 187, 188, 997, 996, 995});
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.SetMesh(triggerIds: new []{1098}, visible: false, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 112);
            }
        }
    }
}
