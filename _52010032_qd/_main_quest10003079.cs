namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003079 {
        public class State무르파고스에들어오면 : TriggerState {
            internal State무르파고스에들어오면(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003079}, arg3: new byte[] {1})) {
                    context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202, 301, 302});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady01 : TriggerState {
            internal StateReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.FaceEmotion(spawnPointId: 401, emotionName: "Trigger_angry");
                context.CreateMonster(arg1: new[] {401, 301, 302}, arg2: true);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대화시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작 : TriggerState {
            internal State대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Talk_A");
                context.MoveUser(arg1: 52010032, arg2: 6002);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__0$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__1$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__2$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__3$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State대화시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작01 : TriggerState {
            internal State대화시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__4$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010032_QD__MAIN_QUEST10003079__5$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__6$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State대화시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작02 : TriggerState {
            internal State대화시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Emotion_Focus_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52010032_QD__MAIN_QUEST10003079__7$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대화시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작03 : TriggerState {
            internal State대화시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Bore_A");
                context.FaceEmotion(spawnPointId: 203, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__8$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에바고르삐짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르삐짐 : TriggerState {
            internal State에바고르삐짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010032_QD__MAIN_QUEST10003079__9$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010032_QD__MAIN_QUEST10003079__10$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에바고르삐짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르삐짐01 : TriggerState {
            internal State에바고르삐짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__11$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010032_QD__MAIN_QUEST10003079__12$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__13$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__14$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new State에바고르삐짐02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르삐짐02 : TriggerState {
            internal State에바고르삐짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 302, arg2: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010032_QD__MAIN_QUEST10003079__15$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, msg: "$52010032_QD__MAIN_QUEST10003079__16$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에바고르퇴장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르퇴장 : TriggerState {
            internal State에바고르퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010032_QD__MAIN_QUEST10003079__17$", duration: 3000);
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3006");
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Namid");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에바고르퇴장후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르퇴장후 : TriggerState {
            internal State에바고르퇴장후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 401, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__18$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003389, msg: "$52010032_QD__MAIN_QUEST10003079__19$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003388, msg: "$52010032_QD__MAIN_QUEST10003079__20$", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State에바고르퇴장후_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르퇴장후_1 : TriggerState {
            internal State에바고르퇴장후_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State나메드에게퀘스트마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {302, 401});
                context.CameraReset(interpolationTime: 0.5f);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "Namid");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State나메드에게퀘스트마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드에게퀘스트마무리 : TriggerState {
            internal State나메드에게퀘스트마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.DestroyMonster(arg1: new[] {302, 401});
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}