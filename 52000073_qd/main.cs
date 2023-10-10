using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000073_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100115}, questStates: new byte[]{1})) {
                    return new State레논Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Spawn : TriggerState {
            internal State레논Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG\weather\Eff_monochrome_03.xml");
                context.SetSound(triggerId: 7001, enabled: true);
                context.DestroyMonster(spawnIds: new []{101});
                context.VisibleMyPc(visible: false);
                context.SetAmbientLight(color: default);
                context.SetAmbientLight(color: new Vector3(1f, 1f, 1f));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{302});
                context.CreateMonster(spawnIds: new []{301});
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
                context.SetSceneSkip(state: new State다크윈드통로(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State계단이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단이동 : TriggerState {
            internal State계단이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003, 8004}, returnView: false);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_2001");
                context.SetConversation(type: 1, spawnId: 301, script: "$52000073_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State시체발견(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시체발견 : TriggerState {
            internal State시체발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$52000073_QD__MAIN__1$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_2002");
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State의문(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의문 : TriggerState {
            internal State의문(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$52000073_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State상황파악(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State상황파악 : TriggerState {
            internal State상황파악(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7002, enabled: true);
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.SetConversation(type: 1, spawnId: 301, script: "$52000073_QD__MAIN__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 301, sequenceName: "Sit_down_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State현장목격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State현장목격 : TriggerState {
            internal State현장목격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
                context.CreateMonster(spawnIds: new []{303});
                context.CreateMonster(spawnIds: new []{304});
                context.SetConversation(type: 1, spawnId: 303, script: "$52000073_QD__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Attack_Idle_A", duration: 1500f);
                context.SetNpcEmotionLoop(spawnId: 304, sequenceName: "Attack_Idle_A", duration: 1500f);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_2005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해1 : TriggerState {
            internal State오해1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 303, script: "$52000073_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 304, script: "$52000073_QD__MAIN__6$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해2 : TriggerState {
            internal State오해2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 303, script: "$52000073_QD__MAIN__7$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 301, script: "$52000073_QD__MAIN__8$", arg4: 3, arg5: 1);
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Attack_01_A", duration: 2000f);
                context.SetNpcEmotionLoop(spawnId: 301, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해3 : TriggerState {
            internal State오해3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 303, script: "$52000073_QD__MAIN__9$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 304, script: "$52000073_QD__MAIN__10$", arg4: 3, arg5: 2);
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 304, patrolName: "MS2PatrolData_2004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해4 : TriggerState {
            internal State오해4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Attack_Idle_A", duration: 5000f);
                context.SetConversation(type: 1, spawnId: 303, script: "$52000073_QD__MAIN__11$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 304, sequenceName: "Attack_Idle_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오해5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오해5 : TriggerState {
            internal State오해5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$52000073_QD__MAIN__12$", arg4: 5, arg5: 0);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_2006");
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Attack_Idle_A", duration: 6000f);
                context.SetNpcEmotionLoop(spawnId: 304, sequenceName: "Attack_Idle_A", duration: 6000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State쓰러짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쓰러짐 : TriggerState {
            internal State쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 303, sequenceName: "Down_Idle_A", duration: 500000f);
                context.SetNpcEmotionLoop(spawnId: 304, sequenceName: "Down_Idle_A", duration: 500000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출 : TriggerState {
            internal State탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State레논탈출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논탈출 : TriggerState {
            internal State레논탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{301});
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera시점변경_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera시점변경_ready : TriggerState {
            internal StateCamera시점변경_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera시점변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera시점변경 : TriggerState {
            internal StateCamera시점변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카트반Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반Spawn : TriggerState {
            internal State카트반Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{305});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카트반이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반이동 : TriggerState {
            internal State카트반이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 305, patrolName: "MS2PatrolData_2008");
                context.SetConversation(type: 1, spawnId: 305, script: "$52000073_QD__MAIN__13$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State의미심장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의미심장 : TriggerState {
            internal State의미심장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11001024, script: "$52000073_QD__MAIN__14$", duration: 3000, align: Align.Center);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State다크윈드통로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다크윈드통로 : TriggerState {
            internal State다크윈드통로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.CreateMonster(spawnIds: new []{101});
                context.DestroyMonster(spawnIds: new []{301, 302, 303, 304, 305});
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 52000138, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
