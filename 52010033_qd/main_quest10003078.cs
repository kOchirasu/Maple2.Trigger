namespace Maple2.Trigger._52010033_qd {
    public static class _main_quest10003078 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003078}, arg3: new byte[] {2})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.VisibleMyPc(isVisible: false);
                context.MoveUser(arg1: 52010033, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State티나감사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티나감사 : TriggerState {
            internal State티나감사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "나메드들어옴02", arg2: "exit");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003420, msg: "$52010033_QD__MAIN_QUEST10003078__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010033_QD__MAIN_QUEST10003078__1$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003420, msg: "$52010033_QD__MAIN_QUEST10003078__2$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State나메드들어옴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드들어옴 : TriggerState {
            internal State나메드들어옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.CameraSelectPath(arg1: new[] {4002, 4001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.ShowCaption(type: "VerticalCaption", title: "$52010033_QD__MAIN_QUEST10003078__3$", desc: "$52010033_QD__MAIN_QUEST10003078__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010033_QD__MAIN_QUEST10003078__5$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010033_QD__MAIN_QUEST10003078__6$", duration: 4500);
                context.AddCinematicTalk(npcId: 11003420, msg: "$52010033_QD__MAIN_QUEST10003078__7$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010033_QD__MAIN_QUEST10003078__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010033_QD__MAIN_QUEST10003078__9$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010033_QD__MAIN_QUEST10003078__10$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    return new State나메드들어옴_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드들어옴_1 : TriggerState {
            internal State나메드들어옴_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State나메드들어옴02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드들어옴02 : TriggerState {
            internal State나메드들어옴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010032, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}