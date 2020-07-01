namespace Maple2.Trigger._02020097_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 28, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 201, 202, 203, 204, 205, 206, 207, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {99}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기상태 : TriggerState {
            internal State대기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "StairsOk") == 1) {
                    context.State = new State계단생성시작중(context);
                    return;
                }

                if (context.GetUserValue(key: "StairsOk2nd") == 1) {
                    context.State = new State계단생성시작중2nd(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {11})) {
                    context.State = new State플레이어3페이지전투판으로오기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    context.State = new State연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성시작중 : TriggerState {
            internal State계단생성시작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State계단생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성 : TriggerState {
            internal State계단생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207}, arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
                context.SetUserValue(key: "StairsOk", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성시작중2nd : TriggerState {
            internal State계단생성시작중2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State계단생성2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성2nd : TriggerState {
            internal State계단생성2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239}, arg2: true, arg3: 1, arg4: 50, arg5: 0.5f);
                context.SetUserValue(key: "StairsOk2nd", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State칸막이제거2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸막이제거2nd : TriggerState {
            internal State칸막이제거2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State플레이어3페이지전투판으로오기 : TriggerState {
            internal State플레이어3페이지전투판으로오기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "3PhaseSetOk", value: 1);
                context.SetPortal(arg1: 28, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    context.State = new State연출딜레이(context);
                    return;
                }

                if (context.GetUserValue(key: "StairsOk") == 1) {
                    // context.State = new State사다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출딜레이 : TriggerState {
            internal State연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "BalrogKritiasClear");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}