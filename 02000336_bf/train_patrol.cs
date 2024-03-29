namespace Maple2.Trigger._02000336_bf {
    public static class _train_patrol {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7002, 7003, 7004}, visible: false);
                context.SetMesh(triggerIds: new []{16004}, visible: false, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State패트롤_01(context);
                }

                if (context.GetUserCount(boxId: 707) == 1) {
                    return new State패트롤_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패트롤_01 : TriggerState {
            internal State패트롤_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{147, 148, 149}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    return new State패트롤_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State패트롤_02 : TriggerState {
            internal State패트롤_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State패트롤_03 : TriggerState {
            internal State패트롤_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
                context.CreateMonster(spawnIds: new []{191, 192, 193, 194, 195, 196, 197, 198}, arg2: false);
                context.SetEffect(triggerIds: new []{7002}, visible: true);
                context.SetSkill(triggerIds: new []{5803, 5804, 5805}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{196})) {
                    return new State관문_03_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetMesh(triggerIds: new []{8030, 8031, 8032, 8033, 8034}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
