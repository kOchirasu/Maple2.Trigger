using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000117_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100015}, questStates: new byte[]{1})) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveUser(mapId: 52000117, portalId: 6001);
            }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__0$", duration: 3000, illustId: "Jordy_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__1$", duration: 3000);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Angry_A"});
                context.AddCinematicTalk(npcId: 0, script: "$52000117_QD__MAIN__15$", duration: 2000);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Sit_Down_A", duration: 3000f);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Sit_Down_A", duration: 3000f);
                context.AddBalloonTalk(spawnId: 101, msg: "$52000117_QD__MAIN__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.AddBalloonTalk(spawnId: 101, msg: "$52000117_QD__MAIN__6$", duration: 3000);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__7$", duration: 3000);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetPcEmotionLoop(sequenceName: "Emotion_Dance_S", duration: 3000f);
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A", "Talk_B"});
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__10$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__12$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003166, script: "$52000117_QD__MAIN__13$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{101});
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "jordyhello");
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000117_QD__MAIN__14$", duration: 3000, boxId: 0);
                context.MoveUser(mapId: 52000118, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndmessage(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
