namespace Maple2.Trigger._02000243_bf {
    public static class _trigger_01_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{705, 706}, visible: true);
                context.SetMesh(triggerIds: new []{711, 712}, visible: false);
                context.DestroyMonster(spawnIds: new []{601});
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
                context.CreateMonster(spawnIds: new []{601}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601})) {
                    return new State통과Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과Delay : TriggerState {
            internal State통과Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 999, type: "trigger", code: "GoldenTower2nd");
                context.SetAchievement(triggerId: 999, type: "trigger", code: "ClearGoldentowerfirst");
                context.DungeonClear();
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetMesh(triggerIds: new []{705, 706, 711, 712}, visible: false);
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
                context.SetTimer(timerId: "1", seconds: 180);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
