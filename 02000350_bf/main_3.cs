namespace Maple2.Trigger._02000350_bf {
    public static class _main_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{704}, enabled: false);
                context.SetEffect(triggerIds: new []{630, 620, 6301}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_3__0$", duration: 2000, boxId: 0);
                context.DarkStreamStartRound(round: 11, uiDuration: 3000, damagePenalty: 30);
                context.SetEventUI(arg1: 0, script: "11,15,11");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State11라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11라운드 : TriggerState {
            internal State11라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_3__1$", duration: 4000, boxId: 0);
                context.DarkStreamSpawnMonster(spawnIds: new []{111001}, score: 295000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111001})) {
                    context.DarkStreamClearRound(round: 11);
                    context.SetAchievement(triggerId: 103, type: "trigger", code: "11roundpass");
                    return new State12라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12라운드Wait : TriggerState {
            internal State12라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "12,15,11");
                context.DarkStreamStartRound(round: 12, uiDuration: 3000, damagePenalty: 30);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State12라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12라운드 : TriggerState {
            internal State12라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{112001}, score: 78750);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{112001})) {
                    context.DarkStreamClearRound(round: 12);
                    context.SetAchievement(triggerId: 103, type: "trigger", code: "12roundpass");
                    return new State13라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State13라운드Wait : TriggerState {
            internal State13라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "13,15,11");
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 13, uiDuration: 3000, damagePenalty: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State13라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State13라운드 : TriggerState {
            internal State13라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{113001}, score: 43750);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{113001})) {
                    context.DarkStreamClearRound(round: 13);
                    context.SetAchievement(triggerId: 103, type: "trigger", code: "13roundpass");
                    return new State14라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State14라운드Wait : TriggerState {
            internal State14라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "14,15,11");
                context.DarkStreamStartRound(round: 14, uiDuration: 3000, damagePenalty: 30);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State14라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State14라운드 : TriggerState {
            internal State14라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{114001}, score: 48750);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{114001})) {
                    context.DarkStreamClearRound(round: 14);
                    context.SetAchievement(triggerId: 103, type: "trigger", code: "14roundpass");
                    return new State15라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15라운드Wait : TriggerState {
            internal State15라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "15,15,11");
                context.SetEffect(triggerIds: new []{6301}, visible: true);
                context.DarkStreamStartRound(round: 15, uiDuration: 3000, damagePenalty: 30);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State15라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15라운드 : TriggerState {
            internal State15라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{115001}, score: 415000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{115001})) {
                    context.DarkStreamClearRound(round: 15);
                    context.SetAchievement(triggerId: 103, type: "trigger", code: "15roundpass");
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
                    context.SetEffect(triggerIds: new []{630}, visible: true);
                    context.SetSkill(triggerIds: new []{704}, enabled: true);
                    context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
