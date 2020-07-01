namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {4201, 4202}, arg2: false);
                context.SetMesh(arg1: new[] {1200, 1201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 2200, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2201, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405, 406, 407, 408}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405, 406, 407, 408})) {
                    context.State = new State문열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1200, 1201}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {4201, 4202}, arg2: true);
                context.SetActor(arg1: 2200, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 2201, arg2: true, arg3: "Opened");
                context.SetAgent(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208}, arg2: false);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}