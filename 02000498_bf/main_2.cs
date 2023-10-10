namespace Maple2.Trigger._02000498_bf {
    public static class _main_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{610, 620, 603, 6110, 6111, 6112, 6113, 6201}, visible: false);
                context.SetSkill(triggerIds: new []{703}, enabled: false);
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "6,10,6");
                context.DarkStreamStartRound(round: 6, uiDuration: 3000, damagePenalty: 10);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State6라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드 : TriggerState {
            internal State6라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_2__0$", duration: 4000, boxId: 0);
                context.DarkStreamSpawnMonster(spawnIds: new []{106001, 106002, 106003, 106004, 106005}, score: 18000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106001, 106002, 106003, 106004, 106005})) {
                    context.DarkStreamClearRound(round: 6);
                    context.SetAchievement(triggerId: 102, type: "trigger", code: "6roundpass");
                    return new State7라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드Wait : TriggerState {
            internal State7라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "7,10,6");
                context.DarkStreamStartRound(round: 7, uiDuration: 3000, damagePenalty: 10);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State7라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드 : TriggerState {
            internal State7라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{107001, 107002, 107003, 107004, 107005}, score: 22000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{107001, 107002, 107003, 107004, 107005})) {
                    context.DarkStreamClearRound(round: 7);
                    context.SetAchievement(triggerId: 102, type: "trigger", code: "7roundpass");
                    return new State8라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드Wait : TriggerState {
            internal State8라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "8,10,6");
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 8, uiDuration: 3000, damagePenalty: 10);
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_2__1$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State8라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드 : TriggerState {
            internal State8라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30, autoRemove: true, display: true, vOffset: 80);
                context.CreateMonster(spawnIds: new []{108099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    context.DestroyMonster(spawnIds: new []{108099});
                    context.ResetTimer(timerId: "30");
                    context.DarkStreamClearRound(round: 8);
                    context.SetAchievement(triggerId: 102, type: "trigger", code: "8roundpass");
                    return new State9라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드Wait : TriggerState {
            internal State9라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "9,10,6");
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 9, uiDuration: 3000, damagePenalty: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State9라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드 : TriggerState {
            internal State9라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{109001, 109002, 109003, 109004}, score: 65000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{109001, 109002, 109003, 109004})) {
                    context.DarkStreamClearRound(round: 9);
                    context.SetAchievement(triggerId: 102, type: "trigger", code: "9roundpass");
                    return new State10라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드Wait : TriggerState {
            internal State10라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "10,10,6");
                context.SetEffect(triggerIds: new []{6201}, visible: true);
                context.DarkStreamStartRound(round: 10, uiDuration: 3000, damagePenalty: 10);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State10라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드 : TriggerState {
            internal State10라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{110001}, score: 270000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{110001})) {
                    context.DarkStreamClearRound(round: 10);
                    context.SetAchievement(triggerId: 102, type: "trigger", code: "10roundpass");
                    return new State바닥부심(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥부심 : TriggerState {
            internal State바닥부심(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEffect(triggerIds: new []{600}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEffect(triggerIds: new []{620}, visible: true);
                    context.SetSkill(triggerIds: new []{703}, enabled: true);
                    context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetEventUI(arg1: 0, script: "0,0");
                    return new StateEnd(context);
                }

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
