using System;

namespace Maple2.Trigger._99999911 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State최초(context);

        private class State최초 : TriggerState {
            internal State최초(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
                    context.State = new State시작조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작조건체크 : TriggerState {
            internal State시작조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State어나운스0(context);
                    return;
                }

                if (context.CountUsers(arg1: 701, arg2: 20)) {
                    context.State = new State어나운스0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$99999911__MAIN__0$", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State어나운스1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000004_ME__TRIGGER_01__1$", stage: 0, count: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.SetMesh(arg1: new int[] {301, 302, 303}, arg2: false, arg3: 12, arg4: 0);
                    context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "dailyquest_start");
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new int[] {102}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new int[] {103}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new int[] {104}, arg2: true, arg3: 4);
                context.CreateMonster(arg1: new int[] {105}, arg2: true, arg3: 5);
                context.CreateMonster(arg1: new int[] {106}, arg2: true, arg3: 6);
                context.CreateMonster(arg1: new int[] {107}, arg2: true, arg3: 7);
                context.CreateMonster(arg1: new int[] {108}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {301}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new int[] {302}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new int[] {303}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new int[] {304}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {305}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new int[] {306}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new int[] {307}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new int[] {308}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {309}, arg2: true, arg3: 1);
                context.CreateMonster(arg1: new int[] {310}, arg2: true, arg3: 2);
                context.CreateMonster(arg1: new int[] {311}, arg2: true, arg3: 3);
                context.CreateMonster(arg1: new int[] {312}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateRound1_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound1_Start : TriggerState {
            internal StateRound1_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991104, key: "Round_02", value: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    // context.State = new Staterandom_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}