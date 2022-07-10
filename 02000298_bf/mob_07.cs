namespace Maple2.Trigger._02000298_bf {
    public static class _mob_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603, 606}, visible: false);
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3211, 3212, 3213, 3214, 3215}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    context.CreateMonster(spawnIds: new []{1007}, arg2: false);
                    return new State방호벽Wait(context);
                }

                if (context.UserDetected(boxIds: new []{107})) {
                    context.CreateMonster(spawnIds: new []{1007}, arg2: false);
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
                if (context.MonsterDead(spawnIds: new []{1007})) {
                    return new State방호벽해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제 : TriggerState {
            internal State방호벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State11TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11TimedCreation : TriggerState {
            internal State11TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1011})) {
                    return new State방호벽해제2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제2 : TriggerState {
            internal State방호벽해제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{606}, visible: true);
                context.SetMesh(triggerIds: new []{3211, 3212, 3213, 3214, 3215}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
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
