namespace Maple2.Trigger._02000251_bf {
    public static class _trigger_01_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {705, 706}, arg2: true);
                context.SetMesh(arg1: new[] {711, 712}, arg2: false);
                context.DestroyMonster(arg1: new[] {601, 602, 603, 604});
                context.SetEffect(arg1: new[] {3004}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {711, 712}, arg2: true);
                context.CreateMonster(arg1: new[] {601, 602, 603, 604}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603, 604})) {
                    return new State통과Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과Delay : TriggerState {
            internal State통과Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3);
                context.SetAchievement(arg1: 1000, arg2: "trigger", arg3: "goldenTower");
                context.DungeonClear();
                context.SetMesh(arg1: new[] {705, 706, 711, 712}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3004}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}