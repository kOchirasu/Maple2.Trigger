namespace Maple2.Trigger._02000350_bf {
    public static class _main_4 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{705}, enabled: false);
                context.SetEffect(triggerIds: new []{6401, 640, 630}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "16,20,16");
                context.DarkStreamStartRound(round: 16, uiDuration: 3000, damagePenalty: 50);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State16라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State16라운드 : TriggerState {
            internal State16라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_4__0$", duration: 4000, boxId: 0);
                context.DarkStreamSpawnMonster(spawnIds: new []{116001}, score: 73000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{116001})) {
                    context.DarkStreamClearRound(round: 16);
                    context.SetAchievement(triggerId: 104, type: "trigger", code: "16roundpass");
                    return new State17라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17라운드Wait : TriggerState {
            internal State17라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "17,20,16");
                context.DarkStreamStartRound(round: 17, uiDuration: 3000, damagePenalty: 50);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State17라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17라운드 : TriggerState {
            internal State17라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{117001}, score: 56250);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{117001})) {
                    context.DarkStreamClearRound(round: 17);
                    context.SetAchievement(triggerId: 104, type: "trigger", code: "17roundpass");
                    return new State18라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18라운드Wait : TriggerState {
            internal State18라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "18,20,16");
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 18, uiDuration: 3000, damagePenalty: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State18라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18라운드 : TriggerState {
            internal State18라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{118001}, score: 90000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{118001})) {
                    context.DarkStreamClearRound(round: 18);
                    context.SetAchievement(triggerId: 104, type: "trigger", code: "18roundpass");
                    return new State19라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19라운드Wait : TriggerState {
            internal State19라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "19,20,16");
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 19, uiDuration: 3000, damagePenalty: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State19라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19라운드 : TriggerState {
            internal State19라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{119001, 119002}, score: 80000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{119001, 119002})) {
                    context.DarkStreamClearRound(round: 19);
                    context.SetAchievement(triggerId: 104, type: "trigger", code: "19roundpass");
                    return new State20라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20라운드Wait : TriggerState {
            internal State20라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "20,20,16");
                context.SetEffect(triggerIds: new []{6401}, visible: true);
                context.SetTimer(timerId: "3", seconds: 3);
                context.DarkStreamStartRound(round: 20, uiDuration: 3000, damagePenalty: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State20라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20라운드 : TriggerState {
            internal State20라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{120001}, score: 600000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{120001})) {
                    context.DarkStreamClearRound(round: 20);
                    context.SetAchievement(triggerId: 104, type: "trigger", code: "20roundpass");
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
                    context.SetEffect(triggerIds: new []{640}, visible: true);
                    context.SetSkill(triggerIds: new []{705}, enabled: true);
                    context.SetMesh(triggerIds: new []{3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
