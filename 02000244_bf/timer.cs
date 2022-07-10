using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000244_bf {
    public static class _timer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{798, 799}, visible: true);
                context.SetEffect(triggerIds: new []{2001, 2002}, visible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{205})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{798, 799}, visible: false);
                context.SetTimer(timerId: "89", seconds: 3, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "89")) {
                    return new State목소리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목소리 : TriggerState {
            internal State목소리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2001}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000244_BF__TIMER__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
