namespace Maple2.Trigger._02000350_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600, 601, 602, 610, 6010, 6011, 6012, 6013, 6015, 6110, 6111, 6112, 6113, 6101}, arg2: false);
                context.SetSkill(arg1: new[] {701, 702}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6010, 6011, 6012, 6013, 6015}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN__0$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내02 : TriggerState {
            internal State안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN__1$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State안내03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내03 : TriggerState {
            internal State안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN__2$", arg3: 4000, arg4: "0");
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State진동대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진동대기 : TriggerState {
            internal State진동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamStartGame(round: 30);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetSkill(arg1: new[] {701}, arg2: true);
                context.SetEffect(arg1: new[] {6010, 6011, 6012, 6013}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State1라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드대기 : TriggerState {
            internal State1라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6110, 6111, 6112, 6113}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStreamStartRound(round: 1, uiDuration: 3000, damagePenalty: 5);
                context.SetEventUI(arg1: 0, arg2: "1,5,1");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State1라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {101001}, score: 6000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101001})) {
                    context.DarkStreamClearRound(round: 1);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "1roundpass");
                    return new State2라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드대기 : TriggerState {
            internal State2라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamStartRound(round: 2, uiDuration: 3000, damagePenalty: 5);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEventUI(arg1: 0, arg2: "2,5,1");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State2라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {102001}, score: 6000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102001})) {
                    context.DarkStreamClearRound(round: 2);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "2roundpass");
                    return new State3라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드대기 : TriggerState {
            internal State3라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "3,5,1");
                context.DarkStreamStartRound(round: 3, uiDuration: 3000, damagePenalty: 5);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State3라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {103001}, score: 16000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103001})) {
                    context.DarkStreamClearRound(round: 3);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "3roundpass");
                    return new State4라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드대기 : TriggerState {
            internal State4라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "4,5,1");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStreamStartRound(round: 4, uiDuration: 3000, damagePenalty: 5);
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN__3$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEventUI(arg1: 0, arg2: "4,5,1");
                    return new State4라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드 : TriggerState {
            internal State4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: true, arg4: true, arg5: 80);
                context.CreateMonster(arg1: new[] {104099}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.DestroyMonster(arg1: new[] {104099});
                    context.ResetTimer(arg1: "30");
                    context.DarkStreamClearRound(round: 4);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "4roundpass");
                    return new State5라운드대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드대기 : TriggerState {
            internal State5라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "5,5,1");
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.DarkStreamStartRound(round: 5, uiDuration: 3000, damagePenalty: 5);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State5라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드 : TriggerState {
            internal State5라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {105001}, score: 135000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {105001})) {
                    context.DarkStreamClearRound(round: 5);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "5roundpass");
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
                    context.SetEffect(arg1: new[] {610}, arg2: true);
                    context.SetEffect(arg1: new[] {6110, 6111, 6112, 6113}, arg2: false);
                    context.SetSkill(arg1: new[] {702}, arg2: true);
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetEventUI(arg1: 0, arg2: "0,0");
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}