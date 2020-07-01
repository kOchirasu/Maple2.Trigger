using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000387_bf {
    public static class _01_playparttimejob {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {2000, 2001, 2002, 2003, 2004, 2005, 2006, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4000, arg2: true, arg3: "ry_functobj_door_E01_off");
                context.SetActor(arg1: 4001, arg2: true, arg3: "ry_functobj_door_E01_off");
                context.SetActor(arg1: 4002, arg2: true, arg3: "ry_functobj_door_E01_off");
                context.SetActor(arg1: 4003, arg2: true, arg3: "ry_functobj_door_E01_off");
                context.SetEffect(arg1: new[] {5000, 5101, 5102, 5103, 5104, 5105, 5106}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 9001);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGuideTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk01 : TriggerState {
            internal StateGuideTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__01_PLAYPARTTIMEJOB__0$", arg4: 4);
                context.SetSkip(arg1: "GuideTalk01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGuideTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk01Skip : TriggerState {
            internal StateGuideTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateGuideTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk02 : TriggerState {
            internal StateGuideTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__01_PLAYPARTTIMEJOB__1$", arg4: 4);
                context.SetSkip(arg1: "GuideTalk02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGuideTalk02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk02Skip : TriggerState {
            internal StateGuideTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateGuideTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk03 : TriggerState {
            internal StateGuideTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__01_PLAYPARTTIMEJOB__2$", arg4: 4);
                context.SetSkip(arg1: "GuideTalk03Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGuideTalk03Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk03Skip : TriggerState {
            internal StateGuideTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateGuideTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk04 : TriggerState {
            internal StateGuideTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__01_PLAYPARTTIMEJOB__3$", arg4: 4);
                context.SetSkip(arg1: "GuideTalk04Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGuideTalk04Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideTalk04Skip : TriggerState {
            internal StateGuideTalk04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCPlacement01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlacement01 : TriggerState {
            internal StatePCPlacement01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10, key: "RandomPortalOn", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9005) == 1) {
                    context.State = new StatePCPlacement02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlacement02 : TriggerState {
            internal StatePCPlacement02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9006) == 3) {
                    context.State = new StatePCPlacement03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPlacement03 : TriggerState {
            internal StatePCPlacement03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMartOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMartOpen : TriggerState {
            internal StateMartOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "ry_functobj_door_E01_on");
                context.SetActor(arg1: 4001, arg2: true, arg3: "ry_functobj_door_E01_on");
                context.SetActor(arg1: 4002, arg2: true, arg3: "ry_functobj_door_E01_on");
                context.SetActor(arg1: 4003, arg2: true, arg3: "ry_functobj_door_E01_on");
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__01_PLAYPARTTIMEJOB__4$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateR01Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01Start : TriggerState {
            internal StateR01Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__01_PLAYPARTTIMEJOB__5$", arg3: 3000, arg4: "0");
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.SetEffect(arg1: new[] {5105, 5106}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateR01Customer01Row03Random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01Customer01Row03Random : TriggerState {
            internal StateR01Customer01Row03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 10103);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup3003(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup3007(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup3011(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01Customer02Row02Random : TriggerState {
            internal StateR01Customer02Row02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 10202);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup2002(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup2006(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup2010(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01Customer03Row04Random : TriggerState {
            internal StateR01Customer03Row04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 10304);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    // context.State = new StateNpcGroup4205(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4208(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4212(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4216(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4220(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4224(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup4228(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01Customer04Row01Random : TriggerState {
            internal StateR01Customer04Row01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 10401);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1101(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1105(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1109(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1113(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup1117(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup1121(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01End : TriggerState {
            internal StateR01End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9007, arg2: new[] {0})) {
                    context.State = new StateR02StartDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02StartDelay01 : TriggerState {
            internal StateR02StartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateR02Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Start : TriggerState {
            internal StateR02Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__01_PLAYPARTTIMEJOB__6$", arg3: 3000, arg4: "0");
                context.SetEventUI(arg1: 0, arg2: "2,3");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateR02Customer01Row02Random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer01Row02Random : TriggerState {
            internal StateR02Customer01Row02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20102);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2102(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2106(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2110(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2114(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup2118(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup2122(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer02Row03Random : TriggerState {
            internal StateR02Customer02Row03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20203);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup3203(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3207(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3211(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3215(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3219(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3223(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup3227(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer03Row01Random : TriggerState {
            internal StateR02Customer03Row01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20301);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup1001(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup1005(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup1009(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer04Row04Random : TriggerState {
            internal StateR02Customer04Row04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20404);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4104(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4108(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4112(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4116(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup4120(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup4124(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer05Row02Random : TriggerState {
            internal StateR02Customer05Row02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20502);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup2202(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2206(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2210(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2214(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2218(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2222(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup2226(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer06Row03Random : TriggerState {
            internal StateR02Customer06Row03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20603);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3103(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3107(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3111(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3115(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup3119(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup3123(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer07Row01Random : TriggerState {
            internal StateR02Customer07Row01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20701);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup1201(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1205(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1209(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1213(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1217(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1221(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup1225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02Customer08Row04Random : TriggerState {
            internal StateR02Customer08Row04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 20804);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup4004(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup4008(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup4012(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02End : TriggerState {
            internal StateR02End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9007, arg2: new[] {0})) {
                    context.State = new StateR03StartDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03StartDelay01 : TriggerState {
            internal StateR03StartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateR03Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Start : TriggerState {
            internal StateR03Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__01_PLAYPARTTIMEJOB__7$", arg3: 3000, arg4: "0");
                context.SetEventUI(arg1: 0, arg2: "3,3");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateR03Customer01Row04Random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer01Row04Random : TriggerState {
            internal StateR03Customer01Row04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30104);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4104(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4108(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4112(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup4116(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup4120(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup4124(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer02Row02Random : TriggerState {
            internal StateR03Customer02Row02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30202);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup2202(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2206(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2210(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2214(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2218(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup2222(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup2226(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer03Row03Random : TriggerState {
            internal StateR03Customer03Row03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30303);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup3003(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup3007(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup3011(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer04Row01Random : TriggerState {
            internal StateR03Customer04Row01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30401);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup1001(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup1005(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup1009(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer05Row02Random : TriggerState {
            internal StateR03Customer05Row02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30502);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup2002(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup2006(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup2010(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer06Row04Random : TriggerState {
            internal StateR03Customer06Row04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30604);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup4204(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4208(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4212(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4216(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4220(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup4224(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup4228(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer07Row03Random : TriggerState {
            internal StateR03Customer07Row03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30703);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3103(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3107(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3111(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup3115(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup3119(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup3123(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer08Row01Random : TriggerState {
            internal StateR03Customer08Row01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30801);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1101(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1105(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1109(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup1113(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup1117(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup1121(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer09Row01Random : TriggerState {
            internal StateR03Customer09Row01Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 30901);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup1201(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1205(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1209(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1213(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1217(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup1221(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup1225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer10Row04Random : TriggerState {
            internal StateR03Customer10Row04Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 31004);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup4004(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup4008(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new StateNpcGroup4012(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer11Row02Random : TriggerState {
            internal StateR03Customer11Row02Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 31102);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2102(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2106(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2110(context);
                    return;
                }

                if (context.RandomCondition(arg1: 17f)) {
                    context.State = new StateNpcGroup2114(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup2118(context);
                    return;
                }

                if (context.RandomCondition(arg1: 16f)) {
                    context.State = new StateNpcGroup2122(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03Customer12Row03Random : TriggerState {
            internal StateR03Customer12Row03Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RoundCustomerRow", value: 31203);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup3203(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3207(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3211(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3215(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3219(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new StateNpcGroup3223(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new StateNpcGroup3227(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03End : TriggerState {
            internal StateR03End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.NpcDetected(arg1: 9007, arg2: new[] {0})) {
                    context.State = new StateGameEndNotice01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameEndNotice01 : TriggerState {
            internal StateGameEndNotice01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 02000387, arg2: 1, arg3: 9900);
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__01_PLAYPARTTIMEJOB__8$", arg4: 4);
                context.SetSkip(arg1: "GameEndNotice01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameEndNotice01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameEndNotice01Skip : TriggerState {
            internal StateGameEndNotice01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetUserValue(triggerId: 10, key: "DungeonClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGameWrapUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameWrapUp : TriggerState {
            internal StateGameWrapUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

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
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.UnSetMiniGameAreaForHack();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePCLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCLeave01 : TriggerState {
            internal StatePCLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__01_PLAYPARTTIMEJOB__10$", arg3: 5000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StatePCLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCLeave02 : TriggerState {
            internal StatePCLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateNpcGroup1001 : TriggerState {
            internal StateNpcGroup1001(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1001, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1005 : TriggerState {
            internal StateNpcGroup1005(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1005, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1009 : TriggerState {
            internal StateNpcGroup1009(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1009, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2002 : TriggerState {
            internal StateNpcGroup2002(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2002, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2006 : TriggerState {
            internal StateNpcGroup2006(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2006, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2010 : TriggerState {
            internal StateNpcGroup2010(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2010, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3003 : TriggerState {
            internal StateNpcGroup3003(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3003, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3007 : TriggerState {
            internal StateNpcGroup3007(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3007, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3011 : TriggerState {
            internal StateNpcGroup3011(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3011, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4004 : TriggerState {
            internal StateNpcGroup4004(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4004, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4008 : TriggerState {
            internal StateNpcGroup4008(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4008, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4012 : TriggerState {
            internal StateNpcGroup4012(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4012, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1101 : TriggerState {
            internal StateNpcGroup1101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1101, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1105 : TriggerState {
            internal StateNpcGroup1105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1105, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1109 : TriggerState {
            internal StateNpcGroup1109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1109, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1113 : TriggerState {
            internal StateNpcGroup1113(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1113, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1117 : TriggerState {
            internal StateNpcGroup1117(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1117, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1121 : TriggerState {
            internal StateNpcGroup1121(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1121, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2102 : TriggerState {
            internal StateNpcGroup2102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2102, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2106 : TriggerState {
            internal StateNpcGroup2106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2106, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2110 : TriggerState {
            internal StateNpcGroup2110(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2110, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2114 : TriggerState {
            internal StateNpcGroup2114(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2114, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2118 : TriggerState {
            internal StateNpcGroup2118(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2118, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2122 : TriggerState {
            internal StateNpcGroup2122(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2122, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3103 : TriggerState {
            internal StateNpcGroup3103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3103, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3107 : TriggerState {
            internal StateNpcGroup3107(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3107, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3111 : TriggerState {
            internal StateNpcGroup3111(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3111, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3115 : TriggerState {
            internal StateNpcGroup3115(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3115, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3119 : TriggerState {
            internal StateNpcGroup3119(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3119, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3123 : TriggerState {
            internal StateNpcGroup3123(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3123, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4104 : TriggerState {
            internal StateNpcGroup4104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4104, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4108 : TriggerState {
            internal StateNpcGroup4108(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4108, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4112 : TriggerState {
            internal StateNpcGroup4112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4112, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4116 : TriggerState {
            internal StateNpcGroup4116(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4116, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4120 : TriggerState {
            internal StateNpcGroup4120(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4120, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4124 : TriggerState {
            internal StateNpcGroup4124(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4124, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1201 : TriggerState {
            internal StateNpcGroup1201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1201, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1205 : TriggerState {
            internal StateNpcGroup1205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1205, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1209 : TriggerState {
            internal StateNpcGroup1209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1209, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1213 : TriggerState {
            internal StateNpcGroup1213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1213, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1217 : TriggerState {
            internal StateNpcGroup1217(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1217, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1221 : TriggerState {
            internal StateNpcGroup1221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1221, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup1225 : TriggerState {
            internal StateNpcGroup1225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1225, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2202 : TriggerState {
            internal StateNpcGroup2202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2202, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2206 : TriggerState {
            internal StateNpcGroup2206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2206, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2210 : TriggerState {
            internal StateNpcGroup2210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2210, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2214 : TriggerState {
            internal StateNpcGroup2214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2214, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2218 : TriggerState {
            internal StateNpcGroup2218(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2218, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2222 : TriggerState {
            internal StateNpcGroup2222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2222, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup2226 : TriggerState {
            internal StateNpcGroup2226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2226, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3203 : TriggerState {
            internal StateNpcGroup3203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3203, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3207 : TriggerState {
            internal StateNpcGroup3207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3207, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3211 : TriggerState {
            internal StateNpcGroup3211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3211, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3215 : TriggerState {
            internal StateNpcGroup3215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3215, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3219 : TriggerState {
            internal StateNpcGroup3219(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3219, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3223 : TriggerState {
            internal StateNpcGroup3223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3223, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup3227 : TriggerState {
            internal StateNpcGroup3227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3227, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4204 : TriggerState {
            internal StateNpcGroup4204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4204, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4208 : TriggerState {
            internal StateNpcGroup4208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4208, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4212 : TriggerState {
            internal StateNpcGroup4212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4212, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4216 : TriggerState {
            internal StateNpcGroup4216(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4216, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4220 : TriggerState {
            internal StateNpcGroup4220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4220, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4224 : TriggerState {
            internal StateNpcGroup4224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4224, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcGroup4228 : TriggerState {
            internal StateNpcGroup4228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4228, key: "CustomerEnter", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNextTurnCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNextTurnCheck : TriggerState {
            internal StateNextTurnCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "RoundCustomerRow") == 10103) {
                    context.State = new StateR01Customer02Row02Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 10202) {
                    context.State = new StateR01Customer03Row04Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 10304) {
                    context.State = new StateR01Customer04Row01Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 10401) {
                    context.State = new StateR01End(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20102) {
                    context.State = new StateR02Customer02Row03Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20203) {
                    context.State = new StateR02Customer03Row01Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20301) {
                    context.State = new StateR02Customer04Row04Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20404) {
                    context.State = new StateR02Customer05Row02Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20502) {
                    context.State = new StateR02Customer06Row03Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20603) {
                    context.State = new StateR02Customer07Row01Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20701) {
                    context.State = new StateR02Customer08Row04Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 20804) {
                    context.State = new StateR02End(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30104) {
                    context.State = new StateR03Customer02Row02Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30202) {
                    context.State = new StateR03Customer03Row03Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30303) {
                    context.State = new StateR03Customer04Row01Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30401) {
                    context.State = new StateR03Customer05Row02Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30502) {
                    context.State = new StateR03Customer06Row04Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30604) {
                    context.State = new StateR03Customer07Row03Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30703) {
                    context.State = new StateR03Customer08Row01Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30801) {
                    context.State = new StateR03Customer09Row01Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 30901) {
                    context.State = new StateR03Customer10Row04Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 31004) {
                    context.State = new StateR03Customer11Row02Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 31102) {
                    context.State = new StateR03Customer12Row03Random(context);
                    return;
                }

                if (context.GetUserValue(key: "RoundCustomerRow") == 31203) {
                    context.State = new StateR03End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}