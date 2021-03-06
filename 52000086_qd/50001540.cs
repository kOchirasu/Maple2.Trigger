using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000086_qd {
    public static class _50001540 {
        public class StateQuest체크50100300_1 : TriggerState {
            internal StateQuest체크50100300_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100300}, arg3: new byte[] {3})) {
                    // return new State던전종료(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100300}, arg3: new byte[] {2})) {
                    // return new State던전종료(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100300}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크50100310_1 : TriggerState {
            internal StateQuest체크50100310_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100310}, arg3: new byte[] {3})) {
                    // return new State던전종료(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100310}, arg3: new byte[] {2})) {
                    // return new State던전종료(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100310}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크50100311_1 : TriggerState {
            internal StateQuest체크50100311_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100311}, arg3: new byte[] {3})) {
                    // return new State던전종료(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100311}, arg3: new byte[] {2})) {
                    // return new State던전종료(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100311}, arg3: new byte[] {1})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4004, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4005, arg2: true, arg3: "Closed");
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetMesh(arg1: new[] {3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3102, 3103, 3104, 3105}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3160, 3161, 3162, 3163, 3164}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
                context.RemoveBuff(arg1: 199, arg2: 70000115);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000086, arg2: 99);
                context.SetSkip(state: new StateStopCinematic(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State에르다Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script01 : TriggerState {
            internal State에르다Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000086_QD__50001540__0$", align: Align.Right, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script02 : TriggerState {
            internal State에르다Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000086_QD__50001540__1$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State설눈이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script01 : TriggerState {
            internal State설눈이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000086_QD__50001540__2$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State비에른Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script01 : TriggerState {
            internal State비에른Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__50001540__3$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State설눈이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이Script02 : TriggerState {
            internal State설눈이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000086_QD__50001540__4$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State비에른방향전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른방향전환 : TriggerState {
            internal State비에른방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000086_QD__50001540__5$", align: Align.Right, duration: 2000);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비에른공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른공격 : TriggerState {
            internal State비에른공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 306, arg2: true);
                context.SetNpcEmotionSequence(arg1: 1003, arg2: "Attack_01_D");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000086_QD__50001540__6$", align: Align.Right, duration: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State설눈이스턴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State설눈이스턴 : TriggerState {
            internal State설눈이스턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetNpcEmotionLoop(arg1: 1001, arg2: "Stun_A", arg3: 999999999999f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에르다Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script03 : TriggerState {
            internal State에르다Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000086_QD__50001540__7$", align: Align.Right, duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State비에른Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script02 : TriggerState {
            internal State비에른Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 307, arg2: true);
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__50001540__8$", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", script: "$52000086_QD__50001540__9$", align: Align.Right, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State비에른Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script03 : TriggerState {
            internal State비에른Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003B");
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__50001540__10$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State에르다Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script04 : TriggerState {
            internal State에르다Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 309, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000086_QD__50001540__11$", align: Align.Right, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에르다Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에르다Script05 : TriggerState {
            internal State에르다Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: true);
                context.SetNpcEmotionLoop(arg1: 1002, arg2: "AttackReady_01_A", arg3: 999999999999f);
                context.AddCinematicTalk(npcId: 11003069, illustId: "SnowQueen_normal", script: "$52000086_QD__50001540__12$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003});
                context.CreateMonster(arg1: new[] {1004, 1005}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 1004, arg2: "Stun_A", arg3: 999999999999f);
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "AttackReady_01_A", arg3: 999999999999f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBuff(arg1: new[] {199}, arg2: 70000115, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State1차게이트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차게이트 : TriggerState {
            internal State1차게이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.ShowGuideSummary(entityId: 25200861, textId: 25200861, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State2차게이트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차게이트 : TriggerState {
            internal State2차게이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new State3차게이트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차게이트 : TriggerState {
            internal State3차게이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2003})) {
                    return new State4차게이트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차게이트 : TriggerState {
            internal State4차게이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
                context.SetActor(arg1: 4004, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2004})) {
                    return new State감지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지Wait : TriggerState {
            internal State감지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3105}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.ShowGuideSummary(entityId: 25200862, textId: 25200862, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State2차StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차StartCinematic : TriggerState {
            internal State2차StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new State2차StopCinematic(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 311, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State비에른Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script04 : TriggerState {
            internal State비에른Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__50001540__13$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State비에른Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비에른Script05 : TriggerState {
            internal State비에른Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 312, arg2: true);
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006A");
                context.AddCinematicTalk(npcId: 11003075, illustId: "SnowKing_normal", script: "$52000086_QD__50001540__14$", align: Align.Left, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2차StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차StopCinematic : TriggerState {
            internal State2차StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetPortal(portalId: 91, visible: false, enabled: false, minimapVisible: false);
                context.DestroyMonster(arg1: new[] {1006});
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBuff(arg1: new[] {199}, arg2: 70000115, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
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