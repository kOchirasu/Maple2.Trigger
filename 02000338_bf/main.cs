namespace Maple2.Trigger._02000338_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 120, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 121, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 122, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 123, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 124, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 110, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 111, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 112, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {30001, 30002, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013, 30014, 30015, 30016, 30017, 30018, 30019, 30020, 30021, 30022, 30023, 30024, 30025, 30026, 30027, 30028, 30029, 30030, 30031, 30032, 30033, 30034, 20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012, 20013, 20014, 20015, 20016, 20017, 20018, 20019, 20020, 20021, 20022, 20023, 20024, 20025, 20026, 20027, 20028, 20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036, 20037, 20038, 20039, 20040, 20041, 20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050, 20051, 20052, 20053, 20054, 20055, 20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064, 20065, 20066, 20067, 20068, 20069, 20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077, 20078, 20079, 20080, 20081, 20082, 20083, 20084, 20085, 20086, 20087, 20088, 20089, 20090, 20091, 20092, 20093, 20094, 20095, 20096, 20097, 20098, 20099, 20100, 20101, 20102, 20103, 20104, 20105, 20106, 20107, 20108, 20109, 20110, 20111, 20112, 20113, 20114, 20115, 20116, 20117, 20118, 20119, 20120, 20121, 20122, 20123, 20124, 20125, 20126, 20127, 20128, 20129, 20130, 20131, 20132, 20133, 20134, 20135, 20136, 20137, 20138, 20139, 20140, 20141, 20142, 20143, 20144, 20145, 20146, 20147, 20148, 20149, 20150, 20151, 20152, 20153, 20154, 20155, 20156, 20157, 20158, 20159, 20160, 20161, 20162, 20163, 20164, 20165, 20166, 20167, 20168, 20169, 20170, 20171, 20172, 20173, 20174, 20175, 20176, 20177, 20178, 20179, 20180, 20181, 20182, 20183, 20184, 20185, 20186, 20187, 20188, 20189, 20190, 20191, 20192, 20193, 20194, 20195, 20196, 20197, 20198, 20199, 20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210, 20211, 20212, 20213, 20214, 20215, 20216, 20217, 20218, 20219, 20220, 20221, 20222, 20223, 20224, 20225, 20226, 20227, 20228, 20229, 20230, 20231, 20232, 20233, 20234, 20235, 20236, 20237, 20238, 20239, 20240, 20241, 20242, 20243, 20244, 20245, 20246, 20247}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {32000, 32001}, arg2: false);
                context.SetEffect(arg1: new[] {32002}, arg2: true);
                context.SetEffect(arg1: new[] {90000, 73001, 73002, 74500, 75000, 75001, 75002, 75003, 75004, 75005, 76000, 76001, 76002, 73004, 73005, 73006, 73007, 74512}, arg2: false);
                context.DestroyMonster(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010});
                context.SetInteractObject(arg1: new[] {10000777, 10000778, 10000779, 10000780, 10000781, 10000782}, arg2: 0);
                context.CreateMonster(arg1: new[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109}, arg2: false);
                context.SetMesh(arg1: new[] {33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120, 5121, 5122, 5123, 5124, 5125});
                context.SetMesh(arg1: new[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015}, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(arg1: new[] {5100}, arg2: false);
                context.SetMesh(arg1: new[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {70010}, arg2: true, arg3: 250, arg4: 50, arg5: 2f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(arg1: new[] {74512}, arg2: true);
                context.CameraSelect(arg1: 30200, arg2: true);
                context.SetSkip(state: new StateCameraWalk05(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraWalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 30201, arg2: true);
                context.SetSkip(state: new StateCameraWalk05(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCameraWalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk04 : TriggerState {
            internal StateCameraWalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetEffect(arg1: new[] {74500}, arg2: true);
                context.SetSkip(state: new StateCameraWalk05(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraWalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk05 : TriggerState {
            internal StateCameraWalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {5000}, arg2: false);
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData5000");
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateGroundFall01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGroundFall01 : TriggerState {
            internal StateGroundFall01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {32000, 32001}, arg2: true);
                context.SetMesh(arg1: new[] {20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012, 20013, 20014, 20015, 20016, 20017, 20018, 20019, 20020}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {20233, 20234, 20235, 20236, 20237, 20238, 20239, 20240, 20241, 20242, 20243, 20244, 20245, 20246, 20247}, arg2: false, arg3: 100, arg4: 0, arg5: 50f);
                context.SetMesh(arg1: new[] {20226, 20227, 20228, 20229, 20230, 20231}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {30001, 30002, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013, 30014, 30015, 30016, 30017, 30018, 30019, 30020, 30021, 30022, 30023, 30024, 30025, 30026, 30027, 30028, 30029, 30030, 30031, 30032, 30033, 30034}, arg2: false, arg3: 200, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {20021, 20022, 20023, 20024, 20025, 20026, 20027, 20028}, arg2: false, arg3: 250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036}, arg2: false, arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20037, 20038, 20039, 20040, 20041, 20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050}, arg2: false, arg3: 750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20051, 20052, 20053, 20054, 20055, 20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064}, arg2: false, arg3: 1000, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20065, 20066, 20067, 20068, 20069, 20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077, 20078, 20079, 20080}, arg2: false, arg3: 1250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20081, 20082, 20083, 20084, 20085, 20086, 20087, 20088, 20089, 20090, 20091, 20092, 20093}, arg2: false, arg3: 1500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20094, 20095, 20096, 20097, 20098, 20099, 20100, 20101, 20102, 20103, 20104, 20105, 20106}, arg2: false, arg3: 1500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20107, 20108, 20109, 20110, 20111, 20112, 20113, 20114, 20115}, arg2: false, arg3: 1750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20116, 20117, 20118, 20119, 20120, 20121, 20122, 20123}, arg2: false, arg3: 2000, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20124, 20125, 20126, 20127, 20128, 20129}, arg2: false, arg3: 2250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20130, 20131, 20132, 20133, 20134, 20135}, arg2: false, arg3: 2500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20136, 20137, 20138, 20139, 20140, 20141, 20142, 20143}, arg2: false, arg3: 2750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20144, 20145, 20146, 20147, 20148, 20149, 20150, 20151, 20152}, arg2: false, arg3: 3000, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20153, 20154, 20155, 20156, 20157}, arg2: false, arg3: 3250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20158, 20159, 20160, 20161, 20162, 20163, 20164, 20165, 20166, 20167, 20168, 20169}, arg2: false, arg3: 3500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20232}, arg2: false, arg3: 3500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20170, 20171, 20172, 20173, 20174, 20175, 20176, 20177, 20178, 20179, 20180, 20181, 20182, 20183, 20184}, arg2: false, arg3: 3750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20185, 20186, 20187, 20188, 20189, 20190, 20191, 20192, 20193, 20194, 20195, 20196, 20197, 20198}, arg2: false, arg3: 4000, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20199, 20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210}, arg2: false, arg3: 4250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20211, 20212, 20213, 20214, 20215, 20216}, arg2: false, arg3: 4500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20217, 20218, 20219}, arg2: false, arg3: 4750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {20220, 20221, 20222, 20223, 20224, 20225}, arg2: false, arg3: 5000, arg4: 50, arg5: 2f);
                context.SetSkip(state: new State3차어나운스(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3차어나운스(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차어나운스 : TriggerState {
            internal State3차어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady01 : TriggerState {
            internal StateReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(arg1: new[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {75000, 75001, 75002, 75003, 75004, 75005}, arg2: true);
                context.SetMesh(arg1: new[] {20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012, 20013, 20014, 20015, 20016, 20017, 20018, 20019, 20020, 20233, 20234, 20235, 20236, 20237, 20238, 20239, 20240, 20241, 20242, 20243, 20244, 20245, 20246, 20247, 20226, 20227, 20228, 20229, 20230, 20231, 30001, 30002, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013, 30014, 30015, 30016, 30017, 30018, 30019, 30020, 30021, 30022, 30023, 30024, 30025, 30026, 30027, 30028, 30029, 30030, 30031, 30032, 30033, 30034, 20021, 20022, 20023, 20024, 20025, 20026, 20027, 20028, 20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036, 20037, 20038, 20039, 20040, 20041, 20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050, 20051, 20052, 20053, 20054, 20055, 20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064, 20065, 20066, 20067, 20068, 20069, 20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077, 20078, 20079, 20080, 20081, 20082, 20083, 20084, 20085, 20086, 20087, 20088, 20089, 20090, 20091, 20092, 20093, 20094, 20095, 20096, 20097, 20098, 20099, 20100, 20101, 20102, 20103, 20104, 20105, 20106, 20107, 20108, 20109, 20110, 20111, 20112, 20113, 20114, 20115, 20116, 20117, 20118, 20119, 20120, 20121, 20122, 20123, 20124, 20125, 20126, 20127, 20128, 20129, 20130, 20131, 20132, 20133, 20134, 20135, 20136, 20137, 20138, 20139, 20140, 20141, 20142, 20143, 20144, 20145, 20146, 20147, 20148, 20149, 20150, 20151, 20152, 20153, 20154, 20155, 20156, 20157, 20158, 20159, 20160, 20161, 20162, 20163, 20164, 20165, 20166, 20167, 20168, 20169, 20232, 20170, 20171, 20172, 20173, 20174, 20175, 20176, 20177, 20178, 20179, 20180, 20181, 20182, 20183, 20184, 20185, 20186, 20187, 20188, 20189, 20190, 20191, 20192, 20193, 20194, 20195, 20196, 20197, 20198, 20199, 20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210, 20211, 20212, 20213, 20214, 20215, 20216, 20217, 20218, 20219, 20220, 20221, 20222, 20223, 20224, 20225}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State1stBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stBattle01 : TriggerState {
            internal State1stBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003382, textId: 20003382);
                context.CreateMonster(arg1: new[] {5001, 5002, 5003}, arg2: false);
                context.SetEffect(arg1: new[] {73001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000777}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000777}, arg2: 0)) {
                    return new State1stBridgeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stBridgeOn01 : TriggerState {
            internal State1stBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {75000, 75001, 75002, 75003, 75004, 75005}, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002}, arg2: false);
                context.HideGuideSummary(entityId: 20003382);
                context.SetEffect(arg1: new[] {73001}, arg2: false);
                context.SetMesh(arg1: new[] {20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.CreateMonster(arg1: new[] {5004, 5005, 5006, 5007, 5008, 5009, 5010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2ndBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndBattle01 : TriggerState {
            internal State2ndBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003382, textId: 20003382);
                context.SetInteractObject(arg1: new[] {10000778}, arg2: 1);
                context.SetEffect(arg1: new[] {73002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000778}, arg2: 0)) {
                    return new State2ndBridgeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndBridgeOn01 : TriggerState {
            internal State2ndBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8003, 8004, 8005}, arg2: false);
                context.HideGuideSummary(entityId: 20003382);
                context.ShowGuideSummary(entityId: 20003386, textId: 20003386, duration: 5000);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.SetEffect(arg1: new[] {73002}, arg2: false);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {5000})) {
                    return new State3rdBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdBattle01 : TriggerState {
            internal State3rdBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {76000, 76001, 76002}, arg2: true);
                context.SetLadder(arg1: 120, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 121, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 122, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 123, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 124, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 110, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 111, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 112, arg2: true, arg3: true, arg4: 6);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {999998})) {
                    return new State3rdBrigeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdBrigeOn01 : TriggerState {
            internal State3rdBrigeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {76000, 76001, 76002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thBattle01 : TriggerState {
            internal State4thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003382, textId: 20003382);
                context.SetInteractObject(arg1: new[] {10000779}, arg2: 1);
                context.SetEffect(arg1: new[] {73004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000779}, arg2: 0)) {
                    return new State4thBridgeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thBridgeOn01 : TriggerState {
            internal State4thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003382);
                context.SetEffect(arg1: new[] {73004}, arg2: false);
                context.SetMesh(arg1: new[] {33, 34, 35, 36, 37, 38, 39, 40, 41}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.CreateMonster(arg1: new[] {5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120, 5121}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5thBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thBattle01 : TriggerState {
            internal State5thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003382, textId: 20003382);
                context.SetInteractObject(arg1: new[] {10000780}, arg2: 1);
                context.SetEffect(arg1: new[] {73005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000780}, arg2: 0)) {
                    return new State5thBridgeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thBridgeOn01 : TriggerState {
            internal State5thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8006, 8007, 8008}, arg2: false);
                context.HideGuideSummary(entityId: 20003382);
                context.SetEffect(arg1: new[] {73005}, arg2: false);
                context.SetMesh(arg1: new[] {42, 43, 44, 45, 46, 47, 48}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State6thBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6thBattle01 : TriggerState {
            internal State6thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003382, textId: 20003382);
                context.SetInteractObject(arg1: new[] {10000781}, arg2: 1);
                context.SetEffect(arg1: new[] {73006}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000781}, arg2: 0)) {
                    return new State6thBridgeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6thBridgeOn01 : TriggerState {
            internal State6thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8009, 8010}, arg2: false);
                context.HideGuideSummary(entityId: 20003382);
                context.SetEffect(arg1: new[] {73006}, arg2: false);
                context.SetMesh(arg1: new[] {49, 50, 51, 52, 53, 54, 55}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State7thBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7thBattle01 : TriggerState {
            internal State7thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003382, textId: 20003382);
                context.SetInteractObject(arg1: new[] {10000782}, arg2: 1);
                context.SetEffect(arg1: new[] {73007}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000782}, arg2: 0)) {
                    return new State7thBridgeOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7thBridgeOn01 : TriggerState {
            internal State7thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8011, 8012, 8013, 8014, 8015}, arg2: false);
                context.HideGuideSummary(entityId: 20003382);
                context.SetMesh(arg1: new[] {56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20003381, textId: 20003381, duration: 7000);
                context.SetEffect(arg1: new[] {73007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {5100})) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetMesh(arg1: new[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {70010}, arg2: true, arg3: 250, arg4: 50, arg5: 2f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StatePCGetOut01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut01 : TriggerState {
            internal StatePCGetOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StatePCGetOut02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut02 : TriggerState {
            internal StatePCGetOut02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StatePCGetOut03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut03 : TriggerState {
            internal StatePCGetOut03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StatePCGetOut04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut04 : TriggerState {
            internal StatePCGetOut04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}