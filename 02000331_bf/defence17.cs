namespace Maple2.Trigger._02000331_bf {
    public static class _defence17 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99993})) {
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
                if (context.NpcDetected(boxId: 9030, spawnIds: new []{999})) {
                    return new State전투중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중 : TriggerState {
            internal State전투중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{999})) {
                    return new State생존체크01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크01 : TriggerState {
            internal State생존체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 99997, spawnIds: new []{601})) {
                    return new State생존체크02(context);
                }

                if (context.MonsterDead(spawnIds: new []{601})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크02 : TriggerState {
            internal State생존체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 99997, spawnIds: new []{602})) {
                    return new State생존체크03(context);
                }

                if (context.MonsterDead(spawnIds: new []{602})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크03 : TriggerState {
            internal State생존체크03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 99997, spawnIds: new []{603})) {
                    return new State생존체크04(context);
                }

                if (context.MonsterDead(spawnIds: new []{603})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크04 : TriggerState {
            internal State생존체크04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 99997, spawnIds: new []{604})) {
                    return new State생존체크05(context);
                }

                if (context.MonsterDead(spawnIds: new []{604})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존체크05 : TriggerState {
            internal State생존체크05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 99997, spawnIds: new []{605})) {
                    return new StateAchievement(context);
                }

                if (context.MonsterDead(spawnIds: new []{605})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 99996, type: "trigger", code: "defence_child");
            }

            public override TriggerState? Execute() {
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
