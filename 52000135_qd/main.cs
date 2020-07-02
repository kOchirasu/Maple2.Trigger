namespace Maple2.Trigger._52000135_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102});
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: false);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001175}, arg2: 1);
                context.SetEffect(arg1: new[] {3010, 3011, 3012}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001582}, arg3: new byte[] {1})) {
                    return new State연출이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001581}, arg3: new byte[] {3})) {
                    return new State연출이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001581}, arg3: new byte[] {2})) {
                    return new State연출이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001581}, arg3: new byte[] {1})) {
                    return new State연출대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출이후 : TriggerState {
            internal State연출이후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출대기 : TriggerState {
            internal State연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000135, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사01 : TriggerState {
            internal State아노스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_01");
                context.AddCinematicTalk(npcId: 11003251, illustId: "Anos_normal", msg: "$52000135_QD__MAIN__0$", duration: 4000, align: "right");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 8500f);
                context.SetSceneSkip(arg1: "오브젝트조사전_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사02 : TriggerState {
            internal State아노스대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "Anos_normal", msg: "$52000135_QD__MAIN__1$", duration: 4000, align: "right");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 6800f);
                context.SetSkip(arg1: "아노스대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사02_skip : TriggerState {
            internal State아노스대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사03(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사03 : TriggerState {
            internal State아노스대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: true);
                context.AddCinematicTalk(npcId: 11003251, illustId: "0", msg: "$52000135_QD__MAIN__2$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "ChatUp_A", arg3: 5400f);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_03");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트조사전_스킵완료 : TriggerState {
            internal State오브젝트조사전_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000135, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트조사 : TriggerState {
            internal State오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001175}, arg2: 0)) {
                    return new StateInteractObject이후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject이후 : TriggerState {
            internal StateInteractObject이후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetMesh(arg1: new[] {3000}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: true);
                context.SetEffect(arg1: new[] {3011}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001175}, arg2: 2);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_0301");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사04 : TriggerState {
            internal State아노스대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "Anos_normal", msg: "$52000135_QD__MAIN__3$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 7000f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_0201");
                context.SetSceneSkip(arg1: "오브젝트조사후_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사05 : TriggerState {
            internal State아노스대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "Anos_normal", msg: "$52000135_QD__MAIN__4$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 8300f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_0202");
                context.SetSkip(arg1: "아노스대사05_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사05_skip : TriggerState {
            internal State아노스대사05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사06(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사06 : TriggerState {
            internal State아노스대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "Anos_normal", msg: "$52000135_QD__MAIN__5$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 6500f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_0203");
                context.SetSkip(arg1: "아노스대사06_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스대사07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사06_skip : TriggerState {
            internal State아노스대사06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사07(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사07 : TriggerState {
            internal State아노스대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "Anos_normal", msg: "$52000135_QD__MAIN__6$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Chatup_A", arg3: 7900f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_0204");
                context.SetSkip(arg1: "아노스대사07_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크리스탈끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사07_skip : TriggerState {
            internal State아노스대사07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State크리스탈끄기(context);
            }

            public override void OnExit() { }
        }

        private class State크리스탈끄기 : TriggerState {
            internal State크리스탈끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_0205");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State크리스탈꺼짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리스탈꺼짐 : TriggerState {
            internal State크리스탈꺼짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: true);
                context.SetEffect(arg1: new[] {3011}, arg2: false);
                context.SetEffect(arg1: new[] {3012}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스대사08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사08 : TriggerState {
            internal State아노스대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "0", msg: "$52000135_QD__MAIN__7$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 11000f);
                context.SetEffect(arg1: new[] {3012}, arg2: false);
                context.SetSkip(arg1: "아노스대사08_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아시모프대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사08_skip : TriggerState {
            internal State아노스대사08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아시모프대사01(context);
            }

            public override void OnExit() { }
        }

        private class State아시모프대사01 : TriggerState {
            internal State아시모프대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003250, illustId: "0", msg: "$52000135_QD__MAIN__8$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 5100f);
                context.SetSkip(arg1: "아시모프대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스대사09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아시모프대사01_skip : TriggerState {
            internal State아시모프대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아노스대사09(context);
            }

            public override void OnExit() { }
        }

        private class State아노스대사09 : TriggerState {
            internal State아노스대사09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "0", msg: "$52000135_QD__MAIN__9$", duration: 3000, align: "right");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3800f);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_0302");
                context.SetSkip(arg1: "아노스대사09_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC크리스탈접근(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사09_skip : TriggerState {
            internal State아노스대사09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePC크리스탈접근(context);
            }

            public override void OnExit() { }
        }

        private class StatePC크리스탈접근 : TriggerState {
            internal StatePC크리스탈접근(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000135_QD__MAIN__10$", duration: 2000, align: "right");
                context.SetPcEmotionLoop(arg1: "Object_React_H", arg2: 1500f);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 2000f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크리스탈켜짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리스탈켜짐 : TriggerState {
            internal State크리스탈켜짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8011}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: false);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: true);
                context.SetEffect(arg1: new[] {3010}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000135_QD__MAIN__11$", duration: 3000, delayTick: 1000);
                context.SetPcEmotionSequence(arg1: "Emotion_Surprise_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마법사들접근(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마법사들접근 : TriggerState {
            internal State마법사들접근(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8012}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Asimov_05");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_04");
                context.SetEffect(arg1: new[] {3011}, arg2: true);
                context.SetPcEmotionSequence(arg1: "Emotion_Think_A");
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000135_QD__MAIN__12$", duration: 2000, delayTick: 100);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000135_QD__MAIN__13$", duration: 2000, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스대사10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사10 : TriggerState {
            internal State아노스대사10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "0", msg: "$52000135_QD__MAIN__14$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3400f);
                context.SetSkip(arg1: "아노스대사10_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사10_skip : TriggerState {
            internal State아노스대사10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePC대사(context);
            }

            public override void OnExit() { }
        }

        private class StatePC대사 : TriggerState {
            internal StatePC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000135_QD__MAIN__15$", duration: 3000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_06");
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State크리스탈다시꺼짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리스탈다시꺼짐 : TriggerState {
            internal State크리스탈다시꺼짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: true);
                context.SetEffect(arg1: new[] {3010, 3011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스대사11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사11 : TriggerState {
            internal State아노스대사11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003251, illustId: "0", msg: "$52000135_QD__MAIN__16$", duration: 5000, align: "right");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_07");
                context.SetSkip(arg1: "아노스대사11_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State아시모프대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스대사11_skip : TriggerState {
            internal State아노스대사11_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아시모프대사02(context);
            }

            public override void OnExit() { }
        }

        private class State아시모프대사02 : TriggerState {
            internal State아시모프대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003250, illustId: "Asimov_normal", msg: "$52000135_QD__MAIN__17$", duration: 3000, align: "left");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 8600f);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트조사후_스킵완료 : TriggerState {
            internal State오브젝트조사후_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Asimov_05");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_07");
                context.SetMesh(arg1: new[] {3000}, arg2: false);
                context.SetMeshAnimation(arg1: new[] {3000}, arg2: false);
                context.SetMesh(arg1: new[] {3001}, arg2: true);
                context.SetMeshAnimation(arg1: new[] {3001}, arg2: true);
                context.SetEffect(arg1: new[] {3010, 3011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "Studyindarkness");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
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

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}