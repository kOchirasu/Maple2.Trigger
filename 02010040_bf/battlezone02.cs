namespace Maple2.Trigger._02010040_bf {
    public static class _battlezone02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {4201, 4202}, arg2: false);
                context.SetMesh(arg1: new[] {1200, 1201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 2200, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 2201, arg2: true, arg3: "Closed");
                context.SetAgent(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405, 406, 407, 408}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {301, 302, 303, 304, 305, 306, 401, 402, 403, 404, 405, 406, 407, 408})) {
                    return new State문열기(context);
                }

                return null;
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
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}