namespace Maple2.Trigger._52100300_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Spawn", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "RandomBomb", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Laser", value: 0);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10002185}, arg2: 0);
                context.EnableSpawnPointPc(spawnPointId: 100, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 101, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 102, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
                context.MoveUser(arg1: 52100300, arg2: 5001);
                context.CreateMonster(arg1: new[] {351});
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4004, 4005}, arg2: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {4006, 4007}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52100300_QD__MAIN__12$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 0, msg: "$52100300_QD__MAIN__13$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004682, illustId: "11004022", align: "right", msg: "$52100300_QD__MAIN__14$", duration: 3500);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 351, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11004682, illustId: "11004022", align: "right", msg: "$52100300_QD__MAIN__15$", duration: 3500);
                context.AddCinematicTalk(npcId: 0, msg: "$52100300_QD__MAIN__16$", duration: 3500);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {351}, arg2: false);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {351});
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
                    context.SetEventUI(arg1: 1, arg2: "$52100300_QD__MAIN__0$", arg3: 5000);
                    context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                    return new State추가Script_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_01 : TriggerState {
            internal State추가Script_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetUserValue(triggerId: 99990004, key: "Laser", value: 1);
                    context.SideNpcTalk(type: "talk", npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100300_QD__MAIN__1$", duration: 5000);
                    return new State추가Script_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_02 : TriggerState {
            internal State추가Script_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103})) {
                    context.SideNpcTalk(type: "talk", npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__2$", duration: 5000);
                    return new State추가Script_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추가Script_03 : TriggerState {
            internal State추가Script_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_normal", script: "$52100300_QD__MAIN__3$", duration: 5000);
                    return new State엘리베이터_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_체크 : TriggerState {
            internal State엘리베이터_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SideNpcTalk(type: "talk", npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__4$", duration: 5000);
                    return new State엘리베이터_스위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_스위치 : TriggerState {
            internal State엘리베이터_스위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002185}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002185}, arg2: 0)) {
                    return new State엘리베이터Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터Enabled : TriggerState {
            internal State엘리베이터Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {903})) {
                    return new State아르케온_탑승_Guide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르케온_탑승_Guide : TriggerState {
            internal State아르케온_탑승_Guide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52100300_QD__MAIN__5$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {711})) {
                    return new State레이저_Pattern_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이저_Pattern_시작 : TriggerState {
            internal State레이저_Pattern_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {904})) {
                    return new State갈림길_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State갈림길_전투 : TriggerState {
            internal State갈림길_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204}, arg2: false);
                context.SetActor(arg1: 9001, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(arg1: new[] {1001}, arg2: true);
                context.EnableSpawnPointPc(spawnPointId: 100, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 101, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 102, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {905})) {
                    return new State짜투리_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State짜투리_전투 : TriggerState {
            internal State짜투리_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303, 304}, arg2: false);
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {911})) {
                    return new State웨이브_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이브_시작 : TriggerState {
            internal State웨이브_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 29000170, illust: "ArcaneBlader_unfair", script: "$52100300_QD__MAIN__6$", duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, arg2: false);
                context.SideNpcTalk(type: "talk", npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100300_QD__MAIN__7$", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpawnRoomEnd") == 1) {
                    context.SetActor(arg1: 9001, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_start");
                    return new State길열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길열림 : TriggerState {
            internal State길열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1001}, arg2: false);
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004, 30000, 30010, 30020, 30030}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {921})) {
                    return new State지뢰방_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지뢰방_시작 : TriggerState {
            internal State지뢰방_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 100, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 101, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 102, isEnable: true);
                context.SetActor(arg1: 9002, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(arg1: 9003, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetActor(arg1: 9004, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_end");
                context.SetMesh(arg1: new[] {5001}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003}, arg2: true);
                context.SetUserValue(triggerId: 99990003, key: "RandomBomb", value: 1);
                context.SideNpcTalk(type: "talk", npcId: 29500101, illust: "ArcheonBlack_Normal", script: "$52100300_QD__MAIN__8$", duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__9$", duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_normal", script: "$52100300_QD__MAIN__10$", duration: 5000);
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 29000170, illust: "ArcaneBlader_normal", script: "$52100300_QD__MAIN__11$", duration: 5000);
                context.SetActor(arg1: 9002, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_start");
                context.SetMesh(arg1: new[] {3001}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
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