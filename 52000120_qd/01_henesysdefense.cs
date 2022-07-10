using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000120_qd {
    public static class _01_henesysdefense {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.DestroyMonster(spawnIds: new []{101, 102, 201, 202, 203, 204, 290, 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225, 240, 241, 242, 243, 244, 245, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 601, 602, 603, 604});
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 921, 922, 923, 924, 925, 926, 927, 928});
                context.DestroyMonster(spawnIds: new []{605, 606, 607, 608, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 701, 702, 703, 704, 710, 711, 712, 713});
                context.CreateMonster(spawnIds: new []{110, 111, 112, 120, 121, 122, 123, 124, 125, 126, 130, 131, 132, 133, 134, 135, 136, 140, 141, 142, 143, 144, 145, 146, 147, 150, 151, 152, 153, 154, 155, 156, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 185, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 113, 114, 115, 116, 117, 118}, arg2: false);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "Interaction_bridge_A01_on");
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetCube(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, visible: false);
                context.SetLocalCamera(cameraId: 10000, enable: false);
                context.SetLocalCamera(cameraId: 10001, enable: false);
                context.SetAgent(triggerIds: new []{8001, 8002, 8003}, visible: false);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001551}, questStates: new byte[]{1})) {
                    return new StateLoadingDelay01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001551}, questStates: new byte[]{2})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(spawnIds: new []{605, 606, 607, 608, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 101, 201, 501, 502, 507, 508, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 710, 711, 712, 713}, arg2: false);
                context.CameraSelect(triggerId: 10, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003221, script: "$52000120_QD__01_HENESYSDEFENSE__0$", duration: 5000, align: Align.Center, illustId: "Manovich_normal");
                context.SetSceneSkip(state: new StateSetLocalTargetCamera01cskip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateLeadersTalk_Osckal01(context);
            }

            public override void OnExit() { }
        }

        private class StateLeadersTalk_Osckal01 : TriggerState {
            internal StateLeadersTalk_Osckal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__1$", duration: 4000, align: Align.Center, illustId: "Oskhal_normal");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 11, enable: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000120_QD__01_HENESYSDEFENSE__2$", duration: 2000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 12, enable: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 0, script: "$52000120_QD__01_HENESYSDEFENSE__3$", duration: 4000, align: Align.Center, illustId: "0");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateManovichTalk01(context);
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk01 : TriggerState {
            internal StateManovichTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003221, script: "$52000120_QD__01_HENESYSDEFENSE__4$", duration: 5000, align: Align.Center, illustId: "Manovich_normal");
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000120_QD__01_HENESYSDEFENSE__5$", duration: 4000, align: Align.Center, illustId: "0");
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionSequence(sequenceNames: new []{"Idle_A"});
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateManovichTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateManovichTalk02 : TriggerState {
            internal StateManovichTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003221, script: "$52000120_QD__01_HENESYSDEFENSE__6$", duration: 4000, align: Align.Center, illustId: "Manovich_normal");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateOskhalTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk02 : TriggerState {
            internal StateOskhalTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__7$", duration: 5000, align: Align.Center, illustId: "Oskhal_normal");
            }

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 13, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 14, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__8$", duration: 4000, align: Align.Center, illustId: "Oskhal_serious");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateOskhalTalk04(context);
            }

            public override void OnExit() { }
        }

        private class StateOskhalTalk04 : TriggerState {
            internal StateOskhalTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__9$", duration: 5000, align: Align.Center, illustId: "Oskhal_normal");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateCameraChange11(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraChange11 : TriggerState {
            internal StateCameraChange11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000120, portalId: 10, boxId: 9900);
                context.CameraSelect(triggerId: 15, enable: true);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{102, 202, 210, 211, 212, 213, 214, 215}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105}, visible: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, arg2: true);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "Interaction_bridge_A01_off");
                context.CameraSelect(triggerId: 16, enable: true);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_102");
                context.MoveNpc(spawnId: 210, patrolName: "MS2PatrolData_210");
                context.MoveNpc(spawnId: 211, patrolName: "MS2PatrolData_211");
                context.MoveNpc(spawnId: 212, patrolName: "MS2PatrolData_212");
                context.MoveNpc(spawnId: 213, patrolName: "MS2PatrolData_213");
                context.MoveNpc(spawnId: 214, patrolName: "MS2PatrolData_214");
                context.MoveNpc(spawnId: 215, patrolName: "MS2PatrolData_215");
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105}, visible: true, arg3: 500, arg4: 0, arg5: 2f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000120, portalId: 10, boxId: 9900);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105}, visible: true, arg3: 500, arg4: 0, arg5: 2f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetAgent(triggerIds: new []{8001, 8002, 8003}, visible: true);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
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
                context.SetCube(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{901, 902}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{202, 210, 211, 212, 213, 214, 215});
                context.CreateMonster(spawnIds: new []{203, 220, 221, 222, 223, 224, 225}, arg2: false);
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__10$", duration: 5000, align: Align.Center, illustId: "Oskhal_normal");
                context.SetSceneSkip(state: new StateBattleOnTheWallGuide01Skip(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateBattleOnTheWallGuide02(context);
            }

            public override void OnExit() { }
        }

        private class StateBattleOnTheWallGuide02 : TriggerState {
            internal StateBattleOnTheWallGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
                context.CreateMonster(spawnIds: new []{903, 904}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003221, script: "$52000120_QD__01_HENESYSDEFENSE__11$", duration: 4000, align: Align.Center, illustId: "Manovich_normal");
                context.SetSceneSkip(state: new StateBattleOnTheWallGuide02Skip(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101201, textId: 25101201);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{905, 906}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{907, 908}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{909, 910}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__12$", duration: 5000, align: Align.Center, illustId: "Oskhal_normal");
                context.SetSceneSkip(state: new StatePCVolunteer05CSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetLocalCamera(cameraId: 10000, enable: false);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000120, portalId: 20, boxId: 9900);
                context.CameraSelect(triggerId: 20, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000120_QD__01_HENESYSDEFENSE__13$", duration: 4000, align: Align.Center, illustId: "0");
            }

            public override TriggerState? Execute() {
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
                context.SetPcEmotionSequence(sequenceNames: new []{"Idle_A"});
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                return new StateBattle01Start01(context);
            }

            public override void OnExit() { }
        }

        private class StatePCVolunteer05CSkip : TriggerState {
            internal StatePCVolunteer05CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000120, portalId: 20, boxId: 9900);
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 2);
                context.SetPcEmotionSequence(sequenceNames: new []{"Idle_A"});
                context.RemoveCinematicTalk();
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                return new StateBattle01Start01(context);
            }

            public override void OnExit() { }
        }

        private class StateBattle01Start01 : TriggerState {
            internal StateBattle01Start01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "Interaction_bridge_A01_on");
            }

            public override TriggerState? Execute() {
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
                context.SetCube(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, visible: false);
                context.DestroyMonster(spawnIds: new []{701, 702, 703, 704, 710, 711, 712, 713});
                context.CreateMonster(spawnIds: new []{300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 500, 503, 504, 505, 506, 509, 510, 601, 602, 603, 604, 701, 702, 703, 704}, arg2: false);
                context.MoveUser(mapId: 52000120, portalId: 30, boxId: 9900);
                context.CreateMonster(spawnIds: new []{240, 241, 242, 243, 244, 245}, arg2: false);
                context.CameraSelect(triggerId: 30, enable: true);
                context.SetAgent(triggerIds: new []{8001, 8002, 8003}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105}, visible: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, arg2: true);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "Interaction_bridge_A01_off");
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
                context.MoveNpc(spawnId: 240, patrolName: "MS2PatrolData_240");
                context.MoveNpc(spawnId: 241, patrolName: "MS2PatrolData_241");
                context.MoveNpc(spawnId: 242, patrolName: "MS2PatrolData_242");
                context.MoveNpc(spawnId: 243, patrolName: "MS2PatrolData_243");
                context.MoveNpc(spawnId: 244, patrolName: "MS2PatrolData_244");
                context.MoveNpc(spawnId: 245, patrolName: "MS2PatrolData_245");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 31, enable: true);
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 2);
            }

            public override TriggerState? Execute() {
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
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005}, arg2: false);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105}, visible: true, arg3: 500, arg4: 0, arg5: 2f);
                context.SetActor(triggerId: 4500, visible: true, initialSequence: "Interaction_bridge_A01_on");
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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
                context.SetAgent(triggerIds: new []{8001, 8002, 8003}, visible: true);
                context.ChangeMonster(removeSpawnId: 203, addSpawnId: 204);
                context.ChangeMonster(removeSpawnId: 240, addSpawnId: 250);
                context.ChangeMonster(removeSpawnId: 241, addSpawnId: 251);
                context.ChangeMonster(removeSpawnId: 242, addSpawnId: 252);
                context.ChangeMonster(removeSpawnId: 243, addSpawnId: 253);
                context.ChangeMonster(removeSpawnId: 244, addSpawnId: 254);
                context.ChangeMonster(removeSpawnId: 245, addSpawnId: 255);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101202, textId: 25101202);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__14$", duration: 5000, align: Align.Center, illustId: "Oskhal_normal");
                context.SetSceneSkip(state: new StateBattle01End01Skip(context));
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910});
                context.MoveNpc(spawnId: 230, patrolName: "MS2PatrolData_230");
                context.MoveNpc(spawnId: 231, patrolName: "MS2PatrolData_231");
                context.MoveNpc(spawnId: 232, patrolName: "MS2PatrolData_232");
                context.MoveNpc(spawnId: 233, patrolName: "MS2PatrolData_233");
                context.MoveNpc(spawnId: 234, patrolName: "MS2PatrolData_234");
                context.MoveNpc(spawnId: 235, patrolName: "MS2PatrolData_235");
                context.MoveNpc(spawnId: 250, patrolName: "MS2PatrolData_250");
                context.MoveNpc(spawnId: 251, patrolName: "MS2PatrolData_251");
                context.MoveNpc(spawnId: 252, patrolName: "MS2PatrolData_252");
                context.MoveNpc(spawnId: 253, patrolName: "MS2PatrolData_253");
                context.MoveNpc(spawnId: 254, patrolName: "MS2PatrolData_254");
                context.MoveNpc(spawnId: 255, patrolName: "MS2PatrolData_255");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101203, textId: 25101203, duration: 5000);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{911, 912}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25101204, textId: 25101204, duration: 5000);
                context.CreateMonster(spawnIds: new []{913, 914}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{911, 912, 913, 914})) {
                    return new StateBattle02End01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle02End01 : TriggerState {
            internal StateBattle02End01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003319, script: "$52000120_QD__01_HENESYSDEFENSE__15$", duration: 5000, align: Align.Center, illustId: "Oskhal_normal");
                context.SetSceneSkip(state: new StateBattle02End01Skip(context));
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{911, 912, 913, 914});
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 250, patrolName: "MS2PatrolData_250");
                context.MoveNpc(spawnId: 251, patrolName: "MS2PatrolData_251");
                context.MoveNpc(spawnId: 252, patrolName: "MS2PatrolData_252");
                context.MoveNpc(spawnId: 253, patrolName: "MS2PatrolData_253");
                context.MoveNpc(spawnId: 254, patrolName: "MS2PatrolData_254");
                context.MoveNpc(spawnId: 255, patrolName: "MS2PatrolData_255");
                context.MoveNpc(spawnId: 230, patrolName: "MS2PatrolData_230");
                context.MoveNpc(spawnId: 231, patrolName: "MS2PatrolData_231");
                context.MoveNpc(spawnId: 232, patrolName: "MS2PatrolData_232");
                context.MoveNpc(spawnId: 233, patrolName: "MS2PatrolData_233");
                context.MoveNpc(spawnId: 234, patrolName: "MS2PatrolData_234");
                context.MoveNpc(spawnId: 235, patrolName: "MS2PatrolData_235");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{921, 922}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{923, 924}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{925, 926}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{927, 928}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926, 927, 928})) {
                    return new StateBattle03End01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle03End01 : TriggerState {
            internal StateBattle03End01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{290}, arg2: false);
                context.DestroyMonster(spawnIds: new []{921, 922, 923, 924, 925, 926, 927, 928});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 40, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 230, patrolName: "MS2PatrolData_230");
                context.MoveNpc(spawnId: 231, patrolName: "MS2PatrolData_231");
                context.MoveNpc(spawnId: 232, patrolName: "MS2PatrolData_232");
                context.MoveNpc(spawnId: 233, patrolName: "MS2PatrolData_233");
                context.MoveNpc(spawnId: 234, patrolName: "MS2PatrolData_234");
                context.MoveNpc(spawnId: 235, patrolName: "MS2PatrolData_235");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 250, patrolName: "MS2PatrolData_250");
                context.MoveNpc(spawnId: 251, patrolName: "MS2PatrolData_251");
                context.MoveNpc(spawnId: 252, patrolName: "MS2PatrolData_252");
                context.MoveNpc(spawnId: 253, patrolName: "MS2PatrolData_253");
                context.MoveNpc(spawnId: 254, patrolName: "MS2PatrolData_254");
                context.MoveNpc(spawnId: 255, patrolName: "MS2PatrolData_255");
                context.SetUserValue(triggerId: 4, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 5, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 6, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 7, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 8, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 9, key: "BattleEnd", value: 1);
                context.MoveNpc(spawnId: 290, patrolName: "MS2PatrolData_301");
                context.DestroyMonster(spawnIds: new []{204});
                context.CreateMonster(spawnIds: new []{205}, arg2: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1004");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_205");
                context.MoveUserPath(patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: true);
                context.AddCinematicTalk(npcId: 11003226, script: "$52000120_QD__01_HENESYSDEFENSE__16$", duration: 5000, align: Align.Center, illustId: "0");
                context.SetSceneSkip(state: new StateManovichTalk03_CSkip(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateChangeView01(context);
            }

            public override void OnExit() { }
        }

        private class StateChangeView01 : TriggerState {
            internal StateChangeView01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 42, enable: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003226, script: "$52000120_QD__01_HENESYSDEFENSE__17$", duration: 4000, align: Align.Center, illustId: "Turka_normal");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 290, patrolName: "MS2PatrolData_302");
                context.DestroyMonster(spawnIds: new []{980, 981, 982, 983, 984, 985, 990, 991, 992, 993, 994, 995});
                context.CreateMonster(spawnIds: new []{960, 961, 962, 963, 964, 965, 970, 971, 972, 973, 974, 975}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 43, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 144, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 145, patrolName: "MS2PatrolData_2105");
                context.MoveNpc(spawnId: 146, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 147, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 170, patrolName: "MS2PatrolData_2104");
                context.MoveNpc(spawnId: 172, patrolName: "MS2PatrolData_2102");
                context.MoveNpc(spawnId: 178, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 179, patrolName: "MS2PatrolData_2104");
                context.MoveNpc(spawnId: 180, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_2103");
                context.MoveNpc(spawnId: 160, patrolName: "MS2PatrolData_2206");
                context.MoveNpc(spawnId: 161, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 162, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 163, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 164, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 165, patrolName: "MS2PatrolData_2205");
                context.MoveNpc(spawnId: 166, patrolName: "MS2PatrolData_2204");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 171, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 174, patrolName: "MS2PatrolData_2103");
                context.MoveNpc(spawnId: 175, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 176, patrolName: "MS2PatrolData_2105");
                context.MoveNpc(spawnId: 177, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 150, patrolName: "MS2PatrolData_2104");
                context.MoveNpc(spawnId: 151, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 152, patrolName: "MS2PatrolData_2103");
                context.MoveNpc(spawnId: 153, patrolName: "MS2PatrolData_2104");
                context.MoveNpc(spawnId: 154, patrolName: "MS2PatrolData_2102");
                context.MoveNpc(spawnId: 155, patrolName: "MS2PatrolData_2105");
                context.MoveNpc(spawnId: 156, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 140, patrolName: "MS2PatrolData_2206");
                context.MoveNpc(spawnId: 141, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 142, patrolName: "MS2PatrolData_2205");
                context.MoveNpc(spawnId: 143, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 167, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 168, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 169, patrolName: "MS2PatrolData_2206");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 191, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 192, patrolName: "MS2PatrolData_2103");
                context.MoveNpc(spawnId: 193, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 194, patrolName: "MS2PatrolData_2105");
                context.MoveNpc(spawnId: 195, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 114, patrolName: "MS2PatrolData_2204");
                context.MoveNpc(spawnId: 115, patrolName: "MS2PatrolData_2205");
                context.MoveNpc(spawnId: 116, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 117, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 118, patrolName: "MS2PatrolData_2206");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2203");
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 187, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 188, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 189, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 190, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 123, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 124, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 125, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 126, patrolName: "MS2PatrolData_2206");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{112, 144, 145, 146, 147, 170, 172, 178, 179, 180, 160, 161, 162, 163, 164, 165, 166});
                context.MoveNpc(spawnId: 130, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 131, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 132, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 133, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 134, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 135, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 136, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 184, patrolName: "MS2PatrolData_2102");
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 196, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 197, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 198, patrolName: "MS2PatrolData_2206");
                context.MoveNpc(spawnId: 199, patrolName: "MS2PatrolData_2205");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{171, 174, 175, 176, 177, 150, 151, 152, 153, 154, 155, 156, 140, 141, 142, 143, 167, 168, 169});
                context.MoveNpc(spawnId: 181, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 182, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 183, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 185, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 186, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 960, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 961, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 962, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 963, patrolName: "MS2PatrolData_2203");
                context.MoveNpc(spawnId: 964, patrolName: "MS2PatrolData_2201");
                context.MoveNpc(spawnId: 965, patrolName: "MS2PatrolData_2202");
                context.MoveNpc(spawnId: 970, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 971, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 972, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 973, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 974, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 975, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{191, 192, 193, 194, 195, 114, 115, 116, 117, 118, 110});
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{111, 187, 188, 189, 190, 120, 121, 122, 123, 124, 125, 126});
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{130, 131, 132, 133, 134, 135, 136, 184, 113, 196, 197, 198, 199});
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{181, 182, 183, 184, 185, 186, 990, 991, 992, 993, 994, 995, 980, 981, 982, 983, 984, 985, 290});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 44, enable: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003221, script: "$52000120_QD__01_HENESYSDEFENSE__18$", duration: 4000, align: Align.Center, illustId: "Manovich_normal");
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{-1});
                context.CameraSelect(triggerId: 44, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "henesysinvasion");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02000072, portalId: 1);
                context.SetUserValue(triggerId: 10, key: "DefencePhase", value: 3);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 02000072, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLeave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
