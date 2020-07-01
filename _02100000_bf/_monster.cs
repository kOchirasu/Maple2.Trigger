namespace Maple2.Trigger._02100000_bf {
    public static class _monster {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {80001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {9500001, 9500002, 9500003, 9500004, 9500005, 9500006, 9500007, 9500008, 9500009, 9500010},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        9600001, 9600002, 9600003, 9600004, 9600005, 9600006, 9600007, 9600008, 9600009, 9600010,
                        9600011, 9600012, 9600013, 9600014
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: true);
                context.SetPortal(arg1: 19, arg2: false, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new State몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {80001}, arg2: true);
                context.CreateMonster(arg1: new[] {800011}, arg2: true);
                context.CreateMonster(arg1: new[] {81001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터사망_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_1 : TriggerState {
            internal State몬스터사망_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {80001})) {
                    context.State = new State몬스터등장_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2 : TriggerState {
            internal State몬스터등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {80002}, arg2: true);
                context.CreateMonster(arg1: new[] {800021}, arg2: true);
                context.CreateMonster(arg1: new[] {810021}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터사망_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_2 : TriggerState {
            internal State몬스터사망_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {80002})
                    && context.MonsterDead(arg1: new[] {800021})
                    && context.MonsterDead(arg1: new[] {800011})) {
                    context.State = new State몬스터등장_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_3 : TriggerState {
            internal State몬스터등장_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {81001});
                context.DestroyMonster(arg1: new[] {81002});
                context.DestroyMonster(arg1: new[] {810021});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈생성 : TriggerState {
            internal State포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {9500001, 9500002, 9500003, 9500004, 9500005, 9500006, 9500007, 9500008, 9500009, 9500010},
                    arg2: true, arg3: 0, arg4: 90, arg5: 1f);
                context.SetMesh(
                    arg1: new[] {
                        9600001, 9600002, 9600003, 9600004, 9600005, 9600006, 9600007, 9600008, 9600009, 9600010,
                        9600011, 9600012, 9600013, 9600014
                    }, arg2: true, arg3: 0, arg4: 90, arg5: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State길생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길생성 : TriggerState {
            internal State길생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {80001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) { }
            }

            public override void OnExit() { }
        }
    }
}