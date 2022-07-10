namespace Maple2.Trigger._02000298_bf {
    public static class _mob_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602, 605}, visible: false);
                context.SetMesh(triggerIds: new []{3006, 3007, 3008, 3009, 3010, 3206, 3207, 3208, 3209, 3210}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    context.CreateMonster(spawnIds: new []{1005}, arg2: false);
                    return new State방호벽Wait(context);
                }

                if (context.UserDetected(boxIds: new []{103})) {
                    context.CreateMonster(spawnIds: new []{1005}, arg2: false);
                    return new State방호벽Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽Wait : TriggerState {
            internal State방호벽Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1005})) {
                    return new State방호벽해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제 : TriggerState {
            internal State방호벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetMesh(triggerIds: new []{3006, 3007, 3008, 3009, 3010}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State10TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10TimedCreation : TriggerState {
            internal State10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new State방호벽해제2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제2 : TriggerState {
            internal State방호벽해제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetMesh(triggerIds: new []{3206, 3207, 3208, 3209, 3210}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1800000", seconds: 1800000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
