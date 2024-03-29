namespace Maple2.Trigger._02000336_bf {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{16003, 16004}, visible: false, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{122, 123, 301, 302, 110, 111, 112, 113, 114, 116, 117, 120, 121, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134, 135, 137, 139, 141, 142, 144}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State관문_01_개방_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_Prepare : TriggerState {
            internal State관문_01_개방_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
                context.CreateMonster(spawnIds: new []{309, 311, 313, 172, 173}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{127})) {
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
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetMesh(triggerIds: new []{8010, 8011, 8012, 8013, 8014}, visible: false, arg4: 0, arg5: 10f);
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{125})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_Prepare : TriggerState {
            internal State관문_02_개방_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{127})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{16017, 16018}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
