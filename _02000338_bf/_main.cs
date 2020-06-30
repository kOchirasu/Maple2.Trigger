using System;

namespace Maple2.Trigger._02000338_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 120, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 121, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 122, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 123, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 124, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 110, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 111, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 112, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        30001, 30002, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013,
                        30014, 30015, 30016, 30017, 30018, 30019, 30020, 30021, 30022, 30023, 30024, 30025, 30026,
                        30027, 30028, 30029, 30030, 30031, 30032, 30033, 30034
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012,
                        20013, 20014, 20015, 20016, 20017, 20018, 20019, 20020, 20021, 20022, 20023, 20024, 20025,
                        20026, 20027, 20028, 20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036, 20037, 20038,
                        20039, 20040, 20041, 20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050, 20051,
                        20052, 20053, 20054, 20055, 20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064,
                        20065, 20066, 20067, 20068, 20069, 20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077,
                        20078, 20079, 20080, 20081, 20082, 20083, 20084, 20085, 20086, 20087, 20088, 20089, 20090,
                        20091, 20092, 20093, 20094, 20095, 20096, 20097, 20098, 20099, 20100, 20101, 20102, 20103,
                        20104, 20105, 20106, 20107, 20108, 20109, 20110, 20111, 20112, 20113, 20114, 20115, 20116,
                        20117, 20118, 20119, 20120, 20121, 20122, 20123, 20124, 20125, 20126, 20127, 20128, 20129,
                        20130, 20131, 20132, 20133, 20134, 20135, 20136, 20137, 20138, 20139, 20140, 20141, 20142,
                        20143, 20144, 20145, 20146, 20147, 20148, 20149, 20150, 20151, 20152, 20153, 20154, 20155,
                        20156, 20157, 20158, 20159, 20160, 20161, 20162, 20163, 20164, 20165, 20166, 20167, 20168,
                        20169, 20170, 20171, 20172, 20173, 20174, 20175, 20176, 20177, 20178, 20179, 20180, 20181,
                        20182, 20183, 20184, 20185, 20186, 20187, 20188, 20189, 20190, 20191, 20192, 20193, 20194,
                        20195, 20196, 20197, 20198, 20199, 20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207,
                        20208, 20209, 20210, 20211, 20212, 20213, 20214, 20215, 20216, 20217, 20218, 20219, 20220,
                        20221, 20222, 20223, 20224, 20225, 20226, 20227, 20228, 20229, 20230, 20231, 20232, 20233,
                        20234, 20235, 20236, 20237, 20238, 20239, 20240, 20241, 20242, 20243, 20244, 20245, 20246, 20247
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {32000}, arg2: false);
                context.SetEffect(arg1: new int[] {32001}, arg2: false);
                context.SetEffect(arg1: new int[] {32002}, arg2: true);
                context.SetEffect(arg1: new int[] {90000}, arg2: false);
                context.SetEffect(arg1: new int[] {73001}, arg2: false);
                context.SetEffect(arg1: new int[] {73002}, arg2: false);
                context.SetEffect(arg1: new int[] {74500}, arg2: false);
                context.SetEffect(arg1: new int[] {75000}, arg2: false);
                context.SetEffect(arg1: new int[] {75001}, arg2: false);
                context.SetEffect(arg1: new int[] {75002}, arg2: false);
                context.SetEffect(arg1: new int[] {75003}, arg2: false);
                context.SetEffect(arg1: new int[] {75004}, arg2: false);
                context.SetEffect(arg1: new int[] {75005}, arg2: false);
                context.SetEffect(arg1: new int[] {76000}, arg2: false);
                context.SetEffect(arg1: new int[] {76001}, arg2: false);
                context.SetEffect(arg1: new int[] {76002}, arg2: false);
                context.SetEffect(arg1: new int[] {73004}, arg2: false);
                context.SetEffect(arg1: new int[] {73005}, arg2: false);
                context.SetEffect(arg1: new int[] {73006}, arg2: false);
                context.SetEffect(arg1: new int[] {73007}, arg2: false);
                context.SetEffect(arg1: new int[] {74512}, arg2: false);
                context.DestroyMonster(arg1: new int[] {5000});
                context.DestroyMonster(arg1: new int[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010});
                context.SetInteractObject(arg1: new int[] {10000777}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000778}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000779}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000780}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000781}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000782}, arg2: 0);
                context.CreateMonster(arg1: new int[] {5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109},
                    arg2: false);
                context.SetMesh(arg1: new int[] {33, 34, 35, 36, 37, 38, 39, 40, 41}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {42, 43, 44, 45, 46, 47, 48}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {49, 50, 51, 52, 53, 54, 55}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {5100});
                context.DestroyMonster(arg1: new int[] {
                    5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110, 5111, 5112, 5113, 5114, 5115, 5116,
                    5117, 5118, 5119, 5120, 5121, 5122, 5123, 5124, 5125
                });
                context.SetMesh(arg1: new int[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetAgent(arg1: "8011", arg2: true);
                context.SetAgent(arg1: "8012", arg2: true);
                context.SetAgent(arg1: "8013", arg2: true);
                context.SetAgent(arg1: "8014", arg2: true);
                context.SetAgent(arg1: "8015", arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {5100}, arg2: false);
                context.SetMesh(arg1: new int[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009},
                    arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {70010}, arg2: true, arg3: 250, arg4: 50, arg5: 2f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {74512}, arg2: true);
                context.CameraSelect(arg1: 30200, arg2: true);
                context.SetSkip(arg1: "CameraWalk05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraWalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 30201, arg2: true);
                context.SetSkip(arg1: "CameraWalk05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateCameraWalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk04 : TriggerState {
            internal StateCameraWalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetEffect(arg1: new int[] {74500}, arg2: true);
                context.SetSkip(arg1: "CameraWalk05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraWalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk05 : TriggerState {
            internal StateCameraWalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {5000}, arg2: false);
                context.MoveNpc(arg1: 5000, arg2: "MS2PatrolData5000");
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateGroundFall01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGroundFall01 : TriggerState {
            internal StateGroundFall01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {32000}, arg2: true);
                context.SetEffect(arg1: new int[] {32001}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012,
                        20013, 20014, 20015, 20016, 20017, 20018, 20019, 20020
                    }, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20233, 20234, 20235, 20236, 20237, 20238, 20239, 20240, 20241, 20242, 20243, 20244, 20245,
                        20246, 20247
                    }, arg2: false, arg3: 100, arg4: 0, arg5: 50f);
                context.SetMesh(arg1: new int[] {20226, 20227, 20228, 20229, 20230, 20231}, arg2: false, arg3: 100,
                    arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        30001, 30002, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013,
                        30014, 30015, 30016, 30017, 30018, 30019, 30020, 30021, 30022, 30023, 30024, 30025, 30026,
                        30027, 30028, 30029, 30030, 30031, 30032, 30033, 30034
                    }, arg2: false, arg3: 200, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20021, 20022, 20023, 20024, 20025, 20026, 20027, 20028}, arg2: false,
                    arg3: 250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036}, arg2: false,
                    arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[] {
                        20037, 20038, 20039, 20040, 20041, 20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050
                    }, arg2: false, arg3: 750, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[] {
                        20051, 20052, 20053, 20054, 20055, 20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064
                    }, arg2: false, arg3: 1000, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[] {
                        20065, 20066, 20067, 20068, 20069, 20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077,
                        20078, 20079, 20080
                    }, arg2: false, arg3: 1250, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[]
                        {20081, 20082, 20083, 20084, 20085, 20086, 20087, 20088, 20089, 20090, 20091, 20092, 20093},
                    arg2: false, arg3: 1500, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[]
                        {20094, 20095, 20096, 20097, 20098, 20099, 20100, 20101, 20102, 20103, 20104, 20105, 20106},
                    arg2: false, arg3: 1500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20107, 20108, 20109, 20110, 20111, 20112, 20113, 20114, 20115},
                    arg2: false, arg3: 1750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20116, 20117, 20118, 20119, 20120, 20121, 20122, 20123}, arg2: false,
                    arg3: 2000, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20124, 20125, 20126, 20127, 20128, 20129}, arg2: false, arg3: 2250,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20130, 20131, 20132, 20133, 20134, 20135}, arg2: false, arg3: 2500,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20136, 20137, 20138, 20139, 20140, 20141, 20142, 20143}, arg2: false,
                    arg3: 2750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20144, 20145, 20146, 20147, 20148, 20149, 20150, 20151, 20152},
                    arg2: false, arg3: 3000, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20153, 20154, 20155, 20156, 20157}, arg2: false, arg3: 3250, arg4: 50,
                    arg5: 2f);
                context.SetMesh(
                    arg1: new int[]
                        {20158, 20159, 20160, 20161, 20162, 20163, 20164, 20165, 20166, 20167, 20168, 20169},
                    arg2: false, arg3: 3500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20232}, arg2: false, arg3: 3500, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[] {
                        20170, 20171, 20172, 20173, 20174, 20175, 20176, 20177, 20178, 20179, 20180, 20181, 20182,
                        20183, 20184
                    }, arg2: false, arg3: 3750, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[] {
                        20185, 20186, 20187, 20188, 20189, 20190, 20191, 20192, 20193, 20194, 20195, 20196, 20197, 20198
                    }, arg2: false, arg3: 4000, arg4: 50, arg5: 2f);
                context.SetMesh(
                    arg1: new int[]
                        {20199, 20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210},
                    arg2: false, arg3: 4250, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20211, 20212, 20213, 20214, 20215, 20216}, arg2: false, arg3: 4500,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20217, 20218, 20219}, arg2: false, arg3: 4750, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {20220, 20221, 20222, 20223, 20224, 20225}, arg2: false, arg3: 5000,
                    arg4: 50, arg5: 2f);
                context.SetSkip(arg1: "3차어나운스");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3차어나운스(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차어나운스 : TriggerState {
            internal State3차어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReady01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady01 : TriggerState {
            internal StateReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetMesh(arg1: new int[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009, 70010},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {75000}, arg2: true);
                context.SetEffect(arg1: new int[] {75001}, arg2: true);
                context.SetEffect(arg1: new int[] {75002}, arg2: true);
                context.SetEffect(arg1: new int[] {75003}, arg2: true);
                context.SetEffect(arg1: new int[] {75004}, arg2: true);
                context.SetEffect(arg1: new int[] {75005}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20010, 20011, 20012,
                        20013, 20014, 20015, 20016, 20017, 20018, 20019, 20020
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20233, 20234, 20235, 20236, 20237, 20238, 20239, 20240, 20241, 20242, 20243, 20244, 20245,
                        20246, 20247
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20226, 20227, 20228, 20229, 20230, 20231}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        30001, 30002, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011, 30012, 30013,
                        30014, 30015, 30016, 30017, 30018, 30019, 30020, 30021, 30022, 30023, 30024, 30025, 30026,
                        30027, 30028, 30029, 30030, 30031, 30032, 30033, 30034
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20021, 20022, 20023, 20024, 20025, 20026, 20027, 20028}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20037, 20038, 20039, 20040, 20041, 20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20051, 20052, 20053, 20054, 20055, 20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20065, 20066, 20067, 20068, 20069, 20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077,
                        20078, 20079, 20080
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {20081, 20082, 20083, 20084, 20085, 20086, 20087, 20088, 20089, 20090, 20091, 20092, 20093},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {20094, 20095, 20096, 20097, 20098, 20099, 20100, 20101, 20102, 20103, 20104, 20105, 20106},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20107, 20108, 20109, 20110, 20111, 20112, 20113, 20114, 20115},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20116, 20117, 20118, 20119, 20120, 20121, 20122, 20123}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20124, 20125, 20126, 20127, 20128, 20129}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20130, 20131, 20132, 20133, 20134, 20135}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20136, 20137, 20138, 20139, 20140, 20141, 20142, 20143}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20144, 20145, 20146, 20147, 20148, 20149, 20150, 20151, 20152},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20153, 20154, 20155, 20156, 20157}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {20158, 20159, 20160, 20161, 20162, 20163, 20164, 20165, 20166, 20167, 20168, 20169},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20232}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20170, 20171, 20172, 20173, 20174, 20175, 20176, 20177, 20178, 20179, 20180, 20181, 20182,
                        20183, 20184
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        20185, 20186, 20187, 20188, 20189, 20190, 20191, 20192, 20193, 20194, 20195, 20196, 20197, 20198
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {20199, 20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20211, 20212, 20213, 20214, 20215, 20216}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20217, 20218, 20219}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {20220, 20221, 20222, 20223, 20224, 20225}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State1stBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stBattle01 : TriggerState {
            internal State1stBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003382, textID: 20003382);
                context.CreateMonster(arg1: new int[] {5001, 5002, 5003}, arg2: false);
                context.SetEffect(arg1: new int[] {73001}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000777}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000777}, arg2: 0)) {
                    context.State = new State1stBridgeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stBridgeOn01 : TriggerState {
            internal State1stBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {75000}, arg2: false);
                context.SetEffect(arg1: new int[] {75001}, arg2: false);
                context.SetEffect(arg1: new int[] {75002}, arg2: false);
                context.SetEffect(arg1: new int[] {75003}, arg2: false);
                context.SetEffect(arg1: new int[] {75004}, arg2: false);
                context.SetEffect(arg1: new int[] {75005}, arg2: false);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.HideGuideSummary(entityID: 20003382);
                context.SetEffect(arg1: new int[] {73001}, arg2: false);
                context.SetMesh(arg1: new int[] {20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32}, arg2: true,
                    arg3: 100, arg4: 50, arg5: 2f);
                context.CreateMonster(arg1: new int[] {5004, 5005, 5006, 5007, 5008, 5009, 5010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2ndBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndBattle01 : TriggerState {
            internal State2ndBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003382, textID: 20003382);
                context.SetInteractObject(arg1: new int[] {10000778}, arg2: 1);
                context.SetEffect(arg1: new int[] {73002}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000778}, arg2: 0)) {
                    context.State = new State2ndBridgeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndBridgeOn01 : TriggerState {
            internal State2ndBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.HideGuideSummary(entityID: 20003382);
                context.ShowGuideSummary(entityID: 20003386, textID: 20003386, durationTime: 5000);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.SetEffect(arg1: new int[] {73002}, arg2: false);
                context.SetMesh(arg1: new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19},
                    arg2: true, arg3: 100, arg4: 50, arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {5000})) {
                    context.State = new State3rdBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdBattle01 : TriggerState {
            internal State3rdBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {76000}, arg2: true);
                context.SetEffect(arg1: new int[] {76001}, arg2: true);
                context.SetEffect(arg1: new int[] {76002}, arg2: true);
                context.SetLadder(arg1: 120, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 121, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 122, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 123, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 124, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 110, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 111, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 112, arg2: true, arg3: true, arg4: 6);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "999998")) {
                    context.State = new State3rdBrigeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdBrigeOn01 : TriggerState {
            internal State3rdBrigeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {76000}, arg2: false);
                context.SetEffect(arg1: new int[] {76001}, arg2: false);
                context.SetEffect(arg1: new int[] {76002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thBattle01 : TriggerState {
            internal State4thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003382, textID: 20003382);
                context.SetInteractObject(arg1: new int[] {10000779}, arg2: 1);
                context.SetEffect(arg1: new int[] {73004}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000779}, arg2: 0)) {
                    context.State = new State4thBridgeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thBridgeOn01 : TriggerState {
            internal State4thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20003382);
                context.SetEffect(arg1: new int[] {73004}, arg2: false);
                context.SetMesh(arg1: new int[] {33, 34, 35, 36, 37, 38, 39, 40, 41}, arg2: true, arg3: 100, arg4: 50,
                    arg5: 2f);
                context.CreateMonster(
                    arg1: new int[] {5110, 5111, 5112, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5120, 5121},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State5thBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thBattle01 : TriggerState {
            internal State5thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003382, textID: 20003382);
                context.SetInteractObject(arg1: new int[] {10000780}, arg2: 1);
                context.SetEffect(arg1: new int[] {73005}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000780}, arg2: 0)) {
                    context.State = new State5thBridgeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thBridgeOn01 : TriggerState {
            internal State5thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.HideGuideSummary(entityID: 20003382);
                context.SetEffect(arg1: new int[] {73005}, arg2: false);
                context.SetMesh(arg1: new int[] {42, 43, 44, 45, 46, 47, 48}, arg2: true, arg3: 100, arg4: 50,
                    arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State6thBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6thBattle01 : TriggerState {
            internal State6thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003382, textID: 20003382);
                context.SetInteractObject(arg1: new int[] {10000781}, arg2: 1);
                context.SetEffect(arg1: new int[] {73006}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000781}, arg2: 0)) {
                    context.State = new State6thBridgeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6thBridgeOn01 : TriggerState {
            internal State6thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.HideGuideSummary(entityID: 20003382);
                context.SetEffect(arg1: new int[] {73006}, arg2: false);
                context.SetMesh(arg1: new int[] {49, 50, 51, 52, 53, 54, 55}, arg2: true, arg3: 100, arg4: 50,
                    arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State7thBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7thBattle01 : TriggerState {
            internal State7thBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003382, textID: 20003382);
                context.SetInteractObject(arg1: new int[] {10000782}, arg2: 1);
                context.SetEffect(arg1: new int[] {73007}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000782}, arg2: 0)) {
                    context.State = new State7thBridgeOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7thBridgeOn01 : TriggerState {
            internal State7thBridgeOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.SetAgent(arg1: "8013", arg2: false);
                context.SetAgent(arg1: "8014", arg2: false);
                context.SetAgent(arg1: "8015", arg2: false);
                context.HideGuideSummary(entityID: 20003382);
                context.SetMesh(arg1: new int[] {56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66}, arg2: true, arg3: 100,
                    arg4: 50, arg5: 2f);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20003381, textID: 20003381, durationTime: 7000);
                context.SetEffect(arg1: new int[] {73007}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {5100})) {
                    context.State = new StateBossBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetMesh(arg1: new int[] {70001, 70002, 70003, 70004, 70005, 70006, 70007, 70008, 70009},
                    arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {70010}, arg2: true, arg3: 250, arg4: 50, arg5: 2f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StatePCGetOut01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut01 : TriggerState {
            internal StatePCGetOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StatePCGetOut02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut02 : TriggerState {
            internal StatePCGetOut02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StatePCGetOut03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut03 : TriggerState {
            internal StatePCGetOut03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StatePCGetOut04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut04 : TriggerState {
            internal StatePCGetOut04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}