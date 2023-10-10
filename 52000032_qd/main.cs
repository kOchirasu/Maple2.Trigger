namespace Maple2.Trigger._52000032_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Idle_A");
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetEffect(triggerIds: new []{602, 603, 604, 605, 606, 607, 608, 609}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enabled: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 2001}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State홀슈타트변신(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트변신 : TriggerState {
            internal State홀슈타트변신(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2001});
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.AddBuff(boxIds: new []{2002}, skillId: 71000005, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유페리아Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script01 : TriggerState {
            internal State유페리아Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Idle_A");
                context.CameraSelect(triggerId: 3022, enabled: true);
                context.SetEffect(triggerIds: new []{606}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001564, script: "$52000032_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유페리아돌진(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아돌진 : TriggerState {
            internal State유페리아돌진(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enabled: true);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCamera전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera전환 : TriggerState {
            internal StateCamera전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIshura돌진(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura돌진 : TriggerState {
            internal StateIshura돌진(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.CameraSelect(triggerId: 3033, enabled: true);
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 550)) {
                    return new State홀슈타트어택(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트어택 : TriggerState {
            internal State홀슈타트어택(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.SetEffect(triggerIds: new []{604, 602}, visible: true);
                    return new State화면전환Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면전환Wait : TriggerState {
            internal State화면전환Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.DestroyMonster(spawnIds: new []{1001, 1003});
                    return new State홀슈타트Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트Script01 : TriggerState {
            internal State홀슈타트Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3034, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001231, script: "$52000032_QD__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State홀슈타트이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트이동 : TriggerState {
            internal State홀슈타트이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002_B");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{2002})) {
                    return new State홀슈타트소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트소멸 : TriggerState {
            internal State홀슈타트소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1101, 1102}, arg2: false);
                context.DestroyMonster(spawnIds: new []{2002});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Idle_A");
                context.CreateMonster(spawnIds: new []{2099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101}, jobCode: 01)) {
                    return new State투입Script10(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 10)) {
                    return new State투입Script10(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 20)) {
                    return new State투입Script20(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 30)) {
                    return new State투입Script30(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 40)) {
                    return new State투입Script40(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 50)) {
                    return new State투입Script50(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 60)) {
                    return new State투입Script60(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 70)) {
                    return new State투입Script70(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 80)) {
                    return new State투입Script80(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 90)) {
                    return new State투입Script90(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투입Script10 : TriggerState {
            internal State투입Script10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11000076, script: "$52000032_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script20 : TriggerState {
            internal State투입Script20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001581, script: "$52000032_QD__MAIN__5$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script30 : TriggerState {
            internal State투입Script30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State투입Script30_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투입Script30_1 : TriggerState {
            internal State투입Script30_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000032, script: "$52000032_QD__MAIN__7$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script40 : TriggerState {
            internal State투입Script40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001578, script: "$52000032_QD__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script50 : TriggerState {
            internal State투입Script50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__10$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11000015, script: "$52000032_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script60 : TriggerState {
            internal State투입Script60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__12$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001583, script: "$52000032_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script70 : TriggerState {
            internal State투입Script70(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__14$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001586, script: "$52000032_QD__MAIN__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script80 : TriggerState {
            internal State투입Script80(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__16$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001584, script: "$52000032_QD__MAIN__17$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State투입Script90 : TriggerState {
            internal State투입Script90(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__18$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__19$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State누타만전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State누타만전투 : TriggerState {
            internal State누타만전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new State누타만전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State누타만전투종료 : TriggerState {
            internal State누타만전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 305, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State렌듀비앙Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙Script01 : TriggerState {
            internal State렌듀비앙Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1103, 1104}, arg2: false);
                context.CameraSelect(triggerId: 304, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001575, script: "$52000032_QD__MAIN__20$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유페리아Script_흐느낌(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script_흐느낌 : TriggerState {
            internal State유페리아Script_흐느낌(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{607}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001576, script: "$52000032_QD__MAIN__21$", arg4: 8, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State아노스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01 : TriggerState {
            internal State아노스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{609}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000032, script: "$52000032_QD__MAIN__22$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State렌듀비앙Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙Script02 : TriggerState {
            internal State렌듀비앙Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000032_QD__MAIN__23$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State렌듀비앙이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙이동 : TriggerState {
            internal State렌듀비앙이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1103, patrolName: "MS2PatrolData_1103_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State렌듀비앙캐스팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙캐스팅 : TriggerState {
            internal State렌듀비앙캐스팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1103}, skillId: 71000004, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "ClearNutaman");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02000023, portalId: 100);
            }
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
