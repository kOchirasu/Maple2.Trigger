namespace Maple2.Trigger._63000030_cs {
    public static class _push02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6107, 6006}, visible: false);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112}, visible: false);
                context.SetSkill(triggerIds: new []{7000}, arg2: false);
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "PushStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PushStart") == 1) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StatePush01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePush01 : TriggerState {
            internal StatePush01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7000}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTalkRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalkRandom : TriggerState {
            internal StateNpcTalkRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    return new StateJuntaTalk01(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateTinChaiTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaTalk01 : TriggerState {
            internal StateJuntaTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{6107}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000030_CS__PUSH02__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{6006}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__PUSH02__1$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReset01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset01 : TriggerState {
            internal StateReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StatePush01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
