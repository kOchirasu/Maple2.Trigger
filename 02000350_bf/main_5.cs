namespace Maple2.Trigger._02000350_bf {
    public static class _main_5 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 3420, 3421, 3422, 3423, 3424}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{706}, arg2: false);
                context.SetEffect(triggerIds: new []{640, 650, 6501, 6502}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "21,25,21");
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 21, uiDuration: 3000, damagePenalty: 100);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State21라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State21라운드 : TriggerState {
            internal State21라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_5__0$", duration: 4000, boxId: 0);
                context.DarkStreamSpawnMonster(spawnIds: new []{121001}, score: 110000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121001})) {
                    context.DarkStreamClearRound(round: 21);
                    context.SetAchievement(triggerId: 105, type: "trigger", code: "21roundpass");
                    return new State22라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22라운드Wait : TriggerState {
            internal State22라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "22,25,21");
                context.DarkStreamStartRound(round: 22, uiDuration: 3000, damagePenalty: 100);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State22라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22라운드 : TriggerState {
            internal State22라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{122001, 122002, 122003}, score: 70000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{122001, 122002, 122003})) {
                    context.DarkStreamClearRound(round: 22);
                    context.SetAchievement(triggerId: 105, type: "trigger", code: "22roundpass");
                    return new State23라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23라운드Wait : TriggerState {
            internal State23라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEventUI(arg1: 0, script: "23,25,21");
                context.DarkStreamStartRound(round: 23, uiDuration: 3000, damagePenalty: 100);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State23라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23라운드 : TriggerState {
            internal State23라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{123001}, score: 80000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{123001})) {
                    context.DarkStreamClearRound(round: 23);
                    context.SetAchievement(triggerId: 105, type: "trigger", code: "23roundpass");
                    return new State24라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24라운드Wait : TriggerState {
            internal State24라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "24,25,21");
                context.DarkStreamStartRound(round: 24, uiDuration: 3000, damagePenalty: 100);
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_5__1$", duration: 2000, boxId: 0);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State24라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24라운드 : TriggerState {
            internal State24라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: true, display: true, arg5: 80);
                context.CreateMonster(spawnIds: new []{124099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    context.DestroyMonster(spawnIds: new []{124099});
                    context.ResetTimer(timerId: "30");
                    context.DarkStreamClearRound(round: 24);
                    context.SetAchievement(triggerId: 105, type: "trigger", code: "24roundpass");
                    return new State25라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25라운드Wait : TriggerState {
            internal State25라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "25,25,21");
                context.SetEffect(triggerIds: new []{6501, 6502}, visible: true);
                context.DarkStreamStartRound(round: 25, uiDuration: 3000, damagePenalty: 100);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State25라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25라운드 : TriggerState {
            internal State25라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{125001, 125002}, score: 750000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{125001, 125002})) {
                    context.DarkStreamClearRound(round: 25);
                    context.SetAchievement(triggerId: 105, type: "trigger", code: "25roundpass");
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
                    context.SetEffect(triggerIds: new []{650}, visible: true);
                    context.SetSkill(triggerIds: new []{706}, arg2: true);
                    context.SetMesh(triggerIds: new []{3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 3420, 3421, 3422, 3423, 3424}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
