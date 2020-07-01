namespace Maple2.Trigger._02100004_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateCheckUser10_GuildRaid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckUser10_GuildRaid : TriggerState {
            internal StateCheckUser10_GuildRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 199) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.GetUserCount(boxId: 199) < 10) {
                    return new StateMaxCount10_Wait(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateMaxCount10_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            internal StateMaxCount10_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 199) >= 10) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.TimeExpired(arg1: "99")) {
                    return new StateMaxCount10_Start(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMaxCount10_Wait(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateMaxCount10_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            internal StateMaxCount10_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "99");
            }

            public override TriggerState Execute() {
                return new StateDungeonStart(context);
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: "$02100004_BF__MAIN__0$");
                context.SetSkip(arg1: "Caption01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateCaption01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCaption01Skip : TriggerState {
            internal StateCaption01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State시작(context);
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CloseCinematic();
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.ShowGuideSummary(entityId: 20002411, textId: 20002411);
                context.SetUserValue(triggerId: 999993, key: "BattleStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State1라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드시작 : TriggerState {
            internal State1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002411);
                context.ShowCountUI(text: "$02100004_BF__MAIN__1$", stage: 0, count: 3);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "1,10");
                context.SetTimer(arg1: "1", arg2: 20, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State2라운드시작(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new State2라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State2라운드시작 : TriggerState {
            internal State2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__2$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "2", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "2,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State3라운드시작(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new State3라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "2");
            }
        }

        private class State3라운드시작 : TriggerState {
            internal State3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__3$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "3,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State4라운드시작(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State4라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "3");
            }
        }

        private class State4라운드시작 : TriggerState {
            internal State4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__4$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드 : TriggerState {
            internal State4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "4", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "4,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State5라운드시작(context);
                }

                if (context.TimeExpired(arg1: "4")) {
                    return new State5라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "4");
            }
        }

        private class State5라운드시작 : TriggerState {
            internal State5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__5$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드 : TriggerState {
            internal State5라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "5", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "5,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State6라운드시작(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    return new State6라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "5");
            }
        }

        private class State6라운드시작 : TriggerState {
            internal State6라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__6$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State6라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드 : TriggerState {
            internal State6라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "6", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "6,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State7라운드시작(context);
                }

                if (context.TimeExpired(arg1: "6")) {
                    return new State7라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "6");
            }
        }

        private class State7라운드시작 : TriggerState {
            internal State7라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__7$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State7라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드 : TriggerState {
            internal State7라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "7", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "7,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State8라운드시작(context);
                }

                if (context.TimeExpired(arg1: "7")) {
                    return new State8라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "7");
            }
        }

        private class State8라운드시작 : TriggerState {
            internal State8라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__8$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State8라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드 : TriggerState {
            internal State8라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "8", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "8,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State9라운드시작(context);
                }

                if (context.TimeExpired(arg1: "8")) {
                    return new State9라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "8");
            }
        }

        private class State9라운드시작 : TriggerState {
            internal State9라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetUserValue(triggerId: 999992, key: "RoundStart", value: 1);
                context.ShowCountUI(text: "$02100004_BF__MAIN__9$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State9라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드 : TriggerState {
            internal State9라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "9", arg2: 20, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "9,10");
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 199, arg2: new[] {0})) {
                    return new State10라운드시작(context);
                }

                if (context.TimeExpired(arg1: "9")) {
                    return new State10라운드시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "9");
            }
        }

        private class State10라운드시작 : TriggerState {
            internal State10라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CreateMonster(arg1: new[] {2000}, arg2: true);
                context.ShowCountUI(text: "$02100004_BF__MAIN__10$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State10라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드 : TriggerState {
            internal State10라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetTimer(arg1: "10", arg2: 150, arg3: true, arg4: true);
                context.MoveRandomUser(arg1: 02100004, arg2: 99, arg3: 101, arg4: 1);
                context.SetEventUI(arg1: 0, arg2: "10,10");
                context.SetUserValue(triggerId: 999995, key: "LastRoundStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2000})) {
                    context.ResetTimer(arg1: "10");
                    return new State성공(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetUserValue(triggerId: 999995, key: "LastRoundEnd", value: 1);
            }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999993, key: "BattleEnd", value: 1);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Find02100004");
                context.SetEventUI(arg1: 7, arg2: "$02000251_BF__TRIGGER_01_01__0$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$02100004_BF__MAIN__11$", arg3: 2000, arg4: "0");
                context.SetUserValue(triggerId: 999993, key: "BattleEnd", value: 1);
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonFail();
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}