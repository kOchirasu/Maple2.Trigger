namespace Maple2.Trigger._02000498_bf {
    public static class _main_6 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3601}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {6601, 6602}, arg2: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    return new State시작대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6601}, arg2: true);
                context.DarkStreamStartRound(round: 26, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 0, arg2: "26,30,26");
                    return new State26라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State26라운드 : TriggerState {
            internal State26라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_6__0$", arg3: 4000, arg4: "0");
                context.DarkStreamSpawnMonster(spawnId: new[] {126001}, score: 2200000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {126001})) {
                    context.DarkStreamClearRound(round: 26);
                    context.SetAchievement(arg1: 106, arg2: "trigger", arg3: "26roundpass");
                    return new State27라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27라운드대기 : TriggerState {
            internal State27라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6601}, arg2: true);
                context.DarkStreamStartRound(round: 27, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 0, arg2: "27,30,26");
                    return new State27라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27라운드 : TriggerState {
            internal State27라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {127001}, score: 2500000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {127001})) {
                    context.DarkStreamClearRound(round: 27);
                    context.SetAchievement(arg1: 106, arg2: "trigger", arg3: "27roundpass");
                    return new State28라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28라운드대기 : TriggerState {
            internal State28라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6601}, arg2: true);
                context.DarkStreamStartRound(round: 28, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 0, arg2: "28,30,26");
                    return new State28라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28라운드 : TriggerState {
            internal State28라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {128001}, score: 3000000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {128001})) {
                    context.DarkStreamClearRound(round: 28);
                    context.SetAchievement(arg1: 106, arg2: "trigger", arg3: "28roundpass");
                    return new State29라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29라운드대기 : TriggerState {
            internal State29라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6601}, arg2: true);
                context.DarkStreamStartRound(round: 29, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 0, arg2: "29,30,26");
                    return new State29라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29라운드 : TriggerState {
            internal State29라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {129001}, score: 5000000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {129001})) {
                    context.DarkStreamClearRound(round: 29);
                    context.SetAchievement(arg1: 106, arg2: "trigger", arg3: "29roundpass");
                    return new State30라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30라운드대기 : TriggerState {
            internal State30라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6602}, arg2: true);
                context.DarkStreamStartRound(round: 30, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 0, arg2: "30,30,26");
                    return new State30라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30라운드 : TriggerState {
            internal State30라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3601}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {130001}, arg2: true);
                context.DarkStreamSpawnMonster(spawnId: new[] {130002}, score: 8000000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {130002})) {
                    context.SetMesh(arg1: new[] {3601}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.DestroyMonster(arg1: new[] {130001});
                    context.DarkStreamClearRound(round: 30);
                    context.SetAchievement(arg1: 106, arg2: "trigger", arg3: "30roundpass");
                    return new State성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 7, arg2: "$02000350_BF__MAIN_6__1$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State포털생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_6__2$", arg3: 2500, arg4: "0");
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}