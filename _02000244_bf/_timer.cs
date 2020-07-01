using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000244_bf {
    public static class _timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {798, 799}, arg2: true);
                context.SetEffect(arg1: new[] {2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 205) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {205})) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {798, 799}, arg2: false);
                context.SetTimer(arg1: "89", arg2: 3, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "89")) {
                    return new State목소리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목소리 : TriggerState {
            internal State목소리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2001}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000244_BF__TIMER__0$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}