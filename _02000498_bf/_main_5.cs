namespace Maple2.Trigger._02000498_bf {
    public static class _main_5 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 3420, 3421, 3422, 3423, 3424}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {706}, arg2: false);
                context.SetEffect(arg1: new[] {640, 650, 6501, 6502}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    return new State시작대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "21,25,21");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStream(type: "StartRound", round: 21, uiDuration: 3000, damagePenalty: 100);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State21라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State21라운드 : TriggerState {
            internal State21라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_5__0$", arg3: 4000, arg4: "0");
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {121001}, score: 110000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121001})) {
                    context.DarkStream(type: "ClearRound", round: 21);
                    context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "21roundpass");
                    return new State22라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22라운드대기 : TriggerState {
            internal State22라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "22,25,21");
                context.DarkStream(type: "StartRound", round: 22, uiDuration: 3000, damagePenalty: 100);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State22라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22라운드 : TriggerState {
            internal State22라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {122001, 122002, 122003}, score: 70000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {122001, 122002, 122003})) {
                    context.DarkStream(type: "ClearRound", round: 22);
                    context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "22roundpass");
                    return new State23라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23라운드대기 : TriggerState {
            internal State23라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEventUI(arg1: 0, arg2: "23,25,21");
                context.DarkStream(type: "StartRound", round: 23, uiDuration: 3000, damagePenalty: 100);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State23라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23라운드 : TriggerState {
            internal State23라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {123001}, score: 80000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {123001})) {
                    context.DarkStream(type: "ClearRound", round: 23);
                    context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "23roundpass");
                    return new State24라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24라운드대기 : TriggerState {
            internal State24라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "24,25,21");
                context.DarkStream(type: "StartRound", round: 24, uiDuration: 3000, damagePenalty: 100);
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_5__1$", arg3: 2000, arg4: "0");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State24라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24라운드 : TriggerState {
            internal State24라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: true, arg4: true, arg5: 80);
                context.CreateMonster(arg1: new[] {124099}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.DestroyMonster(arg1: new[] {124099});
                    context.ResetTimer(arg1: "30");
                    context.DarkStream(type: "ClearRound", round: 24);
                    context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "24roundpass");
                    return new State25라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25라운드대기 : TriggerState {
            internal State25라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "25,25,21");
                context.SetEffect(arg1: new[] {6501, 6502}, arg2: true);
                context.DarkStream(type: "StartRound", round: 25, uiDuration: 3000, damagePenalty: 100);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State25라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25라운드 : TriggerState {
            internal State25라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {125001, 125002}, score: 750000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {125001, 125002})) {
                    context.DarkStream(type: "ClearRound", round: 25);
                    context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "25roundpass");
                    return new State바닥부심(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥부심 : TriggerState {
            internal State바닥부심(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEffect(arg1: new[] {650}, arg2: true);
                    context.SetSkill(arg1: new[] {706}, arg2: true);
                    context.SetMesh(arg1: new[] {3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 3420, 3421, 3422, 3423, 3424}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}