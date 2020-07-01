namespace Maple2.Trigger._02000207_bf {
    public static class _lavaflow {
        public class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "LavaflowHigh") == 1) {
                    context.State = new State3칸분기(context);
                    return;
                }

                if (context.GetUserValue(key: "LavaflowLow") == 1) {
                    context.State = new State2칸분기(context);
                    return;
                }

                if (context.GetUserValue(key: "LavaflowLeft") == 1) {
                    context.State = new State왼쪽용암생성(context);
                    return;
                }

                if (context.GetUserValue(key: "LavaflowRight") == 1) {
                    context.State = new State오른쪽용암생성(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3칸분기 : TriggerState {
            internal State3칸분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowHigh", value: 0);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 52f)) {
                    context.State = new State3칸이동(context);
                    return;
                }

                if (context.RandomCondition(arg1: 48f)) {
                    context.State = new State리턴(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3칸이동 : TriggerState {
            internal State3칸이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 28000)) {
                    context.State = new State리턴(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2칸분기 : TriggerState {
            internal State2칸분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowLow", value: 0);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 99f)) {
                    context.State = new State2칸이동(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new State리턴(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2칸이동 : TriggerState {
            internal State2칸이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State리턴(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리턴 : TriggerState {
            internal State리턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {1001});
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암생성 : TriggerState {
            internal State왼쪽용암생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeftStop", value: 0);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "LavaflowLeftStop") == 1) {
                    context.State = new State왼쪽용암내려가기(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암내려가기 : TriggerState {
            internal State왼쪽용암내려가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeftStop", value: 0);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {1002});
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오른쪽용암생성 : TriggerState {
            internal State오른쪽용암생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowRight", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowRightStop", value: 0);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003A");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "LavaflowRightStop") == 1) {
                    context.State = new State오른쪽용암내려가기(context);
                    return;
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오른쪽용암내려가기 : TriggerState {
            internal State오른쪽용암내려가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowRight", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowRightStop", value: 0);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {1003});
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.DestroyMonster(arg1: new[] {1002});
                context.DestroyMonster(arg1: new[] {1003});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}