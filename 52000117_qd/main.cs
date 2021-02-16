namespace Maple2.Trigger._52000117_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100015}, arg3: new byte[] {1})) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveUser(arg1: 52000117, arg2: 6001);
            }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJordyidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyidle : TriggerState {
            internal StateJordyidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__0$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__1$", duration: 3000);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePcmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePcmove : TriggerState {
            internal StatePcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__3$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWow(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWow : TriggerState {
            internal StateWow(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
                context.AddCinematicTalk(npcId: 0, msg: "$52000117_QD__MAIN__15$", duration: 2000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 3000f);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 3000f);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000117_QD__MAIN__5$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000117_QD__MAIN__6$", duration: 3000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__7$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetPcEmotionLoop(arg1: "Emotion_Dance_S", arg2: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePctalk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePctalk : TriggerState {
            internal StatePctalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Talk_A,Talk_B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__9$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__10$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__11$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__12$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, msg: "$52000117_QD__MAIN__13$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fadeout : TriggerState {
            internal StateScene_fadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJordydel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordydel : TriggerState {
            internal StateJordydel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_fadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fadein : TriggerState {
            internal StateScene_fadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "jordyhello");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndmessage(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndmessage : TriggerState {
            internal StateEndmessage(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000117_QD__MAIN__14$", arg3: 3000, arg4: "0");
                context.MoveUser(arg1: 52000118, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndmessage(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}