namespace Maple2.Trigger._02000350_bf {
    public static class _main_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {610, 620, 603, 6110, 6111, 6112, 6113, 6201}, arg2: false);
                context.SetSkill(arg1: new[] {703}, arg2: false);
                context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new State시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "6,10,6");
                context.DarkStream(type: "StartRound", round: 6, uiDuration: 3000, damagePenalty: 10);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State6라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6라운드 : TriggerState {
            internal State6라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_2__0$", arg3: 4000, arg4: "0");
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {106001, 106002, 106003, 106004, 106005}, score: 18000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {106001, 106002, 106003, 106004, 106005})) {
                    context.DarkStream(type: "ClearRound", round: 6);
                    context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "6roundpass");
                    context.State = new State7라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드대기 : TriggerState {
            internal State7라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "7,10,6");
                context.DarkStream(type: "StartRound", round: 7, uiDuration: 3000, damagePenalty: 10);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State7라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드 : TriggerState {
            internal State7라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {107001, 107002, 107003, 107004, 107005}, score: 22000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {107001, 107002, 107003, 107004, 107005})) {
                    context.DarkStream(type: "ClearRound", round: 7);
                    context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "7roundpass");
                    context.State = new State8라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드대기 : TriggerState {
            internal State8라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "8,10,6");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStream(type: "StartRound", round: 8, uiDuration: 3000, damagePenalty: 10);
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_2__1$", arg3: 2000, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State8라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드 : TriggerState {
            internal State8라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: true, arg4: true, arg5: 80);
                context.CreateMonster(arg1: new[] {108099}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.DestroyMonster(arg1: new[] {108099});
                    context.ResetTimer(arg1: "30");
                    context.DarkStream(type: "ClearRound", round: 8);
                    context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "8roundpass");
                    context.State = new State9라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드대기 : TriggerState {
            internal State9라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "9,10,6");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStream(type: "StartRound", round: 9, uiDuration: 3000, damagePenalty: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State9라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드 : TriggerState {
            internal State9라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {109001, 109002, 109003, 109004}, score: 65000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {109001, 109002, 109003, 109004})) {
                    context.DarkStream(type: "ClearRound", round: 9);
                    context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "9roundpass");
                    context.State = new State10라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드대기 : TriggerState {
            internal State10라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "10,10,6");
                context.SetEffect(arg1: new[] {6201}, arg2: true);
                context.DarkStream(type: "StartRound", round: 10, uiDuration: 3000, damagePenalty: 10);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State10라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드 : TriggerState {
            internal State10라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {110001}, score: 270000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {110001})) {
                    context.DarkStream(type: "ClearRound", round: 10);
                    context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "10roundpass");
                    context.State = new State바닥부심(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥부심 : TriggerState {
            internal State바닥부심(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEffect(arg1: new[] {620}, arg2: true);
                    context.SetSkill(arg1: new[] {703}, arg2: true);
                    context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetEventUI(arg1: 0, arg2: "0,0");
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}