namespace Maple2.Trigger._52000127_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100215, 60100216, 60100217, 60100218, 60100219, 60100220}, arg3: new byte[] {2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100220, 60100221, 60100222, 60100223, 60100224, 60100225, 60100226, 60100227, 60100228, 60100229, 60100230}, arg3: new byte[] {2})) {
                    return new StateOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.VisibleMyPc(isVisible: true);
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.MoveUser(arg1: 52000127, arg2: 6001);
                context.SetSound(arg1: 7001, arg2: true);
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDreamscene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_01 : TriggerState {
            internal StateDreamscene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__0$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDreamscene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_02 : TriggerState {
            internal StateDreamscene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__1$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDreamscene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_03 : TriggerState {
            internal StateDreamscene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__2$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDreamscene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_04 : TriggerState {
            internal StateDreamscene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__3$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDreamscene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_05 : TriggerState {
            internal StateDreamscene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__4$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDreamscene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_06 : TriggerState {
            internal StateDreamscene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__5$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDreamscene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDreamscene_07 : TriggerState {
            internal StateDreamscene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000127_QD__MAIN__6$", arg3: false);
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 21000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Stun");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "Stun");
                context.ShowCaption(type: "VerticalCaption", title: "$52000127_QD__MAIN__12$", desc: "$52000127_QD__MAIN__13$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "Stun");
                context.AddCinematicTalk(npcId: 11003218, msg: "$52000127_QD__MAIN__7$", duration: 3000, illustId: "Jordy_normal", align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Stun");
                context.AddCinematicTalk(npcId: 11003218, msg: "$52000127_QD__MAIN__8$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003218, msg: "$52000127_QD__MAIN__9$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "calm");
                context.AddCinematicTalk(npcId: 0, msg: "$52000127_QD__MAIN__10$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Ride_Sp_Run_005");
                context.AddCinematicTalk(npcId: 11003218, msg: "$52000127_QD__MAIN__11$", duration: 3000, align: "Right");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen : TriggerState {
            internal StateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.VisibleMyPc(isVisible: true);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateOpen2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen2 : TriggerState {
            internal StateOpen2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}