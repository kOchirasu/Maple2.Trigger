namespace Maple2.Trigger._02000247_bf {
    public static class _trigger_01_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{705, 706}, visible: true);
                context.SetMesh(triggerIds: new []{711, 712}, visible: false);
                context.DestroyMonster(spawnIds: new []{601, 602});
                context.SetEffect(triggerIds: new []{2004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 201) == 1) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{711, 712}, visible: true);
                context.CreateMonster(spawnIds: new []{601, 602}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602})) {
                    return new State통과Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과Delay : TriggerState {
            internal State통과Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 999, type: "trigger", code: "GoldenTower3rd");
                context.DungeonClear();
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetMesh(triggerIds: new []{711, 712, 705, 706}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2004}, visible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
