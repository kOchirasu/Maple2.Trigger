namespace Maple2.Trigger._52000120_qd {
    public static class _01_henesysdefense {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.DestroyMonster(arg1: new[] {101, 102, 201, 202, 203, 204, 290, 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225, 240, 241, 242, 243, 244, 245, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 601, 602, 603, 604});
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 921, 922, 923, 924, 925, 926, 927, 928});
                context.DestroyMonster(arg1: new[] {605, 606, 607, 608, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 701, 702, 703, 704, 710, 711, 712, 713});
                context.CreateMonster(arg1: new[] {110, 111, 112, 120, 121, 122, 123, 124, 125, 126, 130, 131, 132, 133, 134, 135, 136, 140, 141, 142, 143, 144, 145, 146, 147, 150, 151, 152, 153, 154, 155, 156, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 185, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 113, 114, 115, 116, 117, 118}, arg2: false);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4500, arg2: true, arg3: "Interaction_bridge_A01_on");
                context.SetBreakable(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetCube(ids: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, isVisible: false);
                context.SetLocalCamera(cameraId: 10000, enable: false);
                context.SetLocalCamera(cameraId: 10001, enable: false);
                context.SetAgent(arg1: new[] {8001, 8002, 8003}, arg2: false);
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {1})) {
                    return new StateLoadingDelay01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {2})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(arg1: new[] {605, 606, 607, 608, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 101, 201, 501, 502, 507, 508, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 710, 711, 712, 713}, arg2: false);
                context.CameraSelect(arg1: 10, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLoadingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLeadersTalk_Manovich01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeadersTalk_Manovich01 : TriggerState {
            internal StateLeadersTalk_Manovich01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003221, msg: "$52000120_QD__01_HENESYSDEFENSE__0$", duration: 5000, align: "center", illustId: "Manovich_normal");
                context.SetSceneSkip(arg1: "SetLocalTargetCamera01cskip", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLeadersTalk_Manovich01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeadersTalk_Manovich01Skip : TriggerState {
            internal StateLeadersTalk_Manovich01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateLeadersTalk_Osckal01(context);
            }

            public override void OnExit() { }
        }

        private class StateLeadersTalk_Osckal01 : TriggerState {
            internal StateLeadersTalk_Osckal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__1$", duration: 4000, align: "center", illustId: "Oskhal_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLeadersTalk_Osckal01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeadersTalk_Osckal01Skip : TriggerState {
            internal StateLeadersTalk_Osckal01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 11, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000120_QD__01_HENESYSDEFENSE__2$", duration: 2000, delayTick: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLeadersLookAtPC01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeadersLookAtPC01 : TriggerState {
            internal StateLeadersLookAtPC01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLeadersLookAtPC02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeadersLookAtPC02 : TriggerState {
            internal StateLeadersLookAtPC02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange01 : TriggerState {
            internal StateCameraChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange02 : TriggerState {
            internal StateCameraChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 12, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange03 : TriggerState {
            internal StateCameraChange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk01 : TriggerState {
            internal StatePCTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000120_QD__01_HENESYSDEFENSE__3$", duration: 4000, align: "center", illustId: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk01Skip : TriggerState {
            internal StatePCTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateManovichTalk01(context);
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk01 : TriggerState {
            internal StateManovichTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003221, msg: "$52000120_QD__01_HENESYSDEFENSE__4$", duration: 5000, align: "center", illustId: "Manovich_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateManovichTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk01Skip : TriggerState {
            internal StateManovichTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk02 : TriggerState {
            internal StatePCTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000120_QD__01_HENESYSDEFENSE__5$", duration: 4000, align: "center", illustId: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk02Skip : TriggerState {
            internal StatePCTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateManovichTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk02 : TriggerState {
            internal StateManovichTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003221, msg: "$52000120_QD__01_HENESYSDEFENSE__6$", duration: 4000, align: "center", illustId: "Manovich_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateManovichTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk02Skip : TriggerState {
            internal StateManovichTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateOskhalTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk02 : TriggerState {
            internal StateOskhalTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__7$", duration: 5000, align: "center", illustId: "Oskhal_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateOskhalTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk02Skip : TriggerState {
            internal StateOskhalTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange05 : TriggerState {
            internal StateCameraChange05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 13, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraChange06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange06 : TriggerState {
            internal StateCameraChange06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 14, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateOskhalTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk03 : TriggerState {
            internal StateOskhalTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__8$", duration: 4000, align: "center", illustId: "Oskhal_serious");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateOskhalTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk03Skip : TriggerState {
            internal StateOskhalTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateOskhalTalk04(context);
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk04 : TriggerState {
            internal StateOskhalTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__9$", duration: 5000, align: "center", illustId: "Oskhal_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateOskhalTalk04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk04Skip : TriggerState {
            internal StateOskhalTalk04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateCameraChange11(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraChange11 : TriggerState {
            internal StateCameraChange11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange12 : TriggerState {
            internal StateCameraChange12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.MoveUser(arg1: 52000120, arg2: 10, arg3: 9900);
                context.CameraSelect(arg1: 15, arg2: true);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {102, 202, 210, 211, 212, 213, 214, 215}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange13 : TriggerState {
            internal StateCameraChange13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105}, arg2: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetBreakable(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange14 : TriggerState {
            internal StateCameraChange14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4500, arg2: true, arg3: "Interaction_bridge_A01_off");
                context.CameraSelect(arg1: 16, arg2: true);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 210, arg2: "MS2PatrolData_210");
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_211");
                context.MoveNpc(arg1: 212, arg2: "MS2PatrolData_212");
                context.MoveNpc(arg1: 213, arg2: "MS2PatrolData_213");
                context.MoveNpc(arg1: 214, arg2: "MS2PatrolData_214");
                context.MoveNpc(arg1: 215, arg2: "MS2PatrolData_215");
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraChange15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange15 : TriggerState {
            internal StateCameraChange15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSetLocalTargetCamera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetLocalTargetCamera01 : TriggerState {
            internal StateSetLocalTargetCamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105}, arg2: true, arg3: 500, arg4: 0, arg5: 2f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetLocalTargetCamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetLocalTargetCamera01cskip : TriggerState {
            internal StateSetLocalTargetCamera01cskip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 1);
                context.MoveUser(arg1: 52000120, arg2: 10, arg3: 9900);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetBreakable(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105}, arg2: true, arg3: 500, arg4: 0, arg5: 2f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetLocalTargetCamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetLocalTargetCamera02 : TriggerState {
            internal StateSetLocalTargetCamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8001, 8002, 8003}, arg2: true);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetLocalTargetCamera03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetLocalTargetCamera03 : TriggerState {
            internal StateSetLocalTargetCamera03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 10000, enable: true);
                context.SetCube(ids: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, isVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetLocalTargetCamera04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetLocalTargetCamera04 : TriggerState {
            internal StateSetLocalTargetCamera04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(arg1: new[] {901, 902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattleOnTheWallGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallGuide01 : TriggerState {
            internal StateBattleOnTheWallGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202, 210, 211, 212, 213, 214, 215});
                context.CreateMonster(arg1: new[] {203, 220, 221, 222, 223, 224, 225}, arg2: false);
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__10$", duration: 5000, align: "center", illustId: "Oskhal_normal");
                context.SetSceneSkip(arg1: "BattleOnTheWallGuide01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattleOnTheWallGuide01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallGuide01Skip : TriggerState {
            internal StateBattleOnTheWallGuide01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateBattleOnTheWallGuide02(context);
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallGuide02 : TriggerState {
            internal StateBattleOnTheWallGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: false);
                context.CreateMonster(arg1: new[] {903, 904}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003221, msg: "$52000120_QD__01_HENESYSDEFENSE__11$", duration: 4000, align: "center", illustId: "Manovich_normal");
                context.SetSceneSkip(arg1: "BattleOnTheWallGuide02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleOnTheWallGuide02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallGuide02Skip : TriggerState {
            internal StateBattleOnTheWallGuide02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleOnTheWallGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallGuide03 : TriggerState {
            internal StateBattleOnTheWallGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101201, textId: 25101201);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattleOnTheWallEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallEnd01 : TriggerState {
            internal StateBattleOnTheWallEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25101201);
                context.SetUserValue(triggerId: 4, key: "NpcDown", value: 1);
                context.SetUserValue(triggerId: 5, key: "NpcDown", value: 1);
                context.SetUserValue(triggerId: 6, key: "NpcDown", value: 1);
                context.SetUserValue(triggerId: 7, key: "NpcDown", value: 1);
                context.SetUserValue(triggerId: 8, key: "NpcDown", value: 1);
                context.SetUserValue(triggerId: 9, key: "NpcDown", value: 1);
                context.CreateMonster(arg1: new[] {905, 906}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBattleOnTheWallEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallEnd02 : TriggerState {
            internal StateBattleOnTheWallEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {907, 908}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBattleOnTheWallEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallEnd03 : TriggerState {
            internal StateBattleOnTheWallEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {909, 910}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateCallingBackUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallingBackUp01 : TriggerState {
            internal StateCallingBackUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__12$", duration: 5000, align: "center", illustId: "Oskhal_normal");
                context.SetSceneSkip(arg1: "PCVolunteer05CSkip", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCallingBackUp01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallingBackUp01Skip : TriggerState {
            internal StateCallingBackUp01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCVolunteer01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer01 : TriggerState {
            internal StatePCVolunteer01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetLocalCamera(cameraId: 10000, enable: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCVolunteer02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer02 : TriggerState {
            internal StatePCVolunteer02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000120, arg2: 20, arg3: 9900);
                context.CameraSelect(arg1: 20, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCVolunteer03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer03 : TriggerState {
            internal StatePCVolunteer03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCVolunteer04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer04 : TriggerState {
            internal StatePCVolunteer04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StatePCVolunteer05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer05 : TriggerState {
            internal StatePCVolunteer05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000120_QD__01_HENESYSDEFENSE__13$", duration: 4000, align: "center", illustId: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCVolunteer05Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer05Skip : TriggerState {
            internal StatePCVolunteer05Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                return new StateBattle01Start01(context);
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer05CSkip : TriggerState {
            internal StatePCVolunteer05CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000120, arg2: 20, arg3: 9900);
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 2);
                context.SetPcEmotionSequence(arg1: "Idle_A");
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                return new StateBattle01Start01(context);
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start01 : TriggerState {
            internal StateBattle01Start01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetActor(arg1: 4500, arg2: true, arg3: "Interaction_bridge_A01_on");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01Start02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start02 : TriggerState {
            internal StateBattle01Start02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, isVisible: false);
                context.DestroyMonster(arg1: new[] {701, 702, 703, 704, 710, 711, 712, 713});
                context.CreateMonster(arg1: new[] {300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 500, 503, 504, 505, 506, 509, 510, 601, 602, 603, 604, 701, 702, 703, 704}, arg2: false);
                context.MoveUser(arg1: 52000120, arg2: 30, arg3: 9900);
                context.CreateMonster(arg1: new[] {240, 241, 242, 243, 244, 245}, arg2: false);
                context.CameraSelect(arg1: 30, arg2: true);
                context.SetAgent(arg1: new[] {8001, 8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01Start03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start03 : TriggerState {
            internal StateBattle01Start03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105}, arg2: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetBreakable(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01Start04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start04 : TriggerState {
            internal StateBattle01Start04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4500, arg2: true, arg3: "Interaction_bridge_A01_off");
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
                context.MoveNpc(arg1: 240, arg2: "MS2PatrolData_240");
                context.MoveNpc(arg1: 241, arg2: "MS2PatrolData_241");
                context.MoveNpc(arg1: 242, arg2: "MS2PatrolData_242");
                context.MoveNpc(arg1: 243, arg2: "MS2PatrolData_243");
                context.MoveNpc(arg1: 244, arg2: "MS2PatrolData_244");
                context.MoveNpc(arg1: 245, arg2: "MS2PatrolData_245");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01Start05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start05 : TriggerState {
            internal StateBattle01Start05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 31, arg2: true);
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattle01Start06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start06 : TriggerState {
            internal StateBattle01Start06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105}, arg2: true, arg3: 500, arg4: 0, arg5: 2f);
                context.SetActor(arg1: 4500, arg2: true, arg3: "Interaction_bridge_A01_on");
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle01Start07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start07 : TriggerState {
            internal StateBattle01Start07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8001, 8002, 8003}, arg2: true);
                context.ChangeMonster(arg1: 203, arg2: 204);
                context.ChangeMonster(arg1: 240, arg2: 250);
                context.ChangeMonster(arg1: 241, arg2: 251);
                context.ChangeMonster(arg1: 242, arg2: 252);
                context.ChangeMonster(arg1: 243, arg2: 253);
                context.ChangeMonster(arg1: 244, arg2: 254);
                context.ChangeMonster(arg1: 245, arg2: 255);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101202, textId: 25101202);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateBattle01End01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01End01 : TriggerState {
            internal StateBattle01End01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25101202);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__14$", duration: 5000, align: "center", illustId: "Oskhal_normal");
                context.SetSceneSkip(arg1: "Battle01End01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattle01End01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01End01Skip : TriggerState {
            internal StateBattle01End01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910});
                context.MoveNpc(arg1: 230, arg2: "MS2PatrolData_230");
                context.MoveNpc(arg1: 231, arg2: "MS2PatrolData_231");
                context.MoveNpc(arg1: 232, arg2: "MS2PatrolData_232");
                context.MoveNpc(arg1: 233, arg2: "MS2PatrolData_233");
                context.MoveNpc(arg1: 234, arg2: "MS2PatrolData_234");
                context.MoveNpc(arg1: 235, arg2: "MS2PatrolData_235");
                context.MoveNpc(arg1: 250, arg2: "MS2PatrolData_250");
                context.MoveNpc(arg1: 251, arg2: "MS2PatrolData_251");
                context.MoveNpc(arg1: 252, arg2: "MS2PatrolData_252");
                context.MoveNpc(arg1: 253, arg2: "MS2PatrolData_253");
                context.MoveNpc(arg1: 254, arg2: "MS2PatrolData_254");
                context.MoveNpc(arg1: 255, arg2: "MS2PatrolData_255");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle01End02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle01End02 : TriggerState {
            internal StateBattle01End02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101203, textId: 25101203, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle02Start01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02Start01 : TriggerState {
            internal StateBattle02Start01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {911, 912}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattle02Start02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02Start02 : TriggerState {
            internal StateBattle02Start02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101204, textId: 25101204, duration: 5000);
                context.CreateMonster(arg1: new[] {913, 914}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {911, 912, 913, 914})) {
                    return new StateBattle02End01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02End01 : TriggerState {
            internal StateBattle02End01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003319, msg: "$52000120_QD__01_HENESYSDEFENSE__15$", duration: 5000, align: "center", illustId: "Oskhal_normal");
                context.SetSceneSkip(arg1: "Battle02End01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattle02End01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02End01Skip : TriggerState {
            internal StateBattle02End01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {911, 912, 913, 914});
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 250, arg2: "MS2PatrolData_250");
                context.MoveNpc(arg1: 251, arg2: "MS2PatrolData_251");
                context.MoveNpc(arg1: 252, arg2: "MS2PatrolData_252");
                context.MoveNpc(arg1: 253, arg2: "MS2PatrolData_253");
                context.MoveNpc(arg1: 254, arg2: "MS2PatrolData_254");
                context.MoveNpc(arg1: 255, arg2: "MS2PatrolData_255");
                context.MoveNpc(arg1: 230, arg2: "MS2PatrolData_230");
                context.MoveNpc(arg1: 231, arg2: "MS2PatrolData_231");
                context.MoveNpc(arg1: 232, arg2: "MS2PatrolData_232");
                context.MoveNpc(arg1: 233, arg2: "MS2PatrolData_233");
                context.MoveNpc(arg1: 234, arg2: "MS2PatrolData_234");
                context.MoveNpc(arg1: 235, arg2: "MS2PatrolData_235");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattle03Start01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03Start01 : TriggerState {
            internal StateBattle03Start01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {921, 922}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattle03Start02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03Start02 : TriggerState {
            internal StateBattle03Start02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {923, 924}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBattle03Start03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03Start03 : TriggerState {
            internal StateBattle03Start03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {925, 926}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattle03Start04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03Start04 : TriggerState {
            internal StateBattle03Start04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {927, 928}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {921, 922, 923, 924, 925, 926, 927, 928})) {
                    return new StateBattle03End01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03End01 : TriggerState {
            internal StateBattle03End01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {290}, arg2: false);
                context.DestroyMonster(arg1: new[] {921, 922, 923, 924, 925, 926, 927, 928});
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 40, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTurkaWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurkaWalkIn01 : TriggerState {
            internal StateTurkaWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 230, arg2: "MS2PatrolData_230");
                context.MoveNpc(arg1: 231, arg2: "MS2PatrolData_231");
                context.MoveNpc(arg1: 232, arg2: "MS2PatrolData_232");
                context.MoveNpc(arg1: 233, arg2: "MS2PatrolData_233");
                context.MoveNpc(arg1: 234, arg2: "MS2PatrolData_234");
                context.MoveNpc(arg1: 235, arg2: "MS2PatrolData_235");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 250, arg2: "MS2PatrolData_250");
                context.MoveNpc(arg1: 251, arg2: "MS2PatrolData_251");
                context.MoveNpc(arg1: 252, arg2: "MS2PatrolData_252");
                context.MoveNpc(arg1: 253, arg2: "MS2PatrolData_253");
                context.MoveNpc(arg1: 254, arg2: "MS2PatrolData_254");
                context.MoveNpc(arg1: 255, arg2: "MS2PatrolData_255");
                context.SetUserValue(triggerId: 4, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 5, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 6, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 7, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 8, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 9, key: "BattleEnd", value: 1);
                context.MoveNpc(arg1: 290, arg2: "MS2PatrolData_301");
                context.DestroyMonster(arg1: new[] {204});
                context.CreateMonster(arg1: new[] {205}, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTurkaWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurkaWalkIn02 : TriggerState {
            internal StateTurkaWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_205");
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTurkaTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurkaTalk01 : TriggerState {
            internal StateTurkaTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {5000, 5001}, arg2: true);
                context.AddCinematicTalk(npcId: 11003226, msg: "$52000120_QD__01_HENESYSDEFENSE__16$", duration: 5000, align: "center", illustId: "0");
                context.SetSceneSkip(arg1: "ManovichTalk03_CSkip", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTurkaTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurkaTalk01Skip : TriggerState {
            internal StateTurkaTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateChangeView01(context);
            }

            public override void OnExit() { }
        }

        private class StateChangeView01 : TriggerState {
            internal StateChangeView01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateChangeView02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChangeView02 : TriggerState {
            internal StateChangeView02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 42, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateChangeView03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChangeView03 : TriggerState {
            internal StateChangeView03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTurkaTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurkaTalk02 : TriggerState {
            internal StateTurkaTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003226, msg: "$52000120_QD__01_HENESYSDEFENSE__17$", duration: 4000, align: "center", illustId: "Turka_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTurkaTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurkaTalk02Skip : TriggerState {
            internal StateTurkaTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 290, arg2: "MS2PatrolData_302");
                context.DestroyMonster(arg1: new[] {980, 981, 982, 983, 984, 985, 990, 991, 992, 993, 994, 995});
                context.CreateMonster(arg1: new[] {960, 961, 962, 963, 964, 965, 970, 971, 972, 973, 974, 975}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyRetreat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat01 : TriggerState {
            internal StateEnemyRetreat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 43, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnemyRetreat02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat02 : TriggerState {
            internal StateEnemyRetreat02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 144, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 145, arg2: "MS2PatrolData_2105");
                context.MoveNpc(arg1: 146, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 147, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 170, arg2: "MS2PatrolData_2104");
                context.MoveNpc(arg1: 172, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 178, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 179, arg2: "MS2PatrolData_2104");
                context.MoveNpc(arg1: 180, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_2103");
                context.MoveNpc(arg1: 160, arg2: "MS2PatrolData_2206");
                context.MoveNpc(arg1: 161, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 162, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 163, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 164, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 165, arg2: "MS2PatrolData_2205");
                context.MoveNpc(arg1: 166, arg2: "MS2PatrolData_2204");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnemyRetreat03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat03 : TriggerState {
            internal StateEnemyRetreat03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 171, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 174, arg2: "MS2PatrolData_2103");
                context.MoveNpc(arg1: 175, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 176, arg2: "MS2PatrolData_2105");
                context.MoveNpc(arg1: 177, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 150, arg2: "MS2PatrolData_2104");
                context.MoveNpc(arg1: 151, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 152, arg2: "MS2PatrolData_2103");
                context.MoveNpc(arg1: 153, arg2: "MS2PatrolData_2104");
                context.MoveNpc(arg1: 154, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 155, arg2: "MS2PatrolData_2105");
                context.MoveNpc(arg1: 156, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 140, arg2: "MS2PatrolData_2206");
                context.MoveNpc(arg1: 141, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 142, arg2: "MS2PatrolData_2205");
                context.MoveNpc(arg1: 143, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 167, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 168, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 169, arg2: "MS2PatrolData_2206");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnemyRetreat04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat04 : TriggerState {
            internal StateEnemyRetreat04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 191, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 192, arg2: "MS2PatrolData_2103");
                context.MoveNpc(arg1: 193, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 194, arg2: "MS2PatrolData_2105");
                context.MoveNpc(arg1: 195, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 114, arg2: "MS2PatrolData_2204");
                context.MoveNpc(arg1: 115, arg2: "MS2PatrolData_2205");
                context.MoveNpc(arg1: 116, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 117, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 118, arg2: "MS2PatrolData_2206");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2203");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnemyRetreat05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat05 : TriggerState {
            internal StateEnemyRetreat05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 187, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 188, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 189, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 123, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 124, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 125, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 126, arg2: "MS2PatrolData_2206");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnemyRetreat06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat06 : TriggerState {
            internal StateEnemyRetreat06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {112, 144, 145, 146, 147, 170, 172, 178, 179, 180, 160, 161, 162, 163, 164, 165, 166});
                context.MoveNpc(arg1: 130, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 131, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 132, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 133, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 134, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 135, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 136, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 184, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 113, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 196, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 197, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 198, arg2: "MS2PatrolData_2206");
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_2205");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyRetreat07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat07 : TriggerState {
            internal StateEnemyRetreat07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {171, 174, 175, 176, 177, 150, 151, 152, 153, 154, 155, 156, 140, 141, 142, 143, 167, 168, 169});
                context.MoveNpc(arg1: 181, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 182, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 183, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 185, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 186, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 960, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 961, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 962, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 963, arg2: "MS2PatrolData_2203");
                context.MoveNpc(arg1: 964, arg2: "MS2PatrolData_2201");
                context.MoveNpc(arg1: 965, arg2: "MS2PatrolData_2202");
                context.MoveNpc(arg1: 970, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 971, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 972, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 973, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 974, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 975, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnemyRetreat08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat08 : TriggerState {
            internal StateEnemyRetreat08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {191, 192, 193, 194, 195, 114, 115, 116, 117, 118, 110});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnemyRetreat09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat09 : TriggerState {
            internal StateEnemyRetreat09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 187, 188, 189, 190, 120, 121, 122, 123, 124, 125, 126});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnemyRetreat10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat10 : TriggerState {
            internal StateEnemyRetreat10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {130, 131, 132, 133, 134, 135, 136, 184, 113, 196, 197, 198, 199});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnemyRetreat11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyRetreat11 : TriggerState {
            internal StateEnemyRetreat11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {181, 182, 183, 184, 185, 186, 990, 991, 992, 993, 994, 995, 980, 981, 982, 983, 984, 985, 290});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding01 : TriggerState {
            internal StateEnding01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 44, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnding02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding02 : TriggerState {
            internal StateEnding02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateManovichTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk03 : TriggerState {
            internal StateManovichTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003221, msg: "$52000120_QD__01_HENESYSDEFENSE__18$", duration: 4000, align: "center", illustId: "Manovich_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateManovichTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk03_CSkip : TriggerState {
            internal StateManovichTalk03_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.CameraSelect(arg1: 44, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateManovichTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk03Skip : TriggerState {
            internal StateManovichTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "henesysinvasion");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveUser(arg1: 02000072, arg2: 1);
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLeave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeave : TriggerState {
            internal StateLeave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000072, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLeave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}