namespace Maple2.Trigger._02000498_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{500, 501}, visible: true);
                context.SetEffect(triggerIds: new []{600, 601, 610, 6010, 6011, 6012, 6013, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032, 6110, 6111, 6112, 6113, 6101}, visible: false);
                context.SetSkill(triggerIds: new []{701, 702}, enabled: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100009})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{100009}, skillId: 70000102, level: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100001})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6011, 6012}, visible: true);
                context.SetEventUI(arg1: 1, script: "다크스크림의 새로운 차원의 틈으로 진입 했습니다.", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100002})) {
                    return new StateStartCinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_2 : TriggerState {
            internal StateStartCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6013, 6010}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100003})) {
                    return new StateStartCinematic_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_3 : TriggerState {
            internal StateStartCinematic_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6023, 6022}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100004})) {
                    return new StateStartCinematic_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_4 : TriggerState {
            internal StateStartCinematic_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6021, 6024}, visible: true);
                context.SetEventUI(arg1: 1, script: "더 가까이 다가가십시오.", duration: 3000);
                context.SetEffect(triggerIds: new []{500, 501}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100005})) {
                    return new StateStartCinematic_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_5 : TriggerState {
            internal StateStartCinematic_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6028, 6027}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100006})) {
                    return new StateStartCinematic_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_6 : TriggerState {
            internal StateStartCinematic_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6025, 6026}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100007})) {
                    return new StateStartCinematic_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_7 : TriggerState {
            internal StateStartCinematic_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6032, 6029}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100008})) {
                    return new StateStartCinematic_8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_8 : TriggerState {
            internal StateStartCinematic_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6031, 6030}, visible: true);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
