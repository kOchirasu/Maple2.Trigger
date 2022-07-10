namespace Maple2.Trigger._99999911 {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateStartConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartConditionCheck : TriggerState {
            internal StateStartConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State어나운스0(context);
                }

                if (context.GetUserCount(boxId: 701) == 20) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999911__MAIN__0$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000004_ME__TRIGGER_01__1$", stage: 0, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.SetMesh(triggerIds: new []{301, 302, 303}, visible: false, arg3: 12, arg4: 0);
                    context.SetAchievement(triggerId: 101, type: "trigger", code: "dailyquest_start");
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true, arg3: 1);
                context.CreateMonster(spawnIds: new []{102}, arg2: true, arg3: 2);
                context.CreateMonster(spawnIds: new []{103}, arg2: true, arg3: 3);
                context.CreateMonster(spawnIds: new []{104}, arg2: true, arg3: 4);
                context.CreateMonster(spawnIds: new []{105}, arg2: true, arg3: 5);
                context.CreateMonster(spawnIds: new []{106}, arg2: true, arg3: 6);
                context.CreateMonster(spawnIds: new []{107}, arg2: true, arg3: 7);
                context.CreateMonster(spawnIds: new []{108}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{301}, arg2: true, arg3: 1);
                context.CreateMonster(spawnIds: new []{302}, arg2: true, arg3: 2);
                context.CreateMonster(spawnIds: new []{303}, arg2: true, arg3: 3);
                context.CreateMonster(spawnIds: new []{304}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{305}, arg2: true, arg3: 1);
                context.CreateMonster(spawnIds: new []{306}, arg2: true, arg3: 2);
                context.CreateMonster(spawnIds: new []{307}, arg2: true, arg3: 3);
                context.CreateMonster(spawnIds: new []{308}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{309}, arg2: true, arg3: 1);
                context.CreateMonster(spawnIds: new []{310}, arg2: true, arg3: 2);
                context.CreateMonster(spawnIds: new []{311}, arg2: true, arg3: 3);
                context.CreateMonster(spawnIds: new []{312}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateRound1_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound1_Start : TriggerState {
            internal StateRound1_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991104, key: "Round_02", value: 1);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    // return new StateRandom_start(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
