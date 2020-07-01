namespace Maple2.Trigger._02000426_bf {
    public static class _bossspawn {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "ZakumBodyAppearance", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State던전코드별보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전코드별보스등장 : TriggerState {
            internal State던전코드별보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonId() == 23040003) {
                    return new State어려운난이도보스등장(context);
                }

                if (context.GetDungeonId() == 23041003) {
                    return new State쉬운난이도보스등장(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State어려운난이도보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려운난이도보스등장 : TriggerState {
            internal State어려운난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉬운난이도보스등장 : TriggerState {
            internal State쉬운난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ZakumBodyAppearance") == 1) {
                    return new State자쿰몸체등장(context);
                }

                if (context.GetUserValue(key: "ZakumDungeonEnd") == 1) {
                    return new State종료딜레이(context);
                }

                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자쿰몸체등장 : TriggerState {
            internal State자쿰몸체등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ZakumBodyAppearance", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonId() == 23040003) {
                    return new State어려운난이도_자쿰몸등장(context);
                }

                if (context.GetDungeonId() == 23041003) {
                    return new State쉬운난이도_자쿰몸등장(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State어려운난이도_자쿰몸등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려운난이도_자쿰몸등장 : TriggerState {
            internal State어려운난이도_자쿰몸등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉬운난이도_자쿰몸등장 : TriggerState {
            internal State쉬운난이도_자쿰몸등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.SetAchievement(arg3: "ZakumKritiasClear");
                context.SetUserValue(triggerId: 999103, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 999102, key: "BattleEnd2", value: 1);
                context.SetUserValue(triggerId: 999108, key: "BattleEnd2", value: 1);
                context.SetUserValue(triggerId: 999109, key: "BattleEnd2", value: 1);
                context.SetMesh(arg1: new[] {3002, 3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(arg1: 199, arg2: 50005300);
                context.RemoveBuff(arg1: 199, arg2: 50005301);
                context.RemoveBuff(arg1: 199, arg2: 50001450);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.DungeonClear();
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.SetUserValue(triggerId: 999103, key: "BattleEnd", value: 1);
                context.SetMesh(arg1: new[] {3002, 3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(arg1: 199, arg2: 50005300);
                context.RemoveBuff(arg1: 199, arg2: 50005301);
                context.RemoveBuff(arg1: 199, arg2: 50001450);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}