namespace Maple2.Trigger._02000207_bf {
    public static class _bossspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ZakumDungeonEnd") == 1) {
                    context.State = new State종료딜레이(context);
                    return;
                }

                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.GetDungeonState() == "Fail") {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999103, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 999102, key: "BattleEnd2", value: 1);
                context.SetUserValue(triggerId: 999108, key: "BattleEnd2", value: 1);
                context.SetUserValue(triggerId: 999109, key: "BattleEnd2", value: 1);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.DungeonClear();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetUserValue(triggerId: 999103, key: "BattleEnd", value: 1);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}