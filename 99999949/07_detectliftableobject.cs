namespace Maple2.Trigger._99999949 {
    public static class _07_detectliftableobject {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9061})) {
                    return new StateGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "7번 영역에 들어가면 DetectLiftableObject 트리거가 발동됩니다.");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9060})) {
                    return new StateReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady01 : TriggerState {
            internal StateReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "DetectLiftableObject 2초 후에 시작됩니다.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReady02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady02 : TriggerState {
            internal StateReady02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__0$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuizRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuizRandom01 : TriggerState {
            internal StateQuizRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    return new StateAnswerIsWood01(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateAnswerIsRock01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnswerIsWood01 : TriggerState {
            internal StateAnswerIsWood01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__1$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9062}, itemId: 0)) {
                    return new StateCheckAnswerWood01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswerWood01 : TriggerState {
            internal StateCheckAnswerWood01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9062}, itemId: 30000377)) {
                    return new StateRightAnswerWood01(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9062}, itemId: 30000377)) {
                    return new StateWrongAnswerWood01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightAnswerWood01 : TriggerState {
            internal StateRightAnswerWood01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__2$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateClearDetectBox01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWrongAnswerWood01 : TriggerState {
            internal StateWrongAnswerWood01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__3$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateClearDetectBox01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnswerIsRock01 : TriggerState {
            internal StateAnswerIsRock01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__4$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9062}, itemId: 0)) {
                    return new StateCheckAnswerRock01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswerRock01 : TriggerState {
            internal StateCheckAnswerRock01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9062}, itemId: 30000440)) {
                    return new StateRightAnswerRock01(context);
                }

                if (!context.DetectLiftableObject(boxIds: new []{9062}, itemId: 30000440)) {
                    return new StateWrongAnswerRock01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRightAnswerRock01 : TriggerState {
            internal StateRightAnswerRock01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__5$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateClearDetectBox01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWrongAnswerRock01 : TriggerState {
            internal StateWrongAnswerRock01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$99999949__07_DETECTLIFTABLEOBJECT__6$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateClearDetectBox01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearDetectBox01 : TriggerState {
            internal StateClearDetectBox01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.DetectLiftableObject(boxIds: new []{9062}, itemId: 0)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "3초 후에 트리거가 리셋됩니다. 7번 영역 밖으로 나가세요.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
