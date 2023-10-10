namespace Maple2.Trigger._02000410_bf {
    public static class _mapskilldebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{444, 666}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonPlayTime() == 600) {
                    return new State1단계_70000103(context);
                }

                if (!context.NpcDetected(boxId: 700, spawnIds: new []{0})) {
                    return new StateSkill끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_70000103 : TriggerState {
            internal State1단계_70000103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{444}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonPlayTime() == 780) {
                    return new State2단계_70000104(context);
                }

                if (!context.NpcDetected(boxId: 700, spawnIds: new []{0})) {
                    return new StateSkill끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_70000104 : TriggerState {
            internal State2단계_70000104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{666}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonPlayTime() == 900) {
                    return new StateSkill끄기(context);
                }

                if (!context.NpcDetected(boxId: 700, spawnIds: new []{0})) {
                    return new StateSkill끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill끄기 : TriggerState {
            internal StateSkill끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{444, 666}, enabled: false);
                context.AddBuff(boxIds: new []{750}, skillId: 50004524, level: 1, arg4: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
