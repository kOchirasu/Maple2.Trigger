namespace Maple2.Trigger._02000335_bf {
    public static class _train_open {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6920}, visible: false);
                context.SetMesh(triggerIds: new []{6091, 6092, 6093}, visible: false);
                context.SetInteractObject(interactIds: new []{10000786}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 709) == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000786}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6922}, visible: true);
                context.SetMesh(triggerIds: new []{6081, 6082, 6083}, visible: false, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{6091, 6092, 6093}, visible: true, arg4: 300, arg5: 10f);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State작동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6099, 6076}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{6091, 6092, 6093}, visible: false, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{6000}, visible: false, arg4: 50, arg5: 1f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벽Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽Remove : TriggerState {
            internal State벽Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6920}, visible: true);
                context.SetSkill(triggerIds: new []{5807, 5808, 5809}, enabled: true);
                context.SetMesh(triggerIds: new []{7071, 7072, 7073, 7074}, visible: false, arg4: 15, arg5: 8f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{113}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State관문_01_조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_조건 : TriggerState {
            internal State관문_01_조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
                context.CreateMonster(spawnIds: new []{115, 116, 137, 139}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{113})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362);
                context.SetMesh(triggerIds: new []{6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218}, visible: false, arg4: 0, arg5: 10f);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State관문_01_개방_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State관문_01_개방_02 : TriggerState {
            internal State관문_01_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
