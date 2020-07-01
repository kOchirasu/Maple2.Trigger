namespace Maple2.Trigger._99999911 {
    public static class _main {
        public class State최초 : TriggerState {
            internal State최초(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new State시작조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작조건체크 : TriggerState {
            internal State시작조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetEventUI(arg1: 1, arg2: "$99999911__MAIN__0$", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.SetMesh(arg1: new[] {301, 302, 303}, arg2: false, arg3: 12, arg4: 0);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "dailyquest_start");
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new[] {102}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new[] {103}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new[] {104}, arg2: true, arg3: 4);
                context.CreateMonster(arg1: new[] {105}, arg2: true, arg3: 5);
                context.CreateMonster(arg1: new[] {106}, arg2: true, arg3: 6);
                context.CreateMonster(arg1: new[] {107}, arg2: true, arg3: 7);
                context.CreateMonster(arg1: new[] {108}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {301}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new[] {302}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new[] {303}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new[] {304}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {305}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new[] {306}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new[] {307}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new[] {308}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {309}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new[] {310}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new[] {311}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new[] {312}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
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
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    // return new Staterandom_start(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}