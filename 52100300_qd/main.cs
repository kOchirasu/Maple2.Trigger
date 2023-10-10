using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100300_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Spawn", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "RandomBomb", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Laser", value: 0);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10002185}, state: 0);
                context.EnableSpawnPointPc(spawnId: 100, enabled: true);
                context.EnableSpawnPointPc(spawnId: 101, enabled: false);
                context.EnableSpawnPointPc(spawnId: 102, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52100300, portalId: 5001);
                context.CreateMonster(spawnIds: new []{351});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_2 : TriggerState {
            internal StateStartCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4004, 4005}, returnView: false);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2900)) {
                    return new StateStartCinematic_2_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_2_02 : TriggerState {
            internal StateStartCinematic_2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006, 4007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStartCinematic_2_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_2_03 : TriggerState {
            internal StateStartCinematic_2_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_3 : TriggerState {
            internal StateStartCinematic_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52100300_QD__MAIN__12$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStartCinematic_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_4 : TriggerState {
            internal StateStartCinematic_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52100300_QD__MAIN__13$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004682, illustId: "11004022", align: Align.Right, script: "$52100300_QD__MAIN__14$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStartCinematic_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_5 : TriggerState {
            internal StateStartCinematic_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 351, patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11004682, illustId: "11004022", align: Align.Right, script: "$52100300_QD__MAIN__15$", duration: 3500);
                context.AddCinematicTalk(npcId: 0, script: "$52100300_QD__MAIN__16$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStartCinematic_6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_6 : TriggerState {
            internal StateStartCinematic_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{351}, arg2: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{351});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_7 : TriggerState {
            internal StateStartCinematic_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    context.SetEventUI(arg1: 1, script: "$52100300_QD__MAIN__0$", duration: 5000);
                    context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                    return new State추가Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_01 : TriggerState {
            internal State추가Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetUserValue(triggerId: 99990004, key: "Laser", value: 1);
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100300_QD__MAIN__1$", duration: 5000);
                    return new State추가Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_02 : TriggerState {
            internal State추가Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__2$", duration: 5000);
                    return new State추가Script_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_03 : TriggerState {
            internal State추가Script_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_normal", script: "$52100300_QD__MAIN__3$", duration: 5000);
                    return new State엘리베이터_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_체크 : TriggerState {
            internal State엘리베이터_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__4$", duration: 5000);
                    return new State엘리베이터_스위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_스위치 : TriggerState {
            internal State엘리베이터_스위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002185}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002185}, arg2: 0)) {
                    return new State엘리베이터Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터Enabled : TriggerState {
            internal State엘리베이터Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{5001}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new State아르케온_탑승_Guide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탑승_Guide : TriggerState {
            internal State아르케온_탑승_Guide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52100300_QD__MAIN__5$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{711})) {
                    return new State레이저_Pattern_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_Pattern_시작 : TriggerState {
            internal State레이저_Pattern_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{904})) {
                    return new State갈림길_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State갈림길_전투 : TriggerState {
            internal State갈림길_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
                context.SetActor(triggerId: 9001, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(triggerIds: new []{1001}, visible: true);
                context.EnableSpawnPointPc(spawnId: 100, enabled: false);
                context.EnableSpawnPointPc(spawnId: 101, enabled: true);
                context.EnableSpawnPointPc(spawnId: 102, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{905})) {
                    return new State짜투리_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State짜투리_전투 : TriggerState {
            internal State짜투리_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304}, arg2: false);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{911})) {
                    return new State웨이브_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브_시작 : TriggerState {
            internal State웨이브_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_unfair", script: "$52100300_QD__MAIN__6$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_04 : TriggerState {
            internal State추가Script_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Spawn", value: 1);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, visible: false);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100300_QD__MAIN__7$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpawnRoomEnd") == 1) {
                    context.SetActor(triggerId: 9001, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_start");
                    return new State길열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길열림 : TriggerState {
            internal State길열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001}, visible: false);
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{921})) {
                    return new State지뢰방_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지뢰방_시작 : TriggerState {
            internal State지뢰방_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 100, enabled: false);
                context.EnableSpawnPointPc(spawnId: 101, enabled: false);
                context.EnableSpawnPointPc(spawnId: 102, enabled: true);
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(triggerId: 9003, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(triggerId: 9004, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(triggerIds: new []{5001}, visible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003}, visible: true);
                context.SetUserValue(triggerId: 99990003, key: "RandomBomb", value: 1);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100300_QD__MAIN__8$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_05 : TriggerState {
            internal State추가Script_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__9$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State추가Script_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_06 : TriggerState {
            internal State추가Script_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003536, illust: "Neirin_normal", script: "$52100300_QD__MAIN__10$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RandomBombEnd") == 1) {
                    context.SetUserValue(triggerId: 99990004, key: "Laser", value: 0);
                    return new StateBoss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss : TriggerState {
            internal StateBoss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__11$", duration: 5000);
                context.SetActor(triggerId: 9002, visible: true, initialSequence: "sf_fi_funct_darkdoor_A01_start");
                context.SetMesh(triggerIds: new []{3001}, visible: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
