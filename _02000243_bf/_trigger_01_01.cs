using System;

namespace Maple2.Trigger._02000243_bf {
    public static class _trigger_01_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {705, 706}, arg2: true);
                context.SetMesh(arg1: new int[] {711, 712}, arg2: false);
                context.DestroyMonster(arg1: new int[] {601});
                context.SetEffect(arg1: new int[] {2004}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 201, arg2: 1)) {
                    context.State = new State몹생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹생성 : TriggerState {
            internal State몹생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {711, 712}, arg2: true);
                context.CreateMonster(arg1: new int[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {601})) {
                    context.State = new State통과딜레이(context);
                    return;
                }
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
                context.SetMesh(arg1: new int[] {705, 706}, arg2: false);
                context.SetMesh(arg1: new int[] {711, 712}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State통과(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {2004}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}