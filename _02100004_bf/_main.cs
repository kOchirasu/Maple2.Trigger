using System;

namespace Maple2.Trigger._02100004_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new StateCheckUser10_GuildRaid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckUser10_GuildRaid : TriggerState {
            internal StateCheckUser10_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 199, arg2: 10, arg3: "GreaterEqual")) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }

                if (context.CountUsers(arg1: 199, arg2: 10, arg3: "Less")) {
                    context.State = new StateMaxCount10_Wait(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            internal StateMaxCount10_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 40012, textID: 40012, durationTime: 3000);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 199, arg2: 10, arg3: "GreaterEqual")) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }

                if (context.TimeExpired(arg1: "99")) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateMaxCount10_Wait(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new StateMaxCount10_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            internal StateMaxCount10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "99");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100004_BF__MAIN__0$");
                context.SetSkip(arg1: "Caption01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateCaption01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCaption01Skip : TriggerState {
            internal StateCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CloseCinematic();
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.ShowGuideSummary(entityID: 20002411, textID: 20002411);
                context.SetUserValue(triggerID: 999993, key: "BattleStart", value: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State1라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드시작 : TriggerState {
            internal State1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002411);
                context.ShowCountUI(text: "$02100004_BF__MAIN__1$", stage: 0, count: 3);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "1,10");
                context.SetTimer(arg1: "1", arg2: 20, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State2라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State2라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State2라운드시작 : TriggerState {
            internal State2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__2$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "2", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "2,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State3라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State3라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "2");
            }
        }

        private class State3라운드시작 : TriggerState {
            internal State3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__3$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State3라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "3,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State4라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State4라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "3");
            }
        }

        private class State4라운드시작 : TriggerState {
            internal State4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__4$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State4라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드 : TriggerState {
            internal State4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "4", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "4,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State5라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State5라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "4");
            }
        }

        private class State5라운드시작 : TriggerState {
            internal State5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__5$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State5라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드 : TriggerState {
            internal State5라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "5", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "5,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State6라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State6라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "5");
            }
        }

        private class State6라운드시작 : TriggerState {
            internal State6라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__6$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State6라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6라운드 : TriggerState {
            internal State6라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "6", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "6,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State7라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State7라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "6");
            }
        }

        private class State7라운드시작 : TriggerState {
            internal State7라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__7$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State7라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드 : TriggerState {
            internal State7라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "7", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "7,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State8라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "7")) {
                    context.State = new State8라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "7");
            }
        }

        private class State8라운드시작 : TriggerState {
            internal State8라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__8$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State8라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드 : TriggerState {
            internal State8라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "8", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "8,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State9라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State9라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "8");
            }
        }

        private class State9라운드시작 : TriggerState {
            internal State9라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetUserValue(triggerID: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__9$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State9라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드 : TriggerState {
            internal State9라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "9", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "9,10");
            }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new int[] {0})) {
                    context.State = new State10라운드시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "9")) {
                    context.State = new State10라운드시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "9");
            }
        }

        private class State10라운드시작 : TriggerState {
            internal State10라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.CreateMonster(arg1: new int[] {2000}, arg2: true);
                context.ShowCountUI(text: "$02100004_BF__MAIN__10$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State10라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드 : TriggerState {
            internal State10라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetTimer(arg1: "10", arg2: 150, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "10,10");
                context.SetUserValue(triggerID: 999995, key: "LastRoundStart", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2000})) {
                    context.ResetTimer(arg1: "10");
                    context.State = new State성공(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetUserValue(triggerID: 999995, key: "LastRoundEnd", value: 1);
            }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999993, key: "BattleEnd", value: 1);
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Find02100004");
                context.SetEventUI(arg1: 7, arg2: "$02000251_BF__TRIGGER_01_01__0$", arg3: new int[] {2000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$02100004_BF__MAIN__11$", arg3: new int[] {2000}, arg4: "0");
                context.SetUserValue(triggerID: 999993, key: "BattleEnd", value: 1);
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}