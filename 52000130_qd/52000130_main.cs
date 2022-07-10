using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000130_qd {
    public static class _52000130_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동_01 : TriggerState {
            internal StatePC이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카일과대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일과대화_01 : TriggerState {
            internal State카일과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일과대화_02 : TriggerState {
            internal State카일과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State카일이동_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__0$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State카일과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일과대화_03 : TriggerState {
            internal State카일과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일과대화_04 : TriggerState {
            internal State카일과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000130_QD__52000130_MAIN__1$", duration: 3500, align: Align.Right);
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State카일과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일과대화_05 : TriggerState {
            internal State카일과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일과대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일과대화_06 : TriggerState {
            internal State카일과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__2$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State카일이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일이동_01 : TriggerState {
            internal State카일이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일이동_02 : TriggerState {
            internal State카일이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카일공격_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일공격_01 : TriggerState {
            internal State카일공격_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카일공격_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카일공격_02 : TriggerState {
            internal State카일공격_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Emotion_Failure_A", duration: 30000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State습격후대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_01 : TriggerState {
            internal State습격후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State습격후대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_02 : TriggerState {
            internal State습격후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State씬스킵_01(context), arg2: "exit");
                context.AddCinematicTalk(npcId: 0, script: "$52000130_QD__52000130_MAIN__3$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State습격후대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_03 : TriggerState {
            internal State습격후대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__4$", duration: 3500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State습격후대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_04 : TriggerState {
            internal State습격후대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000130_QD__52000130_MAIN__6$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State습격후대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_05 : TriggerState {
            internal State습격후대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__7$", duration: 3500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__8$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State습격후대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_06 : TriggerState {
            internal State습격후대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000130_QD__52000130_MAIN__9$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State습격후대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_07 : TriggerState {
            internal State습격후대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__10$", duration: 3500, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__11$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new State습격후대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State습격후대화_08 : TriggerState {
            internal State습격후대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000130_QD__52000130_MAIN__12$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFadeOut_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_01 : TriggerState {
            internal StateFadeOut_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadeOut_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_02 : TriggerState {
            internal StateFadeOut_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003371, script: "$52000130_QD__52000130_MAIN__13$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씬스킵_01 : TriggerState {
            internal State씬스킵_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000131, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
