namespace Maple2.Trigger._52100056_qd {
    public static class _99_bossspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new State룸체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State던전시작(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트던전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {900, 901}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBossBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트던전시작 : TriggerState {
            internal State퀘스트던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {910, 911}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {910, 911})) {
                    context.State = new StateQuestClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "CheckDualKill", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900, 901})) {
                    context.State = new StateBossBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {900, 901});
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Madracan02");
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Madracan_Q02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestClear : TriggerState {
            internal StateQuestClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "Madracan_Q02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.MoveUser(arg1: 02000402, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}