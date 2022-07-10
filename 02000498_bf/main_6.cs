namespace Maple2.Trigger._02000498_bf {
    public static class _main_6 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3601}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{6601, 6602}, visible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6601}, visible: true);
                context.DarkStreamStartRound(round: 26, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEventUI(arg1: 0, script: "26,30,26");
                    return new State26라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State26라운드 : TriggerState {
            internal State26라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_6__0$", duration: 4000, boxId: 0);
                context.DarkStreamSpawnMonster(spawnIds: new []{126001}, score: 2200000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{126001})) {
                    context.DarkStreamClearRound(round: 26);
                    context.SetAchievement(triggerId: 106, type: "trigger", code: "26roundpass");
                    return new State27라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27라운드Wait : TriggerState {
            internal State27라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6601}, visible: true);
                context.DarkStreamStartRound(round: 27, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEventUI(arg1: 0, script: "27,30,26");
                    return new State27라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27라운드 : TriggerState {
            internal State27라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{127001}, score: 2500000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{127001})) {
                    context.DarkStreamClearRound(round: 27);
                    context.SetAchievement(triggerId: 106, type: "trigger", code: "27roundpass");
                    return new State28라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28라운드Wait : TriggerState {
            internal State28라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6601}, visible: true);
                context.DarkStreamStartRound(round: 28, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEventUI(arg1: 0, script: "28,30,26");
                    return new State28라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28라운드 : TriggerState {
            internal State28라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{128001}, score: 3000000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{128001})) {
                    context.DarkStreamClearRound(round: 28);
                    context.SetAchievement(triggerId: 106, type: "trigger", code: "28roundpass");
                    return new State29라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29라운드Wait : TriggerState {
            internal State29라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6601}, visible: true);
                context.DarkStreamStartRound(round: 29, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEventUI(arg1: 0, script: "29,30,26");
                    return new State29라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29라운드 : TriggerState {
            internal State29라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{129001}, score: 5000000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{129001})) {
                    context.DarkStreamClearRound(round: 29);
                    context.SetAchievement(triggerId: 106, type: "trigger", code: "29roundpass");
                    return new State30라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30라운드Wait : TriggerState {
            internal State30라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6602}, visible: true);
                context.DarkStreamStartRound(round: 30, uiDuration: 3000, damagePenalty: 200);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.SetEventUI(arg1: 0, script: "30,30,26");
                    return new State30라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30라운드 : TriggerState {
            internal State30라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3601}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{130001}, arg2: true);
                context.DarkStreamSpawnMonster(spawnIds: new []{130002}, score: 8000000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{130002})) {
                    context.SetMesh(triggerIds: new []{3601}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.DestroyMonster(spawnIds: new []{130001});
                    context.DarkStreamClearRound(round: 30);
                    context.SetAchievement(triggerId: 106, type: "trigger", code: "30roundpass");
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEventUI(arg1: 7, script: "$02000350_BF__MAIN_6__1$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000350_BF__MAIN_6__2$", duration: 2500, boxId: 0);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
