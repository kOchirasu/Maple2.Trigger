namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {4301, 4302, 4303}, arg2: false);
                context.SetMesh(arg1: new[] {1300, 1301, 1302}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 2300, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2301, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2302, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new State전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {501, 502, 601, 602, 701, 702}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {501, 502, 601, 602, 701, 702})) {
                    return new State문열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1300, 1301, 1302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {4301, 4302, 4303}, arg2: true);
                context.SetActor(arg1: 2300, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 2301, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 2302, arg2: true, arg3: "Opened");
                context.SetAgent(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312}, arg2: false);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}