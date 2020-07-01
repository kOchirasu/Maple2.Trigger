namespace Maple2.Trigger._02000243_bf {
    public static class _trigger_01_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {705, 706}, arg2: true);
                context.SetMesh(arg1: new[] {711, 712}, arg2: false);
                context.DestroyMonster(arg1: new[] {601});
                context.SetEffect(arg1: new[] {2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 201) == 1) {
                    return new State몹생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {711, 712}, arg2: true);
                context.CreateMonster(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601})) {
                    return new State통과딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과딜레이 : TriggerState {
            internal State통과딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 999, arg2: "trigger", arg3: "GoldenTower2nd");
                context.SetAchievement(arg1: 999, arg2: "trigger", arg3: "ClearGoldentowerfirst");
                context.DungeonClear();
                context.SetTimer(arg1: "3", arg2: 3);
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
                context.SetEffect(arg1: new[] {2004}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}